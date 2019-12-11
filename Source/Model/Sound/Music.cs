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
    |	Name: [Music.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Represents a music in the system.
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

    public class Music
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private string _name;
        private string _path;
        private string _type;

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
                if (obj is Music)
                {
                    Music compMusic = (Music)obj;

                    if (this._name == compMusic._name && this._path == compMusic.path)
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
    }
}
