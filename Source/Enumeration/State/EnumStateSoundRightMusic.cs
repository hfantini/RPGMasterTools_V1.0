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
    |	Name: [EnumStateSoundRightMusic.cs]
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
    public enum EnumStateSoundRightMusic
    {
        STATE_NONE,
        STATE_IDLE,
        STATE_UPDATE_LIST,
        STATE_PLAY,
        STATE_PLAYING,
        STATE_NOTHING_TO_PLAY,
        STATE_MEDIA_END,
        STATE_STOP,
        STATE_PAUSE,
        STATE_PAUSED,
        STATE_RESUME,
        STATE_NEXT,
        STATE_BACK,
        STATE_OPTION_UPDATE,
    }
}
