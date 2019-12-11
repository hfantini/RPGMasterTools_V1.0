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
    |	Name: [EMasterToolsPresetException.cs]
    |	Type: [EXCEPTION]
    |	Author: Henrique Fantini
    |	
    |	Description: -
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

    public class EMasterToolsPresetException : EMasterToolsException
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public EMasterToolsPresetException(System.Exception e) : base(e, ExceptionType.TYPE_FATAL, e.Message)
        {

        }

        public EMasterToolsPresetException(string message) : base(null, ExceptionType.TYPE_FATAL, message)
        {

        }

        public EMasterToolsPresetException(System.Exception e, string message) : base(e, ExceptionType.TYPE_FATAL, message)
        {
         
        }

        public EMasterToolsPresetException(System.Exception e, ExceptionType type, string message) : base(e, type, message)
        {

        }

        // == METHODS
        // ==============================================================
    }
}
