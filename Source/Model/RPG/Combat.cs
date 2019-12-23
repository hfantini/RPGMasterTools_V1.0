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
    |	Name: [Combat.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Describes a combat event.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.RPG;
using RPGMasterTools.Source.Model.RPG.DND5E;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG
{
    // == CLASS
    // ==============================================================

    public class Combat
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private string _name = "?";
        private CombatState _combatState;
        private int _currentTurn = 0;
        private int _currentPlay = 0;
        private DateTime _startTime;
        private DateTime _endTime;
        private List<Character> _characterList;
        private List<CombatCharacter> _combatCharacterList;
        private int _currentCharacterPlayIndex = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Combat()
        {
            this._characterList = new List<Character>();
            this._combatCharacterList = new List<CombatCharacter>();
        }

        // == METHODS
        // ==============================================================

        public void addCharacterToList(Character character)
        {
            if (!this._characterList.Contains(character))
            {
                this._characterList.Add(character);
            }
        }

        public void removeCharacterToList(Character character)
        {
            this._characterList.Remove(character);
        }

        public void goToNextState()
        {
            if(this._combatState == CombatState.PREPARATION)
            {
                this._combatState = CombatState.FIGHT;
                onStateChangedToFight();
            }
            else if(this._combatState == CombatState.FIGHT)
            {
                this._combatState = CombatState.FINISHED;
                onStateChangedToFinish();
            }
        }

        // == EVENTS
        // ==============================================================

        private void onStateChangedToPreparation()
        {

        }

        private void onStateChangedToFight()
        {
            this.startTime = DateTime.Now;
            this._currentCharacterPlayIndex = 0;
            this._currentPlay = 0;
            this._currentTurn = 0;
        }

        private void onStateChangedToFinish()
        {
            this.endTime = DateTime.Now;
        }

        public void nextPlay()
        {
            if (this.combatState == CombatState.FIGHT)
            {
                if (this._currentCharacterPlayIndex < this._combatCharacterList.Count - 1)
                {
                    this._currentPlay++;
                    this._currentCharacterPlayIndex++;
                }
                else
                {
                    this._currentPlay++;
                    this._currentTurn++;
                    this._currentCharacterPlayIndex = 0;
                }
            }
        }

        public CombatCharacter getCurrentPlay()
        {
            CombatCharacter retValue = null;

            if (this.combatState == CombatState.FIGHT)
            {
                retValue = this._combatCharacterList[ this._currentCharacterPlayIndex ];
            }

            return retValue;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public String name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public CombatState combatState
        {
            get { return this._combatState; }
        }

        public int currentPlay
        {
            get { return this._currentPlay; }
            set { this._currentPlay = value; }
        }

        public int currentTurn
        {
            get { return this._currentTurn; }
            set { this._currentTurn = value; }
        }

        public DateTime startTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        public DateTime endTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        public List<Character> characterList
        {
            get { return new List<Character>(this._characterList); }
        }

        public List<CombatCharacter> characterCombatList
        {
            get { return new List<CombatCharacter>(this._combatCharacterList); }
            set { this._combatCharacterList = value; }
        }
    }
}
