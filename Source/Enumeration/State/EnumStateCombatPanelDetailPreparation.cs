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
    |	Name: [EnumStateCombatPanelDetailPreparation.cs]
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
    public enum EnumStateCombatPanelDetailPreparation
    {
        STATE_NONE,
        STATE_IDLE
    }
}
