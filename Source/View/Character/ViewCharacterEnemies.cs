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
    |	Name: [ViewCharacterEnemies.cs]
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

    public partial class ViewCharacterEnemies : UserControl, IComponent<EnumStateCharEnemies>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharEnemiesController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterEnemies()
        {
            InitializeComponent();
        }

        public ViewCharacterEnemies(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER

            this._controller = new CharEnemiesController(this, parentController);

            // CONFIGURE COMPONENTS
            this.lblEnemiesTitle.Text = ULanguage.getStringCurrentLanguage(this.lblEnemiesTitle.Text);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharEnemies lastState, EnumStateCharEnemies currentState)
        {
            if (currentState == EnumStateCharEnemies.STATE_UPDATE_ENEMYLIST)
            {
                updateEnemyList();
            }
        }

        private void updateEnemyList()
        {
            UComponent.removeAllChildren(fLayoutEnemies);

            foreach (Enemy enemy in CharController.getListOfEnemies())
            {
                ViewCharacterEnemiesNameplate vNamePlate = new ViewCharacterEnemiesNameplate(this._controller, enemy);
                vNamePlate.Size = new Size(fLayoutEnemies.Size.Width - 15, vNamePlate.Size.Height);

                fLayoutEnemies.Controls.Add(vNamePlate);
            }
        }

        // == EVENTS
        // ==============================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemies.STATE_ADD;
        }

        private void ViewCharacterEnemies_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemies.STATE_IDLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
