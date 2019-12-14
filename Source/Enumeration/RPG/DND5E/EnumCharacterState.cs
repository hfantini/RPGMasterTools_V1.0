
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
    |	Name: [FILENAME]
    |	Type: [TYPE]
    |	Author: Henrique Fantini
    |	
    |	Description:
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Enumeration.RPG.DND5E
{
    // == ENUM
    // ==============================================================

    [DefaultValue(STATE_IDLE)]
    public enum EnumCharacterState
    {
        STATE_DEAD,
        STATE_IDLE, //OUT OF COMBAT
        STATE_COMBAT,
        STATE_STUNNED,
        STATE_CHARMED,
    }
}
