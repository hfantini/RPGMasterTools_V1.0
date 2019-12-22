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
    |	Name: [Player.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a player class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG.DND5E
{
    // == CLASS
    // ==============================================================

    [Serializable]
    public class Player : Character
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private PClass _pClass = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Player() : base("UNKNOWN")
        {

        }

        public Player(string name, PClass pClass) : base(name)
        {
            this._pClass = pClass;
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public PClass pClass
        {
            get { return this._pClass; }
            set { this._pClass = value; }
        }
    }
}
