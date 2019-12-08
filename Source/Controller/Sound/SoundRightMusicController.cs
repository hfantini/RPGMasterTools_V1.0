/*

    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +
    |
    |	RPGMasterTools
    |
    |	A multitool software for D&D game masters.
    |	
    |	== INFO ==
    |
    |	By Henrique Fantini @ 2019
    |	www.henriquefantini.com
    |	contact@henriquefantini.com
    |
    |	== FILE DETAILS 
    |
    |	Name: [SoundRightMusicController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Controller of SoundLeftPanelMusic
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    public class SoundRightMusicController : ComponentController<EnumStateSoundRightMusic>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private WindowsMediaPlayer _mPlayer;
        private List<Int32> _pastPlayedMusicIndex;
        private int _currentMusicIndex = -1;
        private Music _currentMusic;

        private bool _repeat = false;
        private bool _random = false;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightMusicController(IComponent<EnumStateSoundRightMusic> component, GenericController parentController) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._mPlayer = new WMPLib.WindowsMediaPlayer();
            this._pastPlayedMusicIndex = new List<Int32>();
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateSoundRightMusic currentState, EnumStateSoundRightMusic nextState)
        {
            bool retValue = true;

            if (nextState == EnumStateSoundRightMusic.STATE_PLAY)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_IDLE && currentState != EnumStateSoundRightMusic.STATE_NONE && currentState != EnumStateSoundRightMusic.STATE_PAUSED && currentState != EnumStateSoundRightMusic.STATE_NEXT && currentState != EnumStateSoundRightMusic.STATE_BACK && currentState != EnumStateSoundRightMusic.STATE_MEDIA_END)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_PLAYING)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAY && currentState != EnumStateSoundRightMusic.STATE_RESUME && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_NOTHING_TO_PLAY)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAY)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_STOP)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_PAUSE)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_PAUSED)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PAUSE && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_RESUME)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PAUSED)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_NEXT)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING && currentState != EnumStateSoundRightMusic.STATE_MEDIA_END)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_BACK)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_MEDIA_END)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    retValue = false;
                }
            }

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateSoundRightMusic.STATE_UPDATE_LIST)
            {
                this.currentState = this.lastState;
            }
            else if(this.currentState == EnumStateSoundRightMusic.STATE_PLAY)
            {
                startPlayMusic();
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_NOTHING_TO_PLAY)
            {
                this.currentState = EnumStateSoundRightMusic.STATE_IDLE;
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_STOP)
            {
                stopMusic();
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_PAUSE)
            {
                pauseMusic();
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_RESUME)
            {
                resumeMusic();
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_OPTION_UPDATE)
            {
                this.currentState = this.lastState;
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_BACK)
            {
                backMusic();
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_NEXT)
            {
                nextMusic();
            }
            else if(this.currentState == EnumStateSoundRightMusic.STATE_MEDIA_END)
            {
                onMediaPlayFinish();
            }
        }

        private void startPlayMusic()
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;
 
            if (currentMusicList.Count > 0)
            {
                if (currentMusicIndex == -1)
                {
                    processNextSound();
                }

                this._currentMusic = currentMusicList[this.currentMusicIndex];
                this._mPlayer.URL = this.currentMusic.path + "\\" + this.currentMusic.name;
                this._mPlayer.controls.play();
 
                this.currentState = EnumStateSoundRightMusic.STATE_PLAYING;
            }
            else
            {
                this._currentMusic = null;
                this.currentState = EnumStateSoundRightMusic.STATE_NOTHING_TO_PLAY;
            }
        }

        private void stopMusic()
        {
            this._mPlayer.controls.stop();
            this._currentMusicIndex = -1;
            this._currentMusic = null;

            this.currentState = EnumStateSoundRightMusic.STATE_IDLE;
        }

        private void pauseMusic()
        {
            this._mPlayer.controls.pause();
            this.currentState = EnumStateSoundRightMusic.STATE_PAUSED;
        }

        private void resumeMusic()
        {
            this._mPlayer.controls.play();
            this.currentState = EnumStateSoundRightMusic.STATE_PLAYING;
        }

        private void backMusic()
        {
            if( this._mPlayer.controls.currentPosition < 5 && this._pastPlayedMusicIndex.Count > 0 )
            {
                // GO TO PREVIOUS MUSIC
                int lastIndex = this._pastPlayedMusicIndex[this._pastPlayedMusicIndex.Count - 1];
                this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                this._currentMusicIndex = lastIndex;
                this._pastPlayedMusicIndex.RemoveAt(this._pastPlayedMusicIndex.Count - 1);
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
            else
            {
                // REPEAT THE SAME MUSIC
                int index = this._currentMusicIndex;
                this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                this._currentMusicIndex = index;
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
        }

        private void nextMusic()
        {
            // SET TO LAST PLAYED LIST

            if (this._pastPlayedMusicIndex.Count > 0)
            {
                int lastIndex = this._pastPlayedMusicIndex[this._pastPlayedMusicIndex.Count - 1];

                if (this._currentMusicIndex != lastIndex)
                {
                    this._pastPlayedMusicIndex.Add(_currentMusicIndex);
                }
            }
            else
            {
                this._pastPlayedMusicIndex.Add(this._currentMusicIndex);
            }

            // GO TO NEXT MUSIC

            this.currentState = EnumStateSoundRightMusic.STATE_STOP;

            processNextSound();

            this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
        }

        public void processNextSound()
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;

            if (random && currentMusicList.Count > 1)
            {
                int nextIndex = -1;

                // AVOIDING THE SAME SONG BEING CHOOSE ON RANDOM.

                do
                {
                    nextIndex = URandom.generateRandomNumberInRange(0, currentMusicList.Count);
                }
                while (nextIndex == this._currentMusicIndex);

                this._currentMusicIndex = nextIndex;
            }
            else
            {
                if( this._currentMusicIndex < (currentMusicList.Count - 1) )
                {
                    this._currentMusicIndex++;
                }
                else
                {
                    this._currentMusicIndex = 0;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if( parentController is SoundController )
            {
                SoundController pController = (SoundController) parentController;

                if(pController.currentState == EnumStateSound.STATE_MUSIC_LIST_CHANGED)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_UPDATE_LIST;
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        private void onMediaPlayFinish()
        {
            if(repeat)
            {
                currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
            else
            {
                currentState = EnumStateSoundRightMusic.STATE_NEXT;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public Music currentMusic
        {
            get { return this._currentMusic; }
        }

        public bool repeat
        {
            get { return this._repeat; }
            set
            {
                this._repeat = value;
                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;
            }
        }

        public bool random
        {
            get { return this._random; }
            set
            {
                this._random = value;
                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;
            }
        }

        public string currentMusicPositionTime
        {
            get { return this._mPlayer.controls.currentPositionString; }
        }

        public string totalMusicTime
        {
            get
            {
                string retValue = "00:00";

                if (this._mPlayer.currentMedia != null)
                {
                    retValue = this._mPlayer.currentMedia.durationString;
                }

                return retValue;
            }
        }

        public WMPPlayState wmpIsPlaying
        {
            get { return this._mPlayer.playState; }
        }

        private int currentMusicIndex
        {
            get { return this._currentMusicIndex; }
        }

        public int volume
        {
            get { return this._mPlayer.settings.volume; }
            set
            {
                this._mPlayer.settings.volume = value;
            }
        }
    }
}
