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
    |	Name: [ViewCharacterHeroes]
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacterHeroes : UserControl, IComponent<EnumStateCharHeroes>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private CharHeroesController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacterHeroes()
        {
            InitializeComponent();
        }

        public ViewCharacterHeroes(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER
            this._controller = new CharHeroesController(this, parentController);

            // CONFIGURE COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharHeroes lastState, EnumStateCharHeroes currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroes.STATE_ADD;
        }

        private void ViewCharacterHeroes_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCharHeroes.STATE_IDLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
