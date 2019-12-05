﻿/*

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
    |	Name: [SoundController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Sound controller class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundController : ComponentController<EnumStateSound>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private JArray _assetsFromTheDisk = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundController(IComponent<EnumStateSound> component, GenericController controller) : base(component, controller)
        {

        }

        // == METHODS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================]

        public JArray assetsFromTheDisk
        {
            get { return this._assetsFromTheDisk; }
            set { this._assetsFromTheDisk = value; }
        }
    }
}
