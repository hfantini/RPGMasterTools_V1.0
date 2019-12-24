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
using RPGMasterTools.Source.View;
using RPGMasterTools.Source.View.Combat;
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
            if(this.currentState == EnumStateCombatPanelCharacter.STATE_APPLY_DAMAGE)
            {
                ViewCombatPanelDialogDamage vDamage = new ViewCombatPanelDialogDamage();
                ViewDialog dialog = new ViewDialog("DAMAGE", vDamage);

                dialog.ShowDialog();

                if(vDamage.value > 0)
                {
                    this._cCharacter.character.damage(vDamage.value);
                    this.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
                }
            }
            else if (this.currentState == EnumStateCombatPanelCharacter.STATE_APPLY_HEAL)
            {
                ViewCombatPanelDialogHeal vHeal = new ViewCombatPanelDialogHeal();
                ViewDialog dialog = new ViewDialog("DAMAGE", vHeal);

                dialog.ShowDialog();

                if (vHeal.value > 0)
                {
                    this._cCharacter.character.heal(vHeal.value);
                    this.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
                }
            }
            else if (this.currentState == EnumStateCombatPanelCharacter.STATE_APPLY_DEATH)
            {
                bool confirm = USystemMessage.createQuestionDialog("Question?", "Are you sure you want to kill this character?");

                if(confirm)
                {
                    this._cCharacter.character.currentState = Enumeration.RPG.DND5E.EnumCharacterState.STATE_DEAD;
                    this.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
                }
            }
            else if (this.currentState == EnumStateCombatPanelCharacter.STATE_APPLY_RESS)
            {
                bool confirm = USystemMessage.createQuestionDialog("Question?", "Are you sure you want to ress this character?");

                if (confirm)
                {
                    this._cCharacter.character.heal(1); 
                    this.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
                }
            }

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
                else if (controller.currentState == EnumStateCombatPanel.STATE_UPDATE)
                {
                    this.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
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
