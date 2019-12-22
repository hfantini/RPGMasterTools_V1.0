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
    |	Name: [CombatCrudController.cs]
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
using RPGMasterTools.Source.Enumeration.Controller;
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.RPG;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
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

    public class CombatCrudController : ComponentController<EnumStateCombatCrud>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private EnumControllerCombatFilter _fromListFilter;
        private List<Character> _fromList;
        private List<Character> _toList;
        private Character _seletectedFrom = null;
        private Character _seletectedTo = null;
        private Combat _currentModel = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatCrudController(IComponent<EnumStateCombatCrud> component, GenericController controller) : base(component, controller)
        {
            this._fromList = new List<Character>();
            this._toList = new List<Character>();
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombatCrud currentState, EnumStateCombatCrud nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            if (this.currentState == EnumStateCombatCrud.STATE_FROMLIST_UPDATE)
            {
                this._fromList.Clear();

                // PLAYERS

                if(this._fromListFilter == EnumControllerCombatFilter.SHOW_ALL || this._fromListFilter == EnumControllerCombatFilter.SHOW_PLAYERS_ONLY)
                {
                    foreach( Character character in CharController.getListOfPlayers() )
                    {
                        if( !this._toList.Contains(character) )
                        {
                            this._fromList.Add(character);
                        }
                    }
                }

                // ENEMIES

                if (this._fromListFilter == EnumControllerCombatFilter.SHOW_ALL || this._fromListFilter == EnumControllerCombatFilter.SHOW_ENEMIES_ONLY)
                {
                    foreach (Character character in CharController.getListOfEnemies())
                    {
                        if (!this._toList.Contains(character))
                        {
                            this._fromList.Add(character);
                        }
                    }
                }
            }
            else if (currentState == EnumStateCombatCrud.STATE_FROMLIST_ADD_TOLIST)
            {
                addSelectedToList();
            }
            else if (currentState == EnumStateCombatCrud.STATE_FROMLIST_ADDALL_TOLIST)
            {
                addAllToList();
            }
            else if (currentState == EnumStateCombatCrud.STATE_TOLIST_ADD_FROMLIST)
            {
                addSelectedFromList();
            }
            else if (currentState == EnumStateCombatCrud.STATE_TOLIST_ADDALL_FROMLIST)
            {
                addAllFromList();
            }

            base.update();

            if (this.currentState != EnumStateCombatCrud.STATE_IDLE && this.currentState != EnumStateCombatCrud.STATE_OK && this.currentState != EnumStateCombatCrud.STATE_CANCEL)
            {
                this.currentState = EnumStateCombatCrud.STATE_IDLE;
            }

        }

        private void addSelectedToList()
        {
            if(this._seletectedFrom != null)
            {
                this._toList.Add(_seletectedFrom);
                this._fromList.Remove(this._seletectedFrom);
                this._seletectedFrom = null;

                this.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
                this.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE;
            }
        }

        private void addAllToList()
        {
            List<Character> auxCharacterList = new List<Character>(this._fromList);

            foreach (Character character in auxCharacterList)
            {
                if (!this._toList.Contains(character))
                {
                    this._toList.Add(character);
                    this._fromList.Remove(character);
                }

                this.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
                this.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE;
            }
        }

        private void addSelectedFromList()
        {
            if (this._seletectedTo != null)
            {
                this._fromList.Add(_seletectedTo);
                this._toList.Remove(this._seletectedTo);
                this._seletectedTo = null;

                this.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
                this.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE;
            }
        }

        private void addAllFromList()
        {
            List<Character> auxCharacterList = new List<Character>(this._toList);

            foreach (Character character in auxCharacterList)
            {
                if (!this._fromList.Contains(character))
                {
                    this._fromList.Add(character);
                    this._toList.Remove(character);
                }

                this.currentState = EnumStateCombatCrud.STATE_FROMLIST_UPDATE;
                this.currentState = EnumStateCombatCrud.STATE_TOLIST_UPDATE;
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public EnumControllerCombatFilter fromListFilter
        {
            get { return this._fromListFilter; }
            set { this._fromListFilter = value; }
        }

        public List<Character> fromList
        {
            get { return new List<Character>(this._fromList); }
        }

        public List<Character> toList
        {
            get { return new List<Character>(this._toList); }
        }

        public Character selectedFrom
        {
            get { return this._seletectedFrom; }
            set { this._seletectedFrom = value; }
        }

        public Character selectedTo
        {
            get { return this._seletectedTo; }
            set { this._seletectedTo = value; }
        }

        public Combat currentModel
        {
            get { return this._currentModel; }
            set { this._currentModel = value; }
        }
    }
}
