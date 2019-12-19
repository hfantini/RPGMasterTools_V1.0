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
    |	Name: [ViewCharacterHeroesNameplate]
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
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacterEnemiesNameplate : UserControl, IComponent<EnumStateCharEnemiesNamePlate>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharEnemiesNamePlateController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterEnemiesNameplate()
        {
            InitializeComponent();
        }

        public ViewCharacterEnemiesNameplate(GenericController parentController, Enemy enemy)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER

            this._controller = new CharEnemiesNamePlateController(this, parentController, enemy);

            // CONFIGURE COMPONENTS
            this.lblCharName.Text = this._controller.enemy.name;
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharEnemiesNamePlate lastState, EnumStateCharEnemiesNamePlate currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemiesNamePlate.STATE_EDIT;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharEnemiesNamePlate.STATE_REMOVE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
