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
    |	Name: [EMasterToolsStateException.cs]
    |	Type: [EXCEPTION]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a generic system exception.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Exception;
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

    public class EMasterToolsInvalidStateChangeException : EMasterToolsException
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        private const string MESSAGE = "Invalid State Change.";

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public EMasterToolsInvalidStateChangeException() : base(null, ExceptionType.TYPE_WARNING, MESSAGE)
        {

        }

        public EMasterToolsInvalidStateChangeException(string message) : base(null, ExceptionType.TYPE_WARNING, message)
        {

        }

        public EMasterToolsInvalidStateChangeException(System.Exception e, string message) : base(e, ExceptionType.TYPE_WARNING, message)
        {

        }

        // == METHODS
        // ==============================================================
    }
}
