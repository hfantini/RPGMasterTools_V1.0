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
    |	Name: [EnumKeyModifier.cs]
    |	Type: [Enum]
    |	Author: Henrique Fantini
    |	
    |	Description: Define the key combination modifier.
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

namespace RPGMasterTools.Source.Enumeration.System
{
    // == ENUM
    // ==============================================================

    [DefaultValue(MOD_NONE)]
    public enum EnumKeyModifier
    {
        MOD_NONE = 0,
        MOD_ALT = 1,
        MOD_CONTROL = 2,
        MOD_SHIFT = 4,
        MOD_WINKEY = 8
    }
}
