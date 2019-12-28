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
    |	Name: [ViewCombatPanelDialogDamage.cs]
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

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanelDialogDamage : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _value = -1;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanelDialogDamage()
        {
            InitializeComponent();
        }

        // == METHODS
        // ==============================================================

        private bool validate()
        {
            bool retValue = true;

            String text = txtDamage.Text;

            if (text != "")
            {
                if (!text.All(Char.IsDigit))
                {
                    retValue = false;
                }
            }
            else
            {
                retValue = false;
            }

            return retValue;
        }

        private void applyValue()
        {
            this._value = Convert.ToInt32(txtDamage.Text);
        }

        private void close()
        {
            ((Form)this.Parent).Close();
        }

        // == EVENTS
        // ==============================================================

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                applyValue();
                close();
            }
            else
            {
                MessageBox.Show("VALIDATION PROBLEMS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            close();
        }

        private void txtDamage_TextChanged(object sender, EventArgs e)
        {
            String text = txtDamage.Text;

            if (text != "")
            {
                if (!text.All(Char.IsDigit))
                {
                    txtDamage.Text = "";
                }
                else
                {
                    int value = Convert.ToInt32(text);

                    if (value < 1)
                    {
                        txtDamage.Text = "";
                    }
                }
            }
        }

        private void ViewCombatPanelDialogDamage_Load(object sender, EventArgs e)
        {
            Form pForm = (Form)this.Parent;
            pForm.AcceptButton = this.btnOk;
            pForm.CancelButton = this.btnCancel;

            Parent.Size = new Size(470, 220);
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public int value
        {
            get { return this._value; }
        }
    }
}
