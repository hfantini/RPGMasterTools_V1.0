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
    |	Name: [ViewCombatNamePlate.cs]
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

    public partial class ViewCombatNamePlate : UserControl, IComponent<EnumStateCombatNameplate>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatNamePlateController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatNamePlate()
        {
            InitializeComponent();
        }

        public ViewCombatNamePlate(GenericController parentController, Model.RPG.Combat combat, bool selected)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER

            this._controller = new CombatNamePlateController(this, parentController, combat, selected);

            // CONFIG COMPONENTS
            this.lblName.Text = combat.name;
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatNameplate lastState, EnumStateCombatNameplate currentState)
        {
            if(currentState == EnumStateCombatNameplate.STATE_UPDATE)
            {
                if(this._controller.selected)
                {
                    this.BackColor = SystemColors.InactiveCaption;
                }
                else
                {
                    this.BackColor = SystemColors.ScrollBar;
                }
            }
        }

        public void select()
        {
            CombatController controller = (CombatController)this._controller.parentController;
            controller.selectedCombat = this._controller.combat;
        }

        // == EVENTS
        // ==============================================================

        private void onClick()
        {
            select();
        }

        private void ViewCombatNamePlate_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void pBoxIcon_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            onClick();
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public bool selected
        {
            get { return this._controller.selected; }
            set
            {
                this._controller.selected = value;
                this._controller.currentState = EnumStateCombatNameplate.STATE_UPDATE;
            }
        }

        public Model.RPG.Combat combat
        {
            get { return this._controller.combat; }
        }
    }
}
