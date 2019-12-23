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
    |	Name: [ViewCombatPanelEmpty.cs]
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Enumeration.State;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanelEmpty : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanelEmpty()
        {
            InitializeComponent();
        }

        public ViewCombatPanelEmpty(CombatController parentController)
        {
            InitializeComponent();

            this._controller = parentController;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombat.STATE_NEW;
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
