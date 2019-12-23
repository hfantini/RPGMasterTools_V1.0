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
    |	Name: [CombatPanelCharacterController.cs]
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

    public class CombatPanelCharacterController : ComponentController<EnumStateCombatPanelCharacter>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private CombatCharacter _cCharacter = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatPanelCharacterController(IComponent<EnumStateCombatPanelCharacter> component, GenericController controller, CombatCharacter cCharacter) : base(component, controller)
        {
            this._cCharacter = cCharacter;
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombatPanelCharacter currentState, EnumStateCombatPanelCharacter nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (this.currentState != EnumStateCombatPanelCharacter.STATE_IDLE)
            {
                this.currentState = EnumStateCombatPanelCharacter.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is CombatPanelController)
            {
                CombatPanelController controller = (CombatPanelController)parentController;

                if(controller.currentState == EnumStateCombatPanel.STATE_RANDOM_ALL)
                {
                    this.currentState = EnumStateCombatPanelCharacter.STATE_ROLL_RANDOM_INITIATIVE;
                }
                else if (controller.currentState == EnumStateCombatPanel.STATE_RANDOM_PLAYER)
                {
                    if(this._cCharacter.character is Player)
                    {
                        this.currentState = EnumStateCombatPanelCharacter.STATE_ROLL_RANDOM_INITIATIVE;
                    }
                }
                else if (controller.currentState == EnumStateCombatPanel.STATE_RANDOM_ENEMY)
                {
                    if (this._cCharacter.character is Enemy)
                    {
                        this.currentState = EnumStateCombatPanelCharacter.STATE_ROLL_RANDOM_INITIATIVE;
                    }
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

        public Model.RPG.CombatCharacter combatCharacter
        {
            get { return this._cCharacter; }
        }
    }
}
