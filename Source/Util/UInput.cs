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
    |	Name: [UInput]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Provide methods to handle with input.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Model.Sys;
using System;
using System.Collections.Generic;
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

    public class UInput
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static Int32 getNumberFromKey(Hotkey hotkey)
        {
            Int32 retValue = -1;

            switch(hotkey.key)
            {
                case Keys.D0:
                    retValue = 0;
                    break;

                case Keys.D1:
                    retValue = 1;
                    break;

                case Keys.D2:
                    retValue = 2;
                    break;

                case Keys.D3:
                    retValue = 3;
                    break;

                case Keys.D4:
                    retValue = 4;
                    break;

                case Keys.D5:
                    retValue = 5;
                    break;

                case Keys.D6:
                    retValue = 6;
                    break;

                case Keys.D7:
                    retValue = 7;
                    break;

                case Keys.D8:
                    retValue = 8;
                    break;

                case Keys.D9:
                    retValue = 9;
                    break;

                case Keys.NumPad0:
                    retValue = 0;
                    break;

                case Keys.NumPad1:
                    retValue = 1;
                    break;

                case Keys.NumPad2:
                    retValue = 2;
                    break;

                case Keys.NumPad3:
                    retValue = 3;
                    break;

                case Keys.NumPad4:
                    retValue = 4;
                    break;

                case Keys.NumPad5:
                    retValue = 5;
                    break;

                case Keys.NumPad6:
                    retValue = 6;
                    break;

                case Keys.NumPad7:
                    retValue = 7;
                    break;

                case Keys.NumPad8:
                    retValue = 8;
                    break;

                case Keys.NumPad9:
                    retValue = 9;
                    break;
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
