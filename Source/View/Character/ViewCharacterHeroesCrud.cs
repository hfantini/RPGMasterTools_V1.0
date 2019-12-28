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
using RPGMasterTools.Properties;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacterHeroesCrud : UserControl, IComponent<EnumStateCharHeroesCrud>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharHeroesCrudController _controller;
        private Dictionary<String, String> _comboSource;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterHeroesCrud()
        {
            InitializeComponent();
        }

        public ViewCharacterHeroesCrud(String title, GenericController parentController, Player player)
        {
            InitializeComponent();

            // INITIALIZE VALUES

            // INITIALIZE CONTROLLER
            this._controller = new CharHeroesCrudController(this, parentController, player);

            // CONFIG COMPONENTS
            lblTitle.Text = ULanguage.getStringCurrentLanguage(title);
            this.btnCancel.Text = ULanguage.getStringCurrentLanguage(this.btnCancel.Text);
            this.btnOk.Text = ULanguage.getStringCurrentLanguage(this.btnOk.Text);
            grpClass.Text = ULanguage.getStringCurrentLanguage(this.grpClass.Text);
            grpName.Text = ULanguage.getStringCurrentLanguage(this.grpName.Text);

            // COMBO CLASS
            this._comboSource = new Dictionary<String, String>();

            this._comboSource.Add("- SELECT", "NONE");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.BARBARIAN"), "Barbarian");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.BARD"), "Bard");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.CLERIC"), "Cleric");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.DRUID"), "Druid");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.FIGHTER"), "Fighter");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.MONK"), "Monk");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.PALADIN"), "Paladin");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.ROGUE"), "Rogue");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.SORCERER"), "Sorcerer");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.WARLOCK"), "Warlock");
            this._comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.WIZARD"), "Wizard");

            cmbClass.DataSource = new BindingSource(_comboSource, null);
            cmbClass.DisplayMember = "Key";
            cmbClass.ValueMember = "Value";

            if(player != null)
            {
                this.txtName.Text = player.name;
                int value = this._comboSource.Values.ToList().IndexOf(player.pClass.GetType().Name);

                if(value >= 0)
                {
                    cmbClass.SelectedIndex = value;
                }
            }
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharHeroesCrud lastState, EnumStateCharHeroesCrud currentState)
        {
            if(currentState == EnumStateCharHeroesCrud.STATE_CLASS_CHANGED)
            {
                String value = ((KeyValuePair<string, string>)cmbClass.SelectedItem).Value;
                Type type = Type.GetType("RPGMasterTools.Source.Model.RPG.DND5E." + value);

                if (type != null)
                {
                    PClass currentClass = (PClass)Activator.CreateInstance(type);

                    // UPDATE PICTURE BOX
                    pBoxClass.Image = URPG.getClassIcon(currentClass);
                }
            }
            else if (currentState == EnumStateCharHeroesCrud.STATE_VALIDATE)
            {
                if ( validate() )
                {
                    this._controller.currentState = EnumStateCharHeroesCrud.STATE_OK;
                }
                else
                {
                    MessageBox.Show("VALIDATION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this._controller.currentState = EnumStateCharHeroesCrud.STATE_IDLE;
                }
            }
            else if (currentState == EnumStateCharHeroesCrud.STATE_OK)
            {
                String value = ((KeyValuePair<string, string>)cmbClass.SelectedItem).Value;
                Type type = Type.GetType("RPGMasterTools.Source.Model.RPG.DND5E." + value);

                if (type != null)
                {
                    PClass currentClass = (PClass)Activator.CreateInstance(type);
                    this._controller.player.name = txtName.Text;
                    this._controller.player.pClass = currentClass;
                }

                close();
            }
            else if( currentState == EnumStateCharHeroesCrud.STATE_CANCEL)
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

            // CLASS

            if (cmbClass.SelectedIndex == 0)
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
            this._controller.currentState = EnumStateCharHeroesCrud.STATE_VALIDATE;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroesCrud.STATE_CANCEL;
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroesCrud.STATE_CLASS_CHANGED;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewCharacterHeroesCrud_Load(object sender, EventArgs e)
        {
            Form pForm = (Form)this.Parent;
            pForm.AcceptButton = this.btnOk;
            pForm.CancelButton = this.btnCancel;

            this._controller.currentState = EnumStateCharHeroesCrud.STATE_IDLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public EnumStateCharHeroesCrud currentState
        {
            get { return this._controller.currentState;  }
        }

        public Player currentModel
        {
            get { return this._controller.player; }
        }
    }
}
