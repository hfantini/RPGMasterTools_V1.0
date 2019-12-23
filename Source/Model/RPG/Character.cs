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
                    // STATE
                }
            }
        }

        public void stun( int turns )
        {
            if(turns > 0)
            {
                this._stunTurnsCounter = turns;
                this._currentState = EnumCharacterState.STATE_STUNNED;
            }
        }

        public void charm(int turns)
        {
            if (turns > 0)
            {
                this._charmTurnsCounter = turns;
                this._currentState = EnumCharacterState.STATE_CHARMED;
            }
        }

        // CALLED WHEN ANY PLAYERS FINISHES HIS PLAY
        public void updatePlayerEnd()
        {

        }

        // CALLED WHEN THE TURNS END
        public void updateTurnEnd()
        {
            if (this._currentState == EnumCharacterState.STATE_STUNNED)
            {
                this._stunTurnsCounter--;

                if (this._stunTurnsCounter == 0)
                {
                    this._currentState = EnumCharacterState.STATE_COMBAT;
                }
            }
            else if (this._currentState == EnumCharacterState.STATE_CHARMED)
            {
                this._charmTurnsCounter--;

                if (this._charmTurnsCounter == 0)
                {
                    this._currentState = EnumCharacterState.STATE_COMBAT;
                }
            }
        }

        public virtual String getIcon()
        {
            return "RPGMasterTools.Properties.Resources.ico_class_none";
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
    }
}
