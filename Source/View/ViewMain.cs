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

            this._controller = new MainController(this);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateMain lastState, EnumStateMain currentState)
        {
            if(currentState == EnumStateMain.STATE_START)
            {
                this.label1.Text = "START";
            }
            else if (currentState == EnumStateMain.STATE_LOADING)
            {
                this.label1.Text = "LOADING";
            }
            else if (currentState == EnumStateMain.STATE_READY)
            {
                this.label1.Text = "READY";
            }
        }

        // == EVENTS
        // ==============================================================

        private void button1_Click(object sender, EventArgs e)
        {
            if (this._controller.currentState == EnumStateMain.STATE_START)
            {
                this._controller.currentState = EnumStateMain.STATE_LOADING;
            }
            else if (this._controller.currentState == EnumStateMain.STATE_LOADING)
            {
                this._controller.currentState = EnumStateMain.STATE_READY;
            }
            else if (this._controller.currentState == EnumStateMain.STATE_READY)
            {
                this._controller.currentState = EnumStateMain.STATE_START;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public void getController()
        {
            throw new NotImplementedException();
        }
    }
}
