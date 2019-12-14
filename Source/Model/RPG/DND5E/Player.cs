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

    public class Player : Character
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CClass _pClass = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Player(string name, CClass pClass) : base(name)
        {
            this._pClass = pClass;
        }

        // == METHODS
        // ==============================================================

        public override Bitmap getIcon()
        {
            return this._pClass.icon;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public CClass pClass
        {
            get { return this._pClass; }
        }
    }
}
