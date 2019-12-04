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
    |	Name: [EnumLogType.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines all types of log used by the system.
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

    [DefaultValue(TYPE_NORMAL)]
    public enum EnumLogType
    {
        TYPE_NORMAL,
        TYPE_INFO,
        TYPE_WARNING,
        TYPE_ERROR
    }
}
