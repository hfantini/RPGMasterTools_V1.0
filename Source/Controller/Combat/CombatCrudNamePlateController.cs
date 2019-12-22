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
    |	Name: [CombatCrudNamePlateController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.Controller;
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.RPG;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Char
{
    // == CLASS
    // ==============================================================

    public class CombatCrudNamePlateController : ComponentController<EnumStateCombatCrudNameplate>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Character _character;
        private bool _selected;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatCrudNamePlateController(IComponent<EnumStateCombatCrudNameplate> component, GenericController controller, Character character, bool selected) : base(component, controller)
        {
            this._character = character;
            this._selected = selected;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombatCrudNameplate currentState, EnumStateCombatCrudNameplate nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (this.currentState != EnumStateCombatCrudNameplate.STATE_IDLE)
            {
                this.currentState = EnumStateCombatCrudNameplate.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public Character character
        {
            get { return this._character; }
        }

        public bool selected
        {
            get { return this._selected; }
            set { this._selected = value; }
        }
    }
}
