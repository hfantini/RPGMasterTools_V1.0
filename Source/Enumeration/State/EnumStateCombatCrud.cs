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
    |	Name: [EnumStateCombatCrud.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System.ComponentModel;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Enumeration.State
{
    // == ENUM
    // ==============================================================

    [DefaultValue(STATE_NONE)]
    public enum EnumStateCombatCrud
    {
        STATE_NONE,
        STATE_IDLE,
        STATE_FROMLIST_UPDATE,
        STATE_FROMLIST_UPDATE_SELECTED,
        STATE_TOLIST_UPDATE,
        STATE_TOLIST_UPDATE_SELECTED,
        STATE_FROMLIST_ADD_TOLIST,
        STATE_FROMLIST_ADDALL_TOLIST,
        STATE_TOLIST_ADD_FROMLIST,
        STATE_TOLIST_ADDALL_FROMLIST,
        STATE_CANCEL,
        STATE_VALIDATION,
        STATE_OK
    }
}
