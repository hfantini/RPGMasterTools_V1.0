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
    |	Name: [CombatPanelDatailFightController.cs]
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

    public class CombatPanelDatailFightController : ComponentController<EnumStateCombatPanelDetailFight>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private Combat _combat = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatPanelDatailFightController(IComponent<EnumStateCombatPanelDetailFight> component, GenericController controller) : base(component, controller)
        {
            this._combat = combat;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombatPanelDetailFight currentState, EnumStateCombatPanelDetailFight nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (this.currentState != EnumStateCombatPanelDetailFight.STATE_IDLE)
            {
                this.currentState = EnumStateCombatPanelDetailFight.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is CombatPanelController)
            {
                CombatPanelController controller = (CombatPanelController) parentController;
                
                if(controller.currentState == EnumStateCombatPanel.STATE_UPDATE)
                {
                    this.currentState = EnumStateCombatPanelDetailFight.STATE_UPDATE;
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

        public Model.RPG.Combat combat
        {
            get { return this._combat; }
        }
    }
}
