
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
    |	Name: [ViewCombatCrudNamePlate]
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
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Controller.Char;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatCrudNamePlate : UserControl, IComponent<EnumStateCombatCrudNameplate>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatCrudNamePlateController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatCrudNamePlate()
        {
            InitializeComponent();
        }

        public ViewCombatCrudNamePlate(GenericController parentController, Model.RPG.Character character, bool selected)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER
            this._controller = new CombatCrudNamePlateController(this, parentController, character, selected);

            // CONFIG COMPONENTS

            this.lblName.Text = character.name;

            if (character is Player)
            {
                this.pBoxIcon.Image = URPG.getClassIcon( ( (Player) character ).pClass);
            }
            else if(character is Enemy)
            {
                this.pBoxIcon.Image = RPGMasterTools.Properties.Resources.ico_class_boss;
            }
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatCrudNameplate lastState, EnumStateCombatCrudNameplate currentState)
        {
            if (currentState == EnumStateCombatCrudNameplate.STATE_UPDATE)
            {
                if(this._controller.selected)
                {
                    this.BackColor = SystemColors.InactiveCaption;
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        private void onClick()
        {
            CombatCrudController controller = (CombatCrudController)this._controller.parentController;

            if (this.Parent.Name == "fLayoutFrom")
            {
                controller.selectedFrom = this._controller.character;
                controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE_SELECTED;
            }
            else if (this.Parent.Name == "fLayoutTo")
            {
                controller.selectedTo = this._controller.character;
                controller.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE_SELECTED;
            }
        }

        private void onDoubleClick()
        {
            CombatCrudController controller = (CombatCrudController)this._controller.parentController;

            if (this.Parent.Name == "fLayoutFrom")
            {
                controller.selectedFrom = this._controller.character;
                controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_ADD_TOLIST;
            }
            else if (this.Parent.Name == "fLayoutTo")
            {
                controller.selectedTo = this._controller.character;
                controller.currentState = EnumStateCombatCrud.STATE_TOLIST_ADD_FROMLIST;
            }
        }

        private void ViewCombatCrudNamePlate_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrudNameplate.STATE_IDLE;
        }

        private void ViewCombatCrudNamePlate_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void pBoxIcon_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void ViewCombatCrudNamePlate_DoubleClick(object sender, EventArgs e)
        {
            onDoubleClick();
        }

        private void pBoxIcon_DoubleClick(object sender, EventArgs e)
        {
            onDoubleClick();
        }

        private void lblName_DoubleClick(object sender, EventArgs e)
        {
            onDoubleClick();
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public Model.RPG.Character character
        {
            get { return this._controller.character; }
        }

        public bool selected
        {
            get { return this._controller.selected; }
            set
            {
                this._controller.selected = value;
                this._controller.currentState = EnumStateCombatCrudNameplate.STATE_UPDATE;
            }
        }
    }
}
