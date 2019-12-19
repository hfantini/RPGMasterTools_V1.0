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
    |	Name: [CharHeroesNamePlateController.cs]
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

    public class CharHeroesNamePlateController : ComponentController<EnumStateCharHeroesNamePlate>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Player _player;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharHeroesNamePlateController(IComponent<EnumStateCharHeroesNamePlate> component, GenericController controller, Player player) : base(component, controller)
        {
            this._player = player;
        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateCharHeroesNamePlate.STATE_EDIT)
            {
                ((CharHeroesController)this.parentController).seletectedPlayer = this._player;
                ((CharHeroesController)this.parentController).currentState = EnumStateCharHeroes.STATE_ALTER;
            }
            else if (this.currentState == EnumStateCharHeroesNamePlate.STATE_REMOVE)
            {
                CharController.removePlayerFromList(this._player);
                ((CharController)this.parentController.parentController).currentState = EnumStateChar.STATE_PLAYERLIST_UPDATE;
            }

            if( this.currentState != EnumStateCharHeroesNamePlate.STATE_IDLE)
            {
                this.currentState = EnumStateCharHeroesNamePlate.STATE_IDLE;
            }
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
