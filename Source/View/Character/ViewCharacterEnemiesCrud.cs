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
    |	Name: [ViewCharHeroesCrud.cs]
    |	Type: [View]
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
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Model.RPG.DND5E;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacterEnemiesCrud : UserControl, IComponent<EnumStateCharEnemiesCrud>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharEnemiesCrudController _controller;
        private Dictionary<String, String> _comboSource;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterEnemiesCrud()
        {
            InitializeComponent();
        }

        public ViewCharacterEnemiesCrud(String title, GenericController parentController, Enemy enemy)
        {
            InitializeComponent();

            // INITIALIZE VALUES

            // INITIALIZE CONTROLLER
            this._controller = new CharEnemiesCrudController(this, parentController, enemy);

            // CONFIG COMPONENTS
            lblTitle.Text = ULanguage.getStringCurrentLanguage(title);
            this.btnCancel.Text = ULanguage.getStringCurrentLanguage(this.btnCancel.Text);
            this.btnOk.Text = ULanguage.getStringCurrentLanguage(this.btnOk.Text);
            grpName.Text = ULanguage.getStringCurrentLanguage(this.grpName.Text);

            if(enemy != null)
            {
                this.txtName.Text = enemy.name;
            }
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharEnemiesCrud lastState, EnumStateCharEnemiesCrud currentState)
        {
            if (currentState == EnumStateCharEnemiesCrud.STATE_VALIDATE)
            {
                if ( validate() )
                {
                    this._controller.currentState = EnumStateCharEnemiesCrud.STATE_OK;
                }
                else
                {
                    MessageBox.Show("VALIDATION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this._controller.currentState = EnumStateCharEnemiesCrud.STATE_IDLE;
                }
            }
            else if (currentState == EnumStateCharEnemiesCrud.STATE_OK)
            {
                this._controller.enemy.name = txtName.Text;

                close();
            }
            else if( currentState == EnumStateCharEnemiesCrud.STATE_CANCEL)
            {
                close();
            }
        }

        protected bool validate()
        {
            bool retValue = true;

            // NAME

            if (txtName.Text == null || txtName.Text == "")
            {
                retValue = false;
            }

            return retValue;
        }

        private void close()
        {
            if (this.Parent != null)
            {
                ((Form)this.Parent).Close();
            }
        }

        // == EVENTS
        // ==============================================================

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemiesCrud.STATE_VALIDATE;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemiesCrud.STATE_CANCEL;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewCharacterHeroesCrud_Load(object sender, EventArgs e)
        {
            Form pForm = (Form) this.Parent;
            pForm.AcceptButton = this.btnOk;
            pForm.CancelButton = this.btnCancel;

            this._controller.currentState = EnumStateCharEnemiesCrud.STATE_IDLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public EnumStateCharEnemiesCrud currentState
        {
            get { return this._controller.currentState;  }
        }

        public Enemy currentModel
        {
            get { return this._controller.enemy; }
        }
    }
}
