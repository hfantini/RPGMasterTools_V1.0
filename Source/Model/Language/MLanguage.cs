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
    |	Name: [MLanguage]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Define a language supported by the system.
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

namespace RPGMasterTools.Source.Model.Language
{
    // == CLASS
    // ==============================================================

    public class MLanguage
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private string _name;
        private string _stringsFileName;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public MLanguage( string name, string stringsFileName )
        {
            this._name = name;
            this._stringsFileName = stringsFileName;
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public string name
        {
            get { return this._name; }
        }

        public string stringsFileName
        {
            get { return this._stringsFileName; }
        }
    }
}
