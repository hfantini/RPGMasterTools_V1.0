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
    |	Name: [ViewCombatPanelDetailPreparation.cs]
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

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanelDetailPreparation : UserControl, IComponent<EnumStateCombatPanelDetailPreparation>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        CombatPanelController _parentController;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanelDetailPreparation()
        {
            InitializeComponent();
        }

        public ViewCombatPanelDetailPreparation(CombatPanelController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER
            this._parentController = parentController;

            // CONFIG COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatPanelDetailPreparation lastState, EnumStateCombatPanelDetailPreparation currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        private void btnInitiativeRandomAll_Click(object sender, EventArgs e)
        {
            this._parentController.currentState = EnumStateCombatPanel.STATE_RANDOM_ALL;
        }

        private void btnInitiativeRandomPlayers_Click(object sender, EventArgs e)
        {
            this._parentController.currentState = EnumStateCombatPanel.STATE_RANDOM_PLAYER;
        }

        private void btnInitiativeRandomEnemies_Click(object sender, EventArgs e)
        {
            this._parentController.currentState = EnumStateCombatPanel.STATE_RANDOM_ENEMY;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this._parentController.currentState = EnumStateCombatPanel.STATE_START_BATTLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
