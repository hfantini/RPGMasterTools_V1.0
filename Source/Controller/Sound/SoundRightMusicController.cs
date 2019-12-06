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

        private WMPLib.WindowsMediaPlayer _mPlayer;
        private int _currentMusicIndex;
        private Music _currentMusic;

        private bool _repeat = false;
        private bool _random = false;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightMusicController(IComponent<EnumStateSoundRightMusic> component, GenericController parentController) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._mPlayer = new WMPLib.WindowsMediaPlayer();
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateSoundRightMusic currentState, EnumStateSoundRightMusic nextState)
        {
            bool retValue = true;

            if (nextState == EnumStateSoundRightMusic.STATE_PLAY)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_IDLE && currentState != EnumStateSoundRightMusic.STATE_NONE && currentState != EnumStateSoundRightMusic.STATE_PAUSED)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightMusic.STATE_PLAYING)
            {
                if (currentState != EnumStateSoundRightMusic.STATE_PLAY && currentState != EnumStateSoundRightMusic.STATE_RESUME && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE)
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
                if (currentState != EnumStateSoundRightMusic.STATE_PAUSE && currentState != EnumStateSoundRightMusic.STATE_OPTION_UPDATE)
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

             return retValue;
        }

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateSoundRightMusic.STATE_UPDATELIST_ADD)
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
        }

        private void startPlayMusic()
        {
            List<Music> currentMusicList = ((SoundController)this.parentController.parentController).musicPlaylist;
 
            if (currentMusicList.Count > 0)
            {
                if(random)
                {

                }
                else
                {
                    this._currentMusic = currentMusicList[0];
                }

                this._mPlayer.URL = this._currentMusic.path + "\\" + this._currentMusic.name;
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

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if( parentController is SoundController )
            {
                SoundController pController = (SoundController) parentController;

                if(pController.currentState == EnumStateSound.STATE_MUSIC_LIST_CHANGED)
                {
                    this.currentState = EnumStateSoundRightMusic.STATE_UPDATELIST_ADD;
                }
            }
            else
            {
                base.onParentStateChange(parentController);
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
    }
}
