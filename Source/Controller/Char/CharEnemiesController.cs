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
    |	Name: [CharEnemiesController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Enemy char controller class.
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

    public class CharEnemiesController : ComponentController<EnumStateCharEnemies>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Enemy _selectedEnemy = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharEnemiesController(IComponent<EnumStateCharEnemies> component, GenericController controller) : base(component, controller)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if (currentState == EnumStateCharEnemies.STATE_ADD)
            {
                String title = "CHARACTER.ENEMIES.CRUD.TITLE_NEW";
                ViewCharacterEnemiesCrud eCrud = new ViewCharacterEnemiesCrud(title, this, null);

                ViewDialog dlgNewHero = new ViewDialog(title, eCrud);
                dlgNewHero.Size = new Size(300, 200);
                dlgNewHero.ShowDialog();

                // ON DIALOG CLOSED

                if (eCrud.currentState == EnumStateCharEnemiesCrud.STATE_OK)
                {
                    Enemy enemy = eCrud.currentModel;

                    CharController.addEnemyToList(enemy);
                    ((CharController)this.parentController).currentState = EnumStateChar.STATE_ENEMYLIST_UPDATE;
                }
            }
            else if (currentState == EnumStateCharEnemies.STATE_ALTER)
            {
                String title = "CHARACTER.HEROES.CRUD.TITLE_ALTER";
                ViewCharacterEnemiesCrud eCrud = new ViewCharacterEnemiesCrud(title, this, this._selectedEnemy);

                ViewDialog dlgNewEnemy = new ViewDialog(title, eCrud);
                dlgNewEnemy.Size = new Size(300, 200);
                dlgNewEnemy.ShowDialog();

                // ON DIALOG CLOSED

                if (eCrud.currentState == EnumStateCharEnemiesCrud.STATE_OK)
                {
                    ((CharController)this.parentController).currentState = EnumStateChar.STATE_ENEMYLIST_UPDATE;
                }
            }

            if (this.currentState != EnumStateCharEnemies.STATE_IDLE)
            {
                this.currentState = EnumStateCharEnemies.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is CharController)
            {
                CharController controller = (CharController)parentController;

                if (controller.currentState == EnumStateChar.STATE_ENEMYLIST_UPDATE)
                {
                    this.currentState = EnumStateCharEnemies.STATE_UPDATE_ENEMYLIST;
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

        public Enemy seletectedEnemy
        {
            get { return this._selectedEnemy; }
            set { this._selectedEnemy = value; }
        }
    }
}
