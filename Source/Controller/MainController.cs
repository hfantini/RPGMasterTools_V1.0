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
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.P)); // PLAY/PAUSE MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.S)); // STOP MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.N)); // NEXT MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.B)); // RETURN TO LAST MUSIC TRACK
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.OemMinus)); // MUSIC VOLUME UP
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.Oemplus)); // MUSIC VOLUME DOWN
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.R)); // RANDOM OPTION
            this._systemAvailableHotkeys.Add(new Hotkey(EnumKeyModifier.MOD_CONTROL, Keys.D)); // REPEAT OPTION
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
