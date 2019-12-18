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
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCharEnemies lastState, EnumStateCharEnemies currentState)
        {
            throw new NotImplementedException();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
