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
    |	Name: [Hotkey]
    |	Type: [TYPE]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.Sys
{
    // == CLASS
    // ==============================================================

    public class Hotkey
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private EnumKeyModifier _modifier;
        private Keys _key;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Hotkey(EnumKeyModifier modifier, Keys key)
        {
            this._modifier = modifier;
            this._key = key;
        }

        // == METHODS
        // ==============================================================

        public bool isKeyNumber()
        {
            var retValue = false;

            if( (this._key.GetHashCode() >= 48 && this._key.GetHashCode() <= 57) || (this._key.GetHashCode() >= 96 && this._key.GetHashCode() <= 105))
            {
                retValue = true;
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public EnumKeyModifier modifier
        {
            get { return this._modifier; }
        }

        public Keys key
        {
            get { return this._key; }
        }
    }
}
