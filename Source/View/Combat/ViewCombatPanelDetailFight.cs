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

        CombatPanelController _parentController;

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
            //this._parentController = parentController;

            // CONFIG COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatPanelDetailFight lastState, EnumStateCombatPanelDetailFight currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
