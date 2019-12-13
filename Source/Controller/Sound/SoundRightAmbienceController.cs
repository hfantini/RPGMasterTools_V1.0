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
    |	Name: [SoundRightAmbienceController]
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

    public class SoundRightAmbienceController : ComponentController<EnumStateSoundRightAmbience>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private string _searchString = "";
        private int _masterVolume = 100;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightAmbienceController(IComponent<EnumStateSoundRightAmbience> component, GenericController parentController) : base(component, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateSoundRightAmbience.STATE_PRESET_LOADED)
            {
                PresetAmbience preset = ( (SoundController) this.parentController.parentController).currentPreset.ambiencePreset;
                this.masterVolume = preset.masterVolume;
                this.currentState = EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE;
            }

            this.currentState = EnumStateSoundRightAmbience.STATE_IDLE;
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

                    if (cHotkey.modifier == EnumKeyModifier.MOD_CONTROL)
                    {
                        switch (cHotkey.key)
                        {
                            case Keys.P:

                                this.currentState = EnumStateSoundRightAmbience.STATE_PLAY;

                                break;

                            case Keys.O:

                                this.currentState = EnumStateSoundRightAmbience.STATE_PAUSE;

                                break;

                            case Keys.S:

                                this.currentState = EnumStateSoundRightAmbience.STATE_STOP;

                                break;

                            case Keys.Oemplus:

                                this.masterVolume += 10;
                                this.currentState = EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE;

                                break;

                            case Keys.OemMinus:

                                this.masterVolume -= 10;
                                this.currentState = EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE;

                                break;

                            case Keys.F:

                                this.currentState = EnumStateSoundRightAmbience.STATE_SEARCH_FOCUS;

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
                SoundController controller = (SoundController)parentController;

                if (controller.currentState == EnumStateSound.STATE_AMBIENCE_LIST_ADDED)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_UPDATE_LIST_ADD;
                }
                else if (controller.currentState == EnumStateSound.STATE_AMBIENCE_LIST_REMOVED)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_UPDATE_LIST_REMOVE;
                }
                else if (controller.currentState == EnumStateSound.STATE_AMBIENCE_LIST_CLEAR)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_UPDATE_LIST_CLEAR;
                }
                else if (controller.currentState == EnumStateSound.STATE_PRESET_LOADED)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_PRESET_LOADED;
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

        public int masterVolume
        {
            get { return this._masterVolume; }
            set
            {
                if (value < 0)
                {
                    this._masterVolume = 0;
                }
                else if (value > 100)
                {
                    this._masterVolume = 100;
                }
                else
                {
                    this._masterVolume = value;
                }
            }
        }

        public string searchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }
    }
}
