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
    |	Name: [UExceptionHandler.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a class who provides ways to handle
    |   with system errors.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Model.Exception;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class UExceptionHandler
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static void handleWithException(Exception e)
        {
            EMasterToolsException currentException = null;

            // EXCEPTION CONVERTION

            if( !(e is EMasterToolsException) )
            {
                currentException = new EMasterToolsException(e);
            }
            else
            {
                currentException = (EMasterToolsException) e;
            }

            if (currentException.type == Enumeration.Exception.ExceptionType.TYPE_WARNING || currentException.type == Enumeration.Exception.ExceptionType.TYPE_ERROR)
            {
                var stackTrace = new StackTrace(e, true);
                StackFrame frame = stackTrace.GetFrame(0);

                string msg = "AN ERROR OCCURED: \n\n "
                             + e.Message;

                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var stackTrace = new StackTrace(e, true);
                StackFrame frame = stackTrace.GetFrame(0);

                string msg = "AN ERROR OCCURED: \n\n "
                             + e.Message + "\n\n\n"
                             + "AT " + frame.GetMethod();

                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
