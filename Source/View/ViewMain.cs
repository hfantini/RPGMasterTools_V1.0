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
    |	Name: [FrmMain.cs]
    |	Type: [Form]
    |	Author: Henrique Fantini
    |	
    |	Description: Main form of the program.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View.Sound;
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

    public partial class ViewMain : Form, IView<EnumStateMain>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private MainController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewMain()
        {
            InitializeComponent();

            // == FORM CONFIGURATION

            this.WindowState = FormWindowState.Maximized;

            UFormUtil.applyLanguageToForm(this);
            UFormUtil.applyLanguageToMenu(mnuMain);
            UFormUtil.applyLanguageToTabPanel(tpnlMain);

            // == INIT CONTROLLER
            this._controller = new MainController(this);

            // == ADDING ANOTHER COMPONENTS

            ViewSound viewSound = new ViewSound(this._controller);
            viewSound.Dock = DockStyle.Fill;
            tabSound.Controls.Add( viewSound );
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateMain lastState, EnumStateMain currentState)
        {

        }

        // == EVENTS
        // ==============================================================

        private void ViewMain_Load(object sender, EventArgs e)
        {
            this._controller.update();
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public void getController()
        {
            throw new NotImplementedException();
        }
    }
}
