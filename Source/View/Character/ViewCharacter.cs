
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
    |	Name: [ViewCharacter.cs]
    |	Type: [TYPE]
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCharacter : UserControl, IComponent<EnumStateChar>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CharController _controller = null;
        private ViewCharacterHeroes _viewCharHeroes = null;
        private ViewCharacterEnemies _viewCharEnemies = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCharacter()
        {
            InitializeComponent();
        }

        public ViewCharacter(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIGURE CONTROLLER

            this._controller = new CharController(this, parentController);

            // CONFIGURE COMPONENTS

            this._viewCharHeroes = new ViewCharacterHeroes(this._controller);
            this._viewCharHeroes.Dock = DockStyle.Fill;
            this.pnlHeroes.Controls.Add(this._viewCharHeroes);

            this._viewCharEnemies = new ViewCharacterEnemies();
            this._viewCharEnemies.Dock = DockStyle.Fill;
            this.pnlEnemies.Controls.Add(this._viewCharEnemies);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateChar lastState, EnumStateChar currentState)
        {

        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
