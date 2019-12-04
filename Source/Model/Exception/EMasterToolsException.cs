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
    |	Name: [EMasterToolsException.cs]
    |	Type: [EXCEPTION]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a generic system exception.
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


namespace RPGMasterTools.Source.Model.Exception
{
    // == CLASS
    // ==============================================================

    public class EMasterToolsException : System.Exception
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public EMasterToolsException() : base()
        {

        }

        public EMasterToolsException(String message) : base(message)
        {

        }

        // == METHODS
        // ==============================================================
    }
}
