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
    |	Name: [CombatNamePlateController.cs]
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

    public class CombatNamePlateController : ComponentController<EnumStateCombatNameplate>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Model.RPG.Combat _combat = null;
        private bool _selected = false;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatNamePlateController(IComponent<EnumStateCombatNameplate> component, GenericController controller, Model.RPG.Combat combat, bool selected) : base(component, controller)
        {
            this._combat = combat;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombatNameplate currentState, EnumStateCombatNameplate nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (this.currentState != EnumStateCombatNameplate.STATE_IDLE)
            {
                this.currentState = EnumStateCombatNameplate.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public Model.RPG.Combat combat
        {
            get { return this._combat; }
        }

        public bool selected
        {
            get { return this._selected; }
            set { this._selected = value; }
        }
    }
}
