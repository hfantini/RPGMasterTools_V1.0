
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
    |	Name: [ViewCombatCrud]
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
using RPGMasterTools.Source.Util;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatCrud : UserControl, IComponent<EnumStateCombatCrud>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatCrudController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatCrud()
        {
            InitializeComponent();
        }

        public ViewCombatCrud(String title, GenericController parentController, Model.RPG.Combat combat )
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER

            this._controller = new CombatCrudController(this, parentController);

            // CONFIG COMPONENTS

            this.lblTitle.Text = ULanguage.getStringCurrentLanguage(title);
            this.grpName.Text = ULanguage.getStringCurrentLanguage(this.grpName.Text);
            this.grpActors.Text = ULanguage.getStringCurrentLanguage(this.grpActors.Text);
            this.radioShowAll.Text = ULanguage.getStringCurrentLanguage(this.radioShowAll.Text);
            this.radioShowPlayers.Text = ULanguage.getStringCurrentLanguage(this.radioShowPlayers.Text);
            this.radioShowEnemies.Text = ULanguage.getStringCurrentLanguage(this.radioShowEnemies.Text);
            this.btnCancel.Text = ULanguage.getStringCurrentLanguage(this.btnCancel.Text);
            this.btnOk.Text = ULanguage.getStringCurrentLanguage(this.btnOk.Text);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatCrud lastState, EnumStateCombatCrud currentState)
        {
            if(currentState == EnumStateCombatCrud.STATE_FROMLIST_UPDATE)
            {
                updateFromList();
            }
            else if (currentState == EnumStateCombatCrud.STATE_FROMLIST_UPDATE_SELECTED)
            {
                updateFromListSelected();
            }
            else if (currentState == EnumStateCombatCrud.STATE_TOLIST_UPDATE)
            {
                updateToList();
            }
            else if (currentState == EnumStateCombatCrud.STATE_TOLIST_UPDATE_SELECTED)
            {
                updateToListSelected();
            }
            else if (currentState == EnumStateCombatCrud.STATE_VALIDATION)
            {
                if( validate() )
                {
                    this._controller.currentState = EnumStateCombatCrud.STATE_OK;
                }
                else
                {
                    MessageBox.Show("VALIDATION PROBLEMS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (currentState == EnumStateCombatCrud.STATE_OK)
            {
                createCurrentModel();
                close();
            }
            else if(currentState == EnumStateCombatCrud.STATE_CANCEL)
            {
                close();
            }
        }

        private void createCurrentModel()
        {
            Model.RPG.Combat combat = new Model.RPG.Combat();
            
            //DEEP CLONE FROM LIST
            foreach( Model.RPG.Character character in this._controller.toList )
            {
                // NAME
                combat.name = lblTitle.Text;

                // LIST
                Model.RPG.Character copyCharacter = UObject.deepCopyObject(character);
                combat.addCharacterToList(copyCharacter);
                
            }

            this._controller.currentModel = combat;
        }

        private bool validate()
        {
            bool retValue = true;

            // TITLE

            if(this.txtName.Text != null && this.txtName.Text == "")
            {
                retValue = false;
            }

            // ACTORS

            if(this._controller.toList.Count <= 1)
            {
                retValue = false;
            }

            return retValue;
        }

        private void updateFromList()
        {
            this._controller.selectedFrom = null;
            UComponent.removeAllChildren(this.fLayoutFrom);

            foreach( Model.RPG.Character character in this._controller.fromList )
            {
                ViewCombatCrudNamePlate cNamePlate = new ViewCombatCrudNamePlate(this._controller, character, false);
                cNamePlate.Size = new Size(fLayoutFrom.Size.Width, cNamePlate.Size.Height);
                fLayoutFrom.Controls.Add(cNamePlate);
            }
        }

        private void updateToList()
        {
            this._controller.selectedFrom = null;
            UComponent.removeAllChildren(this.fLayoutTo);

            foreach (Model.RPG.Character character in this._controller.toList)
            {
                ViewCombatCrudNamePlate cNamePlate = new ViewCombatCrudNamePlate(this._controller, character, false);
                cNamePlate.Size = new Size(fLayoutTo.Size.Width, cNamePlate.Size.Height);
                fLayoutTo.Controls.Add(cNamePlate);
            }
        }

        private void updateFromListSelected()
        {
            if (this._controller.selectedFrom != null)
            {
                foreach (ViewCombatCrudNamePlate cNamePlate in this.fLayoutFrom.Controls)
                {
                    if(cNamePlate.character == this._controller.selectedFrom)
                    {
                        cNamePlate.selected = true;
                    }
                    else
                    {
                        cNamePlate.selected = false;
                    }
                }
            }
        }

        private void updateToListSelected()
        {
            if (this._controller.selectedTo != null)
            {
                foreach (ViewCombatCrudNamePlate cNamePlate in this.fLayoutTo.Controls)
                {
                    if (cNamePlate.character == this._controller.selectedTo)
                    {
                        cNamePlate.selected = true;
                    }
                    else
                    {
                        cNamePlate.selected = false;
                    }
                }
            }
        }

        private void close()
        {
            ( (Form) this.Parent ).Close();
        }

        // == EVENTS
        // ==============================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_CANCEL;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_VALIDATION;
        }

        private void ViewCombatCrud_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
            this._controller.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE;
        }

        private void fLayoutFrom_ControlAdded(object sender, ControlEventArgs e)
        {
            if (fLayoutFrom.Controls.Count % 10 == 0)
            {
                fLayoutFrom.SetFlowBreak(e.Control as Control, true);
            }
        }

        private void fLayoutTo_ControlAdded(object sender, ControlEventArgs e)
        {
            if (fLayoutTo.Controls.Count % 10 == 0)
            {
                fLayoutTo.SetFlowBreak(e.Control as Control, true);
            }
        }

        private void radioShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(radioShowAll.Checked)
            {
                this._controller.fromListFilter = Enumeration.Controller.EnumControllerCombatFilter.SHOW_ALL;
                this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
            }
        }

        private void radioShowPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowPlayers.Checked)
            {
                this._controller.fromListFilter = Enumeration.Controller.EnumControllerCombatFilter.SHOW_PLAYERS_ONLY;
                this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
            }
        }

        private void radioShowEnemies_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowEnemies.Checked)
            {
                this._controller.fromListFilter = Enumeration.Controller.EnumControllerCombatFilter.SHOW_ENEMIES_ONLY;
                this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
            }
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_ADD_TOLIST;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_FROMLIST_ADDALL_TOLIST;
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_TOLIST_ADD_FROMLIST;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatCrud.STATE_TOLIST_ADDALL_FROMLIST;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public Model.RPG.Combat currentModel
        {
            get { return this._controller.currentModel; }
        }

        public EnumStateCombatCrud currentState
        {
            get { return this._controller.currentState; }
        }
    }
}
