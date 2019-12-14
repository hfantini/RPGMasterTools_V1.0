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
    |	Name: [MainController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Controller of main form.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Enumeration.System;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller
{
    // == CLASS
    // ==============================================================

    public class MainController : ViewController<EnumStateMain>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private List<Hotkey> _systemAvailableHotkeys;
        private Hotkey _lastPressedHotKey;
        private int _activeTab = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public MainController(IView<EnumStateMain> view) : base (view)
        {
            // INIT VALUES
            this._systemAvailableHotkeys = new List<Hotkey>();

            // == DEFINING GLOBAL HOTKEYS

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_NONE, Keys.F1)); // TAB CHANGE
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_NONE, Keys.F2)); // TAB CHANGE

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.P)); // PLAY/PAUSE MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.S)); // STOP MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.N)); // NEXT MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.B)); // RETURN TO LAST MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.OemMinus)); // MUSIC VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.Oemplus)); // MUSIC VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.R)); // RANDOM OPTION
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D)); // REPEAT OPTION

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.P)); // PLAY ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.O)); // PAUSE ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.S)); // STOP ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.OemMinus)); // AMBIENCE TRACK VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.Oemplus)); // AMBIENCE TRACK VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.F)); // AMBIENCE TRACK SEARCH FOCUS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D9));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.NumPad9));

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.OemMinus)); // SFX VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.Oemplus)); // SFX VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.F)); // SEARCH
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D9));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.NumPad9));

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if (currentState != EnumStateMain.STATE_IDLE)
            {
                this.currentState = EnumStateMain.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is MainController)
            {
                MainController controller = (MainController)parentController;

                if (controller.currentState == EnumStateMain.STATE_GLOBAL_HOTKEY_PRESSED)
                {
                    if (controller.lastPressedHotKey.modifier == Enumeration.System.EnumKeyModifier.MOD_NONE)
                    {
                        Keys key = controller.lastPressedHotKey.key;

                        switch (key)
                        {
                            case Keys.F1:

                                this._activeTab = 0;
                                this.currentState = EnumStateMain.STATE_TAB_CHANGE;

                                break;

                            case Keys.F2:

                                this._activeTab = 1;
                                this.currentState = EnumStateMain.STATE_TAB_CHANGE;

                                break;
                        }
                    }
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public List<Hotkey> systemAvailableHotkeys
        {
            get { return new List<Hotkey>(this._systemAvailableHotkeys); }
        }

        public Hotkey lastPressedHotKey
        {
            get { return this._lastPressedHotKey; }
            set { this._lastPressedHotKey = value; }
        }

        public int activeTab
        {
            get { return this._activeTab; }
            set { this._activeTab = value; }
        }
    }
}
