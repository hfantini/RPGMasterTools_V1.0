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
    |	Name: [Ambience.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Represents an ambience in the system.
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

    public class Ambience
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private string _name;
        private string _path;
        private string _type;
        private bool _autoPlay = false;
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
                if (obj is Ambience)
                {
                    Ambience compAmbience = (Ambience) obj;

                    if (this._name == compAmbience._name && this._path == compAmbience.path)
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
            get { return _name; }
            set { this._name = value; }
        }

        public string path
        {
            get { return _path; }
            set { this._path = value; }
        }

        public string type
        {
            get { return _type; }
            set { this._type = value; }
        }

        public bool autoPlay
        {
            get { return _autoPlay; }
            set { this._autoPlay = value; }
        }

        public int volume
        {
            get { return _volume; }
            set
            {
                if (volume < 0)
                {
                    volume = 0;
                }
                else if (volume > 100)
                {
                    volume = 100;
                }
                else
                {
                    this._volume = value;
                }
            }
        }
    }
}
