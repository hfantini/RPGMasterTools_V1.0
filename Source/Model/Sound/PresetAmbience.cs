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
    |	Name: [PresetAmbience.cs]
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

    public class PresetAmbience
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolume = 100;
        private bool _autoPlay = false;
        private List<Ambience> _ambienceList = new List<Ambience>();

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

        public bool autoPlay
        {
            get { return this._autoPlay; }
            set { this._autoPlay = value; }
        }

        public List<Ambience> ambienceList
        {
            get { return this._ambienceList; }
            set { this._ambienceList = value; }
        }
    }
}
