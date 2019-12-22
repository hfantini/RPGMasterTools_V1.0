
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
    |	Name: [ViewCharacter.cs]
    |	Type: [TYPE]
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
using RPGMasterTools.Source.Interface;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombat : UserControl, IComponent<EnumStateCombat>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombat()
        {
            InitializeComponent();
        }

        public ViewCombat(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER

            this._controller = new CombatController(this, parentController);

            // CONFIGURE COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombat lastState, EnumStateCombat currentState)
        {

        }

        // == EVENTS
        // ==============================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombat.STATE_NEW;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
