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
    |	Name: [SoundRightAmbiencePlayerController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description:
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundRightAmbiencePlayerController : ComponentController<EnumStateSoundRightAmbiencePlayer>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private WindowsMediaPlayer _mPlayer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightAmbiencePlayerController(IComponent<EnumStateSoundRightAmbiencePlayer> component, GenericController parentController, Ambience ambience) : base(component, parentController)
        {

            // INITIALIZING COMPONENTS
            this._mPlayer = new WindowsMediaPlayer();

            // CONFIGURING COMPONENTS

            this._mPlayer.URL = ambience.path + "\\" + ambience.name;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateSoundRightAmbiencePlayer currentState, EnumStateSoundRightAmbiencePlayer nextState)
        {
            bool retValue = true;

            if (nextState == EnumStateSoundRightAmbiencePlayer.STATE_PLAY)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_IDLE && currentState != EnumStateSoundRightAmbiencePlayer.STATE_NONE && currentState != EnumStateSoundRightAmbiencePlayer.STATE_PAUSED && currentState != EnumStateSoundRightAmbiencePlayer.STATE_MEDIA_END)
                {
                    retValue = false;
                }
            }
            else if(nextState == EnumStateSoundRightAmbiencePlayer.STATE_PLAYING)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_PLAY)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightAmbiencePlayer.STATE_STOP)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_PLAYING && currentState != EnumStateSoundRightAmbiencePlayer.STATE_PAUSED)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightAmbiencePlayer.STATE_PAUSE)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_PLAYING)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightAmbiencePlayer.STATE_PAUSED)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_PAUSE)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightAmbiencePlayer.STATE_MEDIA_END)
            {
                if (currentState != EnumStateSoundRightAmbiencePlayer.STATE_PLAYING)
                {
                    retValue = false;
                }
            }

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_PLAY)
            {
                this.play();
            }
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_STOP)
            {
                this.stop();
            }
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_PAUSE)
            {
                this.pause();
            }
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_MEDIA_END)
            {
                // SOUND LOOP
                this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PLAY;
            }
        }

        private void play()
        {
            this._mPlayer.controls.play();
            this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PLAYING;
        }

        private void stop()
        {
            this._mPlayer.controls.stop();
            this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_IDLE;
        }

        private void pause()
        {
            this._mPlayer.controls.pause();
            this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PAUSED;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

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
                if (value >= 0 && value <= 100)
                {
                    this._mPlayer.settings.volume = value;
                }
            }
        }
    }
}
