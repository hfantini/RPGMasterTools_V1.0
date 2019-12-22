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
    |	Name: [EnumControllerCombatFilter.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: -
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

namespace RPGMasterTools.Source.Enumeration.Controller
{
    // == CLASS
    // ==============================================================

    [DefaultValue(SHOW_ALL)]
    public enum EnumControllerCombatFilter
    {
        SHOW_ALL,
        SHOW_PLAYERS_ONLY,
        SHOW_ENEMIES_ONLY
    }
}
