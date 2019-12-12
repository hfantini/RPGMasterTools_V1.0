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

        // == CONSTRUCTOR(S)
        // ==============================================================

        public MainController(IView<EnumStateMain> view) : base (view)
        {
            // INIT VALUES
            this._systemAvailableHotkeys = new List<Hotkey>();

            // == DEFINING GLOBAL HOTKEYS

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.P)); // PLAY/PAUSE MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.S)); // STOP MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.N)); // NEXT MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.B)); // RETURN TO LAST MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.OemMinus)); // MUSIC VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.Oemplus)); // MUSIC VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.R)); // RANDOM OPTION
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_SHIFT, Keys.D)); // REPEAT OPTION

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.P)); // PLAY ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.O)); // PAUSE ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.S)); // STOP ALL AMBIENCE TRACKS
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.OemMinus)); // AMBIENCE TRACK VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.Oemplus)); // AMBIENCE TRACK VOLUME DOWN
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

            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.OemMinus)); // SFX VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.Oemplus)); // SFX VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.D9));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad1));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad2));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad3));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad4));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad5));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad6));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad7));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad8));
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_ALT, Keys.NumPad9));

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
    }
}
