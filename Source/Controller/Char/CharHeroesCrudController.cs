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
    |	Name: [CharHeroesCrudController]
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

    public class CharHeroesCrudController : ComponentController<EnumStateCharHeroesCrud>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Player _player;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharHeroesCrudController(IComponent<EnumStateCharHeroesCrud> component, GenericController controller) : base(component, controller)
        {
            this._player = new Player();
        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if (this.currentState == EnumStateCharHeroesCrud.STATE_CLASS_CHANGED)
            {
                this.currentState = EnumStateCharHeroesCrud.STATE_IDLE;
            }
            else if (this.currentState == EnumStateCharHeroesCrud.STATE_VALIDATE)
            {
                if (validate())
                {
                    this.currentState = EnumStateCharHeroesCrud.STATE_OK;
                }
                else
                {
                    MessageBox.Show("VALIDATION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.currentState = EnumStateCharHeroesCrud.STATE_IDLE;
                }
            }
        }

        protected bool validate()
        {
            bool retValue = true;

            // NAME

            if(player.name == null || player.name == "")
            {
                retValue = false;
            }

            // CLASS

            if(player.pClass == null)
            {
                retValue = false;
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public Player player
        {
            get { return this._player; }
        }
    }
}
