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
    |	Name: [ViewDialog.cs]
    |	Type: [VIEW]
    |	Author: Henrique Fantini
    |	
    |	Description: Default dialog form.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View
{
    // == CLASS
    // ==============================================================

    public partial class ViewDialog : Form
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Control _control = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewDialog()
        {
            InitializeComponent();
        }

        public ViewDialog(String title, Control control)
        {
            InitializeComponent();

            this.Text = ULanguage.getStringCurrentLanguage(title);
            this._control = control;

            // ADD CONTROL AS CHILDREN
            this._control.Dock = DockStyle.Fill;
            this.Controls.Add(this._control);
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
