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
    |	Name: [ULog.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a class who provides ways to handle
    |   with system log.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Log;
using System;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class ULog
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static void writeLog(EnumLogLevel level, EnumLogType type, string message)
        {
            Console.Out.WriteLine(message);
        }

        public static void writeLog( EnumLogType type, string message )
        {
            ULog.writeLog(EnumLogLevel.LEVEL_NORMAL, type, message);
        }

        public static void writeLog( string message )
        {
            ULog.writeLog(EnumLogLevel.LEVEL_NORMAL, EnumLogType.TYPE_NORMAL, message);
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
