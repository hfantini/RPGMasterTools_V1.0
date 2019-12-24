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
    |	Name: [Character]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Define a RPG character.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.RPG;
using RPGMasterTools.Source.Enumeration.RPG.DND5E;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG
{
    // == CLASS
    // ==============================================================

    [Serializable]
    public class Character
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private string _name;
        private EnumCharacterState _currentState;
        private int _maxLifePoints = 0;
        private int _lifePoints = 0;
        private int _stunTurnsCounter = 0;
        private int _charmTurnsCounter = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Character(string name)
        {
            this._name = name;
        }

        // == METHODS
        // ==============================================================

        public void damage(int value)
        {
            if (value > 0)
            {
                this._lifePoints -= value;

                if (this._lifePoints < 0)
                {
                    this._lifePoints = 0;
                    this._currentState = EnumCharacterState.STATE_FALLEN;
                }
            }
        }

        public void heal(int value)
        {
            if(value > 0)
            {
                if (this._lifePoints + value > this._maxLifePoints)
                {
                    this._lifePoints = this._maxLifePoints;
                }
                else
                {
                    this._lifePoints += value;
                    this._currentState = EnumCharacterState.STATE_COMBAT;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public EnumCharacterState currentState
        {
            get { return this._currentState;  }
            set { this._currentState = value; }
        }

        public int lifePoints
        {
            get { return this._lifePoints; }
            set
            {
                if(value > 0)
                {
                    this._lifePoints = value;
                }
                else
                {
                    this._lifePoints = 0;
                }
            }
        }

        public int maxLifePoints
        {
            get { return this._maxLifePoints; }
            set
            {
                if (value > 0)
                {
                    this._maxLifePoints = value;
                }
                else
                {
                    this._maxLifePoints = 0;
                }
            }
        }
    }
}
