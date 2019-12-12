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
using RPGMasterTools.Source.Enumeration.System;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Model.Sys;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View.Sound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private List<Music> _pastPlayedMusicIndex;
        private Music _currentMusic;

        private bool _repeat = false;
        private bool _random = false;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightMusicController(IComponent<EnumStateSoundRightMusic> component, GenericController parentController) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._mPlayer = new WMPLib.WindowsMediaPlayer();
            this._mPlayer.settings.volume = 100;
            this._pastPlayedMusicIndex = new List<Music>();
        }

        // == DESTRUCTOR
        // ==============================================================

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
                if (currentState != EnumStateSoundRightMusic.STATE_PLAY && currentState != EnumStateSoundRightMusic.STATE_RESUME && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST_ADD && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST_RECREATE)
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
                if (currentState != EnumStateSoundRightMusic.STATE_PLAYING && currentState != EnumStateSoundRightMusic.STATE_PRESET_LOADED)
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
                if (currentState != EnumStateSoundRightMusic.STATE_PAUSE && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST_ADD && currentState != EnumStateSoundRightMusic.STATE_UPDATE_LIST_RECREATE)
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

            if(this.currentState == EnumStateSoundRightMusic.STATE_UPDATE_LIST_ADD)
            {
                this.currentState = this.lastState;
            }
            else if (this.currentState == EnumStateSoundRightMusic.STATE_UPDATE_LIST_RECREATE)
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
            else if (this.currentState == EnumStateSoundRightMusic.STATE_PRESET_LOADED)
            {
                PresetMusic preset = ((SoundController)this.parentController.parentController).currentPreset.musicPreset;

                if (this.lastState == EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                }
                else
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_IDLE;
                }

                // AUTO-PLAY

                if (preset.autoPlay)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
                }
            }
        }

        private void startPlayMusic()
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;

            if (currentMusic != null || currentMusicList.Count > 0)
            {
                if (this._currentMusic == null)
                {
                    processNextSound();
                }

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
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;

            if ( this._mPlayer.controls.currentPosition < 5 && this._pastPlayedMusicIndex.Count > 0 )
            {
                // GO TO PREVIOUS MUSIC (IF IT ALREADY EXISTS)
                bool exists = false;
                Music lastMusic = null;

                do
                {
                    lastMusic = this._pastPlayedMusicIndex[this._pastPlayedMusicIndex.Count - 1];

                    if( currentMusicList.Contains(lastMusic) )
                    {
                        exists = true;
                    }
                    else
                    {
                        this._pastPlayedMusicIndex.RemoveAll( item => item == lastMusic );
                    }
                }
                while (!exists);

                if( currentMusicList.Contains(lastMusic) )
                {

                }

                this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                this._currentMusic = lastMusic;
                this._pastPlayedMusicIndex.RemoveAt(this._pastPlayedMusicIndex.Count - 1);
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
            else
            {
                // REPEAT THE SAME MUSIC

                Music currentMusic = this._currentMusic;
                this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                this._currentMusic = currentMusic;
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
        }

        private void nextMusic()
        {
            // SET TO LAST PLAYED LIST

            if (this._pastPlayedMusicIndex.Count > 0)
            {
                Music lastMusic = this._pastPlayedMusicIndex[this._pastPlayedMusicIndex.Count - 1];

                if (this._currentMusic != lastMusic)
                {
                    this._pastPlayedMusicIndex.Add(this._currentMusic);
                }
            }
            else
            {
                this._pastPlayedMusicIndex.Add(this._currentMusic);
            }

            // GO TO NEXT MUSIC

            this.currentState = EnumStateSoundRightMusic.STATE_STOP;

            processNextSound();

            this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
        }

        public void jumpToMusic(Music music)
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;

            if ( currentMusicList.Contains(music) )
            {
                this.currentState = EnumStateSoundRightMusic.STATE_STOP;
                this._currentMusic = music;
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
        }

        public void processNextSound()
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;

            if (random && currentMusicList.Count > 1)
            {
                Music nextMusic = null;

                // AVOIDING THE SAME SONG BEING CHOOSE ON RANDOM.

                do
                {
                    nextMusic = currentMusicList[ URandom.generateRandomNumberInRange(0, currentMusicList.Count) ];
                }
                while (nextMusic == this._currentMusic);

                this._currentMusic = nextMusic;
            }
            else
            {
                if (currentMusic != null)
                {
                    int currentMusicIndex = currentMusicList.IndexOf(this._currentMusic);

                    if (currentMusicIndex < (currentMusicList.Count - 1))
                    {
                        this._currentMusic = currentMusicList[++currentMusicIndex];
                    }
                    else
                    {
                        this._currentMusic = currentMusicList[0];
                    }
                }
                else
                {
                    this._currentMusic = currentMusicList[0];
                }
            }
        }

        public override void Dispose()
        {
            base.Dispose();

            this._mPlayer.controls.stop();
            this._mPlayer.close();
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if(parentController is MainController)
            {
                MainController pController = (MainController) parentController;

                if( pController.currentState == EnumStateMain.STATE_GLOBAL_HOTKEY_PRESSED )
                {
                    Hotkey cHotkey = pController.lastPressedHotKey;

                    if(cHotkey.modifier == EnumKeyModifier.MOD_SHIFT)
                    {
                        switch(cHotkey.key)
                        {
                            case Keys.P:

                                if(this.currentState == EnumStateSoundRightMusic.STATE_PLAYING)
                                {
                                    this.currentState = EnumStateSoundRightMusic.STATE_PAUSE;
                                }
                                else
                                {
                                    this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
                                }

                                break;

                            case Keys.S:

                                this.currentState = EnumStateSoundRightMusic.STATE_STOP;

                                break;

                            case Keys.N:

                                this.currentState = EnumStateSoundRightMusic.STATE_NEXT;

                                break;

                            case Keys.B:

                                this.currentState = EnumStateSoundRightMusic.STATE_BACK;

                                break;

                            case Keys.Oemplus:

                                this.volume += 10;
                                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;

                                break;

                            case Keys.OemMinus:

                                this.volume -= 10;
                                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;

                                break;

                            case Keys.R:

                                this.random = !this.random;
                                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;

                                break;

                            case Keys.D:

                                this.repeat = !this.repeat;
                                this.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;

                                break;

                            default:

                                base.onParentStateChange(parentController);

                                break;
                        }
                    }
                }
            }
            else if( parentController is SoundController )
            {
                SoundController pController = (SoundController) parentController;

                if(pController.currentState == EnumStateSound.STATE_MUSIC_LIST_ADDED)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_UPDATE_LIST_ADD;
                }
                else if(pController.currentState == EnumStateSound.STATE_MUSIC_LIST_REMOVED)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_UPDATE_LIST_RECREATE;
                }
                else if (pController.currentState == EnumStateSound.STATE_PRESET_LOADED)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_PRESET_LOADED;
                }
                else
                {
                    base.onParentStateChange(parentController);
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
                this.currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
            else
            {
                this.currentState = EnumStateSoundRightMusic.STATE_NEXT;
            }
        }

        private void onPresetLoad()
        {
            this.currentState = EnumStateSoundRightMusic.STATE_STOP;
            Preset preset = ( (SoundController) this.parentController.parentController).currentPreset;
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
            }
        }

        public bool random
        {
            get { return this._random; }
            set
            {
                this._random = value;
            }
        }

        public int lastMusicIndex
        {
            get
            {
                int retValue = -1;

                if (this._pastPlayedMusicIndex.Count > 0)
                {
                    Music lastMusic = this._pastPlayedMusicIndex[this._pastPlayedMusicIndex.Count - 1];

                    List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;
                    retValue = currentMusicList.IndexOf(lastMusic);
                }

                return retValue;
            }
        }

        public int currentMusicIndex
        {
            get
            {
                int retValue = -1;

                if (this._currentMusic != null)
                {
                    List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;
                    retValue = currentMusicList.IndexOf(this._currentMusic);
                }

                return retValue;
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

        public int volume
        {
            get { return this._mPlayer.settings.volume; }
            set
            {
                if (value < 0)
                {
                    this._mPlayer.settings.volume = 0;
                }
                else if (value > 100)
                {
                    this._mPlayer.settings.volume = 100;
                }
                else
                {
                    this._mPlayer.settings.volume = value;
                }
            }
        }
    }
}
