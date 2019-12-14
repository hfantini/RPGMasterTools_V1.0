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
using RPGMasterTools.Source.Enumeration.System;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sys;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View.Character;
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
        ViewSound _viewSound = null;
        ViewCharacter _viewCharacter = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewMain()
        {
            InitializeComponent();

            // == INIT VALUES

            this._controller = new MainController(this);

            // == FORM CONFIGURATION

            this.WindowState = FormWindowState.Maximized;

            UComponent.applyLanguageToComponent(this);
            UComponent.applyLanguageToTabPanel(tpnlMain);

            // == ADDING ANOTHER COMPONENTS

            this._viewSound = new ViewSound(this._controller);
            this._viewSound.Dock = DockStyle.Fill;
            tabSound.Controls.Add(this._viewSound);

            this._viewCharacter = new ViewCharacter(this._controller);
            this._viewCharacter.Dock = DockStyle.Fill;
            tabCharacter.Controls.Add(this._viewCharacter);

            // == REGISTERING GLOBAL HOTKEYS

            registerHotkeys();
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateMain lastState, EnumStateMain currentState)
        {
            if(currentState == EnumStateMain.STATE_TAB_CHANGE)
            {
                tpnlMain.SelectedIndex = this._controller.activeTab;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312 && this.ContainsFocus)
            {    
                int id = m.WParam.ToInt32();                                        

                this._controller.lastPressedHotKey = this._controller.systemAvailableHotkeys[id];
                this._controller.currentState = EnumStateMain.STATE_GLOBAL_HOTKEY_PRESSED;
            }
        }

        private void registerHotkeys()
        {
            for (int count = 0; count < this._controller.systemAvailableHotkeys.Count; count++)
            {
                Hotkey currentHotkey = this._controller.systemAvailableHotkeys[count];
                RegisterHotKey(this.Handle, count, (int)currentHotkey.modifier, currentHotkey.key.GetHashCode());
            }
        }

        private void unregisterHotkeys()
        {
            // == UNREGISTERING GLOBAL HOTKEYS

            for (int count = 0; count < this._controller.systemAvailableHotkeys.Count; count++)
            {
                UnregisterHotKey(this.Handle, count);
            }
        }

        // == EVENTS
        // ==============================================================

        private void ViewMain_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateMain.STATE_IDLE;
        }

        private void ViewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            unregisterHotkeys();

            // DESTROY ALL CONTROLLERS
            this._controller.Dispose();
        }

        private void ViewMain_Enter(object sender, EventArgs e)
        {
            registerHotkeys();
        }

        private void ViewMain_Leave(object sender, EventArgs e)
        {
            unregisterHotkeys();
        }

        private void ViewMain_Activated(object sender, EventArgs e)
        {
            registerHotkeys();
        }

        private void ViewMain_Deactivate(object sender, EventArgs e)
        {
            unregisterHotkeys();
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
