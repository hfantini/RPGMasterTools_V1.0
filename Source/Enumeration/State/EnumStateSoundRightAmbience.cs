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
    |	Name: [EnumStateSoundRightAmbience.cs]
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
    public enum EnumStateSoundRightAmbience
    {
        STATE_NONE,
        STATE_IDLE,
        STATE_PLAY,
        STATE_STOP,
        STATE_PAUSE,
        STATE_VOLUME_CHANGE,
        STATE_UPDATE_LIST_ADD,
        STATE_UPDATE_LIST_REMOVE,
        STATE_UPDATE_LIST_CLEAR,
        STATE_UPDATE_LIST_RECREATE,
        STATE_PRESET_LOADED,
        STATE_SEARCH,
        STATE_SEARCH_FOCUS
    }
}
