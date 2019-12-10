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
    |	Name: [Preset.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Define a preset for sound configuration.
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

    public class Preset
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private PresetMusic _musicPreset = new PresetMusic();
        private PresetAmbience _ambiencePreset = new PresetAmbience();
        private PresetSoundFX _sfxPreset = new PresetSoundFX();

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public PresetMusic musicPreset
        {
            get { return this._musicPreset; }
            set { this._musicPreset = value; }
        }

        public PresetAmbience ambiencePreset
        {
            get { return this._ambiencePreset; }
            set { this._ambiencePreset = value; }
        }

        public PresetSoundFX sfxPreset
        {
            get { return this._sfxPreset; }
            set { this._sfxPreset = value; }
        }
    }
}
