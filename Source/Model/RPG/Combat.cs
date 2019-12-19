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
        private int _currentTurn = 0;
        private int _currentPlay = 0;
        private DateTime _startTime;
        private DateTime _endTime;
        private List<Player> _playerList;
        private List<Enemy> _enemyList;
        private List<CombatCharacter> _combatCharList;

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public Combat()
        {
            this._playerList = new List<Player>();
            this._enemyList = new List<Enemy>();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

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

        public List<Player> playerList
        {
            get { return this._playerList; }
            set { this._playerList = null; }
        }

        public List<Enemy> enemyList
        {
            get { return this._enemyList; }
            set { this._enemyList = null; }
        }

        public List<CombatCharacter> combatCharacter
        {
            get { return this._combatCharList; }
            set { this._combatCharList = null; }
        }
    }
}
