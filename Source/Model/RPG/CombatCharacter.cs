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
    |	Name: [CombatCharacter.cs]
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

    public class CombatCharacter
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private Character _character = null;
        private int _initiave = -1;

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public CombatCharacter()
        {

        }

        public CombatCharacter(Character character, int initiative)
        {
            this._character = character;
            this._initiave = initiative;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public Character character
        {
            get { return this._character; }
        }

        public int initiative
        {
            get { return this._initiave; }
            set
            {
                if(value < 1)
                {
                    this._initiave = 1;
                }
                else if(value > 20)
                {
                    this._initiave = 20;
                }
                else
                {
                    this._initiave = value;
                }
            }
        }
    }
}
