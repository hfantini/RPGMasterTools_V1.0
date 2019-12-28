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
    |	Name: [Enemy.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines an enemy class.
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
    public class Enemy : Character
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Enemy() : base("UNKNOWN")
        {

        }

        public Enemy(string name) : base(name)
        {
            
        }

        // == METHODS
        // ==============================================================

        public override void damage(int value)
        {
            base.damage(value);

            if (this.lifePoints <= 0)
            {
                this.currentState = Enumeration.RPG.DND5E.EnumCharacterState.STATE_DEAD;
            }
        }

        public override void heal(int value)
        {
            base.heal(value);

            this.currentState = Enumeration.RPG.DND5E.EnumCharacterState.STATE_COMBAT;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
