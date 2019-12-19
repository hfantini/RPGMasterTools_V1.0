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
    |	Name: [CharEnemiesCrudController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View;
using RPGMasterTools.Source.View.Character;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Char
{
    // == CLASS
    // ==============================================================

    public class CharEnemiesCrudController : ComponentController<EnumStateCharEnemiesCrud>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Enemy _enemy;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharEnemiesCrudController(IComponent<EnumStateCharEnemiesCrud> component, GenericController controller, Enemy enemy) : base(component, controller)
        {
            if (enemy == null)
            {
                this._enemy = new Enemy();
            }
            else
            {
                this._enemy = enemy;
            }
        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public Enemy enemy
        {
            get { return this._enemy; }
        }
    }
}
