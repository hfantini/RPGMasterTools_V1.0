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
    |	Name: [EnumCharacterClass.cs]
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

namespace RPGMasterTools.Source.Enumeration.RPG.DND5E
{
    // == ENUM
    // ==============================================================

    [DefaultValue(UNDEFINED)]
    public enum EnumCharacterClass
    {
        UNDEFINED = 0,
        BARBARIAN = 1,
        BARD = 2,
        CLERIC = 3,
        DRUID = 4,
        FIGHTER = 5,
        MONK = 6,
        PALADIN = 7,
        RANGER = 8,
        ROGUE = 9,
        SORCERER = 10,
        WARLOCK = 11,
        WIZARD = 12
    }
}
