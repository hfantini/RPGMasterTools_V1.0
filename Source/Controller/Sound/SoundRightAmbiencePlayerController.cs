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
        private int _finalVolume = 100;
        private Ambience _currentAmbience = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightAmbiencePlayerController(IComponent<EnumStateSoundRightAmbiencePlayer> component, GenericController parentController, Ambience ambience) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._currentAmbience = ambience;
            this._mPlayer = new WindowsMediaPlayer();

            // CONFIGURING COMPONENTS

            this._mPlayer.URL = ambience.path + "\\" + ambience.name;

            // VOLUME
            updateVolume();
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
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_REMOVE)
            {
                this._mPlayer.controls.stop();
                this._mPlayer.close();
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

        private void updateVolume()
        {
            int masterVolume = ( (SoundRightAmbienceController) this.parentController).masterVolume;

            if (this.currentAmbience.volume > masterVolume)
            {
                this._finalVolume = masterVolume;
            }
            else
            {
                this._finalVolume = this.currentAmbience.volume;
            }

            this._mPlayer.settings.volume = this._finalVolume;
        }

        public override void Dispose()
        {
            base.Dispose();

            this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_STOP;
            this._mPlayer.close();
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is SoundRightAmbienceController)
            {
                SoundRightAmbienceController controller = (SoundRightAmbienceController) parentController;

                if (controller.currentState == EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE)
                {
                    this.updateVolume();
                }
                else if (controller.currentState == EnumStateSoundRightAmbience.STATE_PLAY)
                {
                    this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PLAY;
                }
                else if (controller.currentState == EnumStateSoundRightAmbience.STATE_STOP)
                {
                    this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_STOP;
                }
                else if (controller.currentState == EnumStateSoundRightAmbience.STATE_PAUSE)
                {
                    this.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PAUSE;
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
            get { return this.currentAmbience.volume; }
            set
            {
                this.currentAmbience.volume = value;
                this.updateVolume();
            }
        }

        public Ambience currentAmbience
        {
            get { return this._currentAmbience; }
        }
    }
}
