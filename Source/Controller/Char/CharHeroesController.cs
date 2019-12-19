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
    |	Name: [CharHeroesController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Char controller class.
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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Char
{
    // == CLASS
    // ==============================================================

    public class CharHeroesController : ComponentController<EnumStateCharHeroes>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Player _selectedPlayer = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharHeroesController(IComponent<EnumStateCharHeroes> component, GenericController controller) : base(component, controller)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if (currentState == EnumStateCharHeroes.STATE_ADD)
            {
                String title = "CHARACTER.HEROES.CRUD.TITLE_NEW";
                ViewCharacterHeroesCrud hCrud = new ViewCharacterHeroesCrud(title, this, null);

                ViewDialog dlgNewHero = new ViewDialog(title, hCrud);
                dlgNewHero.Size = new Size(300, 250);
                dlgNewHero.ShowDialog();

                // ON DIALOG CLOSED

                if (hCrud.currentState == EnumStateCharHeroesCrud.STATE_OK)
                {
                    Player player = hCrud.currentModel;
                    CharController.addPlayerToList(player);
                    ((CharController)this.parentController).currentState = EnumStateChar.STATE_PLAYERLIST_UPDATE;
                }
            }
            else if (currentState == EnumStateCharHeroes.STATE_ALTER)
            {
                String title = "CHARACTER.HEROES.CRUD.TITLE_ALTER";
                ViewCharacterHeroesCrud hCrud = new ViewCharacterHeroesCrud(title, this, this._selectedPlayer);

                ViewDialog dlgNewHero = new ViewDialog(title, hCrud);
                dlgNewHero.Size = new Size(300, 250);
                dlgNewHero.ShowDialog();

                // ON DIALOG CLOSED

                if (hCrud.currentState == EnumStateCharHeroesCrud.STATE_OK)
                {
                    ((CharController)this.parentController).currentState = EnumStateChar.STATE_PLAYERLIST_UPDATE;
                }
            }

            if(this.currentState != EnumStateCharHeroes.STATE_IDLE)
            {
                this.currentState = EnumStateCharHeroes.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if( parentController is CharController )
            {
                CharController controller = (CharController) parentController;

                if(controller.currentState == EnumStateChar.STATE_PLAYERLIST_UPDATE)
                {
                    this.currentState = EnumStateCharHeroes.STATE_UPDATE_PLAYERLIST;
                }
                else
                {
                    base.onParentStateChange(parentController);
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public Player seletectedPlayer
        {
            get { return this._selectedPlayer; }
            set { this._selectedPlayer = value; }
        }
    }
}
