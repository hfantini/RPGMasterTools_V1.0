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
    |	Name: [SoundFX.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Represents an SoundFX in the system.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundFX
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private string _name;
        private string _path;
        private string _type;
        private int _volume = 100;

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public override bool Equals(object obj)
        {
            bool retValue = false;

            if (this._name == null || this._path == null)
            {
                retValue = base.Equals(obj);
            }
            else
            {
                if (obj is SoundFX)
                {
                    SoundFX compSFX = (SoundFX) obj;

                    if (this._name == compSFX._name && this._path == compSFX.path)
                    {
                        retValue = true;
                    }
                    else
                    {
                        retValue = false;
                    }
                }
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        public string type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public int volume
        {
            get { return this._volume; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    this._volume = value;
                }
            }
        }
    }
}
