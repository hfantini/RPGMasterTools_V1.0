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
    |	Name: [PresetSoundFX.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

// == NAMESPACE
// ==================================================================

using System.Collections.Generic;

namespace RPGMasterTools.Source.Model.Sound
{
    // == CLASS
    // ==============================================================

    public class PresetSoundFX
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolume = 100;
        private List<SoundFX> _sfxList = new List<SoundFX>();

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public int masterVolume
        {
            get { return this._masterVolume; }
            set { this._masterVolume = value; }
        }

        public List<SoundFX> sfxList
        {
            get { return this._sfxList; }
            set { this._sfxList = value; }
        }
    }
}
