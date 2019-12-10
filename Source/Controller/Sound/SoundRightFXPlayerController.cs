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
    |	Name: [SoundRightFXPlayerController.cs]
    |	Type: [Controller]
    |	Author: Henrique Fantini
    |	
    |	Description: -
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
    public class SoundRightFXPlayerController : ComponentController<EnumStateSoundRightFXPlayer>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private SoundFX _sfx = null;
        private WindowsMediaPlayer _sfxPlayer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightFXPlayerController(IComponent<EnumStateSoundRightFXPlayer> component, GenericController parentController, SoundFX sfx) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._sfx = sfx;
            this._sfxPlayer = new WindowsMediaPlayer();

            // CONFIGURE COMPONENTS
            this._sfxPlayer.settings.autoStart = false;
            this._sfxPlayer.URL = sfx.path + "\\" + sfx.name;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateSoundRightFXPlayer currentState, EnumStateSoundRightFXPlayer nextState)
        {
            bool retValue = true;

            if( nextState == EnumStateSoundRightFXPlayer.STATE_PLAY )
            {
                if(currentState != EnumStateSoundRightFXPlayer.STATE_NONE && currentState != EnumStateSoundRightFXPlayer.STATE_IDLE)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightFXPlayer.STATE_PLAYING)
            {
                if (currentState != EnumStateSoundRightFXPlayer.STATE_PLAY && currentState != EnumStateSoundRightFXPlayer.STATE_VOLUME_CHANGE)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightFXPlayer.STATE_STOP)
            {
                if (currentState != EnumStateSoundRightFXPlayer.STATE_PLAYING && currentState != EnumStateSoundRightFXPlayer.STATE_MEDIA_END)
                {
                    retValue = false;
                }
            }
            else if (nextState == EnumStateSoundRightFXPlayer.STATE_MEDIA_END)
            {
                if (currentState != EnumStateSoundRightFXPlayer.STATE_PLAYING)
                {
                    retValue = false;
                }
            }

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateSoundRightFXPlayer.STATE_PLAY)
            {
                play();
            }
            else if (this.currentState == EnumStateSoundRightFXPlayer.STATE_STOP)
            {
                stop();
            }
            else if(this.currentState == EnumStateSoundRightFXPlayer.STATE_MEDIA_END)
            {
                this.currentState = EnumStateSoundRightFXPlayer.STATE_STOP;
            }
            else if (this.currentState == EnumStateSoundRightFXPlayer.STATE_VOLUME_CHANGE)
            {
                updateVolume();
                this.currentState = this.lastState;
            }
        }

        private void play()
        {
            this._sfxPlayer.controls.play();
            this.currentState = EnumStateSoundRightFXPlayer.STATE_PLAYING;
        }

        private void stop()
        {
            this._sfxPlayer.controls.stop();
            this.currentState = EnumStateSoundRightFXPlayer.STATE_IDLE;
        }

        private void updateVolume()
        {
            int trackVolume = this._sfx.volume;
            int masterVolume = ( (SoundRightFXController) this.parentController).masterVolumeFX;
            int finalVolume = 100;

            if (trackVolume > masterVolume)
            {
                finalVolume = masterVolume;
            }
            else
            {
                finalVolume = trackVolume;
            }

            this._sfxPlayer.settings.volume = finalVolume;
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is SoundRightFXController)
            {
                SoundRightFXController controller = (SoundRightFXController) parentController;
                
                if(controller.currentState == EnumStateSoundRightFX.STATE_MASTER_VOLUME_CHANGED)
                {
                    this.currentState = EnumStateSoundRightFXPlayer.STATE_VOLUME_CHANGE;
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public WMPPlayState wmpIsPlaying
        {
            get { return this._sfxPlayer.playState; }
        }

        public int volume
        {
            get { return this._sfx.volume; }
            set
            {
                this._sfx.volume = value;
                this.currentState = EnumStateSoundRightFXPlayer.STATE_VOLUME_CHANGE;
            }
        }
    }
}
