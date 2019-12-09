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
    |	Name: [EnumStateSoundRightMusicPlate.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: Define the state of sound controller left.
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
    public enum EnumStateSoundRightMusicPlate
    {
        STATE_NONE,
        STATE_PLAYING,
        STATE_STOPPED,
        STATE_PAUSED
    }
}
