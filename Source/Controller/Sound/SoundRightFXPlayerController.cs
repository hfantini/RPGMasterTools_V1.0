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
using RPGMasterTools.Source.Enumeration.System;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Model.Sys;
using RPGMasterTools.Source.Util;
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
        private int _id = 0;
        private SoundFX _sfx = null;
        private WindowsMediaPlayer _sfxPlayer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightFXPlayerController(int id, IComponent<EnumStateSoundRightFXPlayer> component, GenericController parentController, SoundFX sfx) : base(component, parentController)
        {
            // INITIALIZING VALUES
            this._id = id;
            this._sfx = sfx;
            this._sfxPlayer = new WindowsMediaPlayer();

            // CONFIGURE COMPONENTS
            this._sfxPlayer.settings.autoStart = false;
            this._sfxPlayer.URL = sfx.path + "\\" + sfx.name;
        }

        // == DESTRUCTOR
        // ==============================================================

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
            else if (currentState == EnumStateSoundRightFXPlayer.STATE_REMOVE)
            {
                this._sfxPlayer.controls.stop();
                this._sfxPlayer.close();
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

        public override void Dispose()
        {
            base.Dispose();

            this._sfxPlayer.controls.stop();
            this._sfxPlayer.close();
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is MainController)
            {
                MainController pController = (MainController)parentController;

                if (pController.currentState == EnumStateMain.STATE_GLOBAL_HOTKEY_PRESSED)
                {
                    Hotkey cHotkey = pController.lastPressedHotKey;

                    if (cHotkey.modifier == EnumKeyModifier.MOD_SHIFT)
                    {
                        if (cHotkey.isKeyNumber())
                        {
                            if (this._id == UInput.getNumberFromKey(cHotkey))
                            {
                                if (this.currentState == EnumStateSoundRightFXPlayer.STATE_PLAYING)
                                {
                                    this.currentState = EnumStateSoundRightFXPlayer.STATE_STOP;
                                }
                                else
                                {
                                    this.currentState = EnumStateSoundRightFXPlayer.STATE_PLAY;
                                }
                            }
                        }
                    }
                }
            }
            else if (parentController is SoundRightFXController)
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

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public SoundFX currentSFX
        {
            get { return this._sfx; }
        }
    }
}
