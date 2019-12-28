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
using RPGMasterTools.Source.Model.RPG.DND5E;
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

        public virtual void damage(int value)
        {
            if (value > 0)
            {
                int newLife = this._lifePoints - value;
                this.lifePoints = newLife;
            }
        }

        public virtual void heal(int value)
        {
            if(value > 0)
            {
                int newLife = this._lifePoints + value;
                this.lifePoints = newLife;
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
                if(value < 0)
                {
                    this._lifePoints = 0;
                }
                else if(value > this.maxLifePoints )
                {
                    this._lifePoints = this.maxLifePoints;
                }
                else
                {
                    this._lifePoints = value;
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
