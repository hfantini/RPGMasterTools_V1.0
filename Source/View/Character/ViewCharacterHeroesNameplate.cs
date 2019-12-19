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
using RPGMasterTools.Properties;
using RPGMasterTools.Source.Util;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacterHeroesNameplate : UserControl, IComponent<EnumStateCharHeroesNamePlate>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharHeroesNamePlateController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterHeroesNameplate()
        {
            InitializeComponent();
        }

        public ViewCharacterHeroesNameplate(GenericController parentController, Player player)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER

            this._controller = new CharHeroesNamePlateController(this, parentController, player);

            // CONFIGURE COMPONENTS
            this.lblCharName.Text = this._controller.player.name;
            this.pBoxClassIcon.Image = URPG.getClassIcon(this._controller.player.pClass);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharHeroesNamePlate lastState, EnumStateCharHeroesNamePlate currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroesNamePlate.STATE_EDIT;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroesNamePlate.STATE_REMOVE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
