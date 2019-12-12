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
    |	Name: [SoundRightFXController.cs]
    |	Type: [CONTROLLER]
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundRightFXController : ComponentController<EnumStateSoundRightFX>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolumeFX = 100;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightFXController(IComponent<EnumStateSoundRightFX> view, GenericController parentController) : base(view, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateSoundRightFX.STATE_PRESET_LOADED)
            {
                PresetSoundFX preset = ((SoundController)this.parentController.parentController).currentPreset.sfxPreset;
                this._masterVolumeFX = preset.masterVolume;

                this.currentState = EnumStateSoundRightFX.STATE_MASTER_VOLUME_CHANGED;
            }

            this.currentState = EnumStateSoundRightFX.STATE_IDLE;
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

                    if (cHotkey.modifier == EnumKeyModifier.MOD_ALT)
                    {
                        switch (cHotkey.key)
                        {
                            case Keys.Oemplus:

                                this.masterVolumeFX += 10;

                                break;

                            case Keys.OemMinus:

                                this.masterVolumeFX -= 10;

                                break;

                            default:

                                base.onParentStateChange(parentController);

                                break;
                        }
                    }
                }
            }
            else if (parentController is SoundController)
            {
                SoundController controller = (SoundController) parentController;

                if( controller.currentState == EnumStateSound.STATE_SFX_LIST_ADDED )
                {
                    this.currentState = EnumStateSoundRightFX.STATE_UPDATE_LIST_ADD;
                }
                else if ( controller.currentState == EnumStateSound.STATE_SFX_LIST_REMOVED )
                {
                    this.currentState = EnumStateSoundRightFX.STATE_UPDATE_LIST_REMOVE;
                }
                else if (controller.currentState == EnumStateSound.STATE_PRESET_LOADED)
                {
                    this.currentState = EnumStateSoundRightFX.STATE_PRESET_LOADED;
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

        public int masterVolumeFX
        {
            get { return this._masterVolumeFX; }
            set
            {
                if(value < 0)
                {
                    this._masterVolumeFX = 0;
                }
                else if(value > 100)
                {
                    this._masterVolumeFX = 100;
                }
                else
                {
                    this._masterVolumeFX = value;
                }

                this.currentState = EnumStateSoundRightFX.STATE_MASTER_VOLUME_CHANGED;
            }
        }
    }
}
