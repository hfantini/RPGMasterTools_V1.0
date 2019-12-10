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
    |	Name: [PresetMusic.cs]
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

    public class PresetMusic
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolume = 100;
        private bool _repeat = false;
        private bool _random = false;
        private bool _autoPlay = false;
        private List<Music> _musicList = new List<Music>();

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

        public bool repeat
        {
            get { return this._repeat; }
            set { this._repeat = value; }
        }

        public bool random
        {
            get { return this._random; }
            set { this._random = value; }
        }

        public bool autoPlay
        {
            get { return this._autoPlay; }
            set { this._autoPlay = value; }
        }

        public List<Music> musicList
        {
            get { return this._musicList; }
            set { this._musicList = value; }
        }
    }
}
