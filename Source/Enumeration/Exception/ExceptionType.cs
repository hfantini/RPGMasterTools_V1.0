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
    |	Name: [ExceptionType.cs]
    |	Type: [ENUM]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines all type of system exceptions
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Enumeration.Exception
{
    // == ENUM
    // ==============================================================

    [DefaultValue(TYPE_FATAL)]
    public enum ExceptionType
    {
        TYPE_FATAL,
        TYPE_ERROR,
        TYPE_WARNING
    }
}
