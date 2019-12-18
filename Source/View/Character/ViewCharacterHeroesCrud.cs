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

    public partial class ViewCharacterHeroesCrud : UserControl, IComponent<EnumStateCharHeroesCrud>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharHeroesCrudController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterHeroesCrud()
        {
            InitializeComponent();
        }

        public ViewCharacterHeroesCrud(String title, GenericController parentController)
        {
            InitializeComponent();

            // INITIALIZE VALUES

            // INITIALIZE CONTROLLER
            this._controller = new CharHeroesCrudController(this, parentController);

            // CONFIG COMPONENTS
            lblTitle.Text = ULanguage.getStringCurrentLanguage(title);
            this.btnCancel.Text = ULanguage.getStringCurrentLanguage(this.btnCancel.Text);
            this.btnOk.Text = ULanguage.getStringCurrentLanguage(this.btnOk.Text);
            grpClass.Text = ULanguage.getStringCurrentLanguage(this.grpClass.Text);
            grpName.Text = ULanguage.getStringCurrentLanguage(this.grpName.Text);

            // COMBO CLASS
            Dictionary<String, String> _comboSource = new Dictionary<String, String>();

            _comboSource.Add("- SELECT", "NONE");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.BARBARIAN"), "Barbarian");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.BARD"), "Bard");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.CLERIC"), "Cleric");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.DRUID"), "Druid");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.FIGHTER"), "Fighter");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.MONK"), "Monk");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.PALADIN"), "Paladin");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.ROGUE"), "Rogue");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.SORCERER"), "Sorcerer");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.WARLOCK"), "Warlock");
            _comboSource.Add(ULanguage.getStringCurrentLanguage("RPG.CLASS.WIZARD"), "Wizard");

            cmbClass.DataSource = new BindingSource(_comboSource, null);
            cmbClass.DisplayMember = "Key";
            cmbClass.ValueMember = "Value";
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharHeroesCrud lastState, EnumStateCharHeroesCrud currentState)
        {
            if(currentState == EnumStateCharHeroesCrud.STATE_CLASS_CHANGED)
            {
                String value = ( (KeyValuePair<string, string>) cmbClass.SelectedItem).Value;
                Type type = Type.GetType("RPGMasterTools.Source.Model.RPG.DND5E." + value);

                if(type != null)
                {
                    CClass currentClass = (CClass) Activator.CreateInstance(type);
                    this._controller.player.pClass = currentClass;

                    // UPDATE PICTURE BOX
                    pBoxClass.Image = currentClass.icon;
                }
                else
                {
                    this._controller.player.pClass = null;

                    // UPDATE PICTURE BOX
                    pBoxClass.Image = RPGMasterTools.Properties.Resources.ico_class_none;
                }
            }
            else if (currentState == EnumStateCharHeroesCrud.STATE_OK || currentState == EnumStateCharHeroesCrud.STATE_CANCEL)
            {
                close();
            }
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
            this._controller.player.name = txtName.Text;
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
