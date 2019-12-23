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
    |	Name: [CombatState.cs]
    |	Type: [ENUM]
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

namespace RPGMasterTools.Source.Enumeration.RPG
{
    // == ENUM
    // ==============================================================

    [DefaultValue(PREPARATION)]
    public enum CombatState
    {
        PREPARATION,
        FIGHT,
        FINISHED
    }
}
