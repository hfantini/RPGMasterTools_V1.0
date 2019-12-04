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
    |	Name: [EnumLogLevel.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines all log levels of importance.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System.ComponentModel;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Enumeration.Log
{
    // == ENUM
    // ==============================================================

    [DefaultValue(LEVEL_NORMAL)]
    public enum EnumLogLevel
    {
        LEVEL_LOW = 0,
        LEVEL_NORMAL = 1,
        LEVEL_HIGH = 2,
        LEVEL_IMPORTANT = 3,
        LEVEL_CRITICAL = 4
    }
}
