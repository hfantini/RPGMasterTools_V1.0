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
    |	Name: [ViewCombatPanelDetailFight.cs]
    |	Type: [VIEW]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Util;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanelDetailFight : UserControl, IComponent<EnumStateCombatPanelDetailFight>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatPanelDatailFightController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanelDetailFight()
        {
            InitializeComponent();
        }

        public ViewCombatPanelDetailFight(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER
            this._controller = new CombatPanelDatailFightController(this, parentController);

            // CONFIG COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatPanelDetailFight lastState, EnumStateCombatPanelDetailFight currentState)
        {
            if (currentState == EnumStateCombatPanelDetailFight.STATE_UPDATE)
            {
                Model.RPG.Combat combat = ((CombatPanelController)this._controller.parentController).combat;
                Model.RPG.CombatCharacter cCharacter = combat.getCurrentPlay();

                lblPlay.Text = combat.currentPlay.ToString();
                lblTurn.Text = combat.currentTurn.ToString();
                lblName.Text = cCharacter.character.name;

                if(cCharacter.character is Player)
                {
                    pBoxIcon.Image = URPG.getClassIcon( ( (Player) cCharacter.character ).pClass );
                }
                else if (cCharacter.character is Enemy)
                {
                    pBoxIcon.Image = RPGMasterTools.Properties.Resources.ico_class_boss;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            CombatPanelController controller = (CombatPanelController)this._controller.parentController;
            controller.currentState = EnumStateCombatPanel.STATE_NEXT_PLAY;
        }

        private void ViewCombatPanelDetailFight_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatPanelDetailFight.STATE_UPDATE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
