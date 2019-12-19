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
    |	Name: [CharacterClass]
    |	Type: [TYPE]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines the generic character class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

using Newtonsoft.Json;
using RPGMasterTools.Source.Enumeration.RPG;
using RPGMasterTools.Source.Enumeration.RPG.DND5E;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == IMPORTS
// ==================================================================

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG.DND5E
{

    // == CLASS
    // ==============================================================

    public class PClass
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        protected EnumCharacterClass _clazz;
        protected EnumDice _lifeDice;
        protected EnumCharacterStat _mainStat;
        protected List<EnumCharacterStat> _saveStats = new List<EnumCharacterStat>();

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public EnumCharacterClass clazz
        {
            get { return this._clazz; }
            set { this._clazz = value; }
        }

        public EnumDice lifeDice
        {
            get { return _lifeDice; }
            set { this._lifeDice = value; }
        }

        public EnumCharacterStat mainStat
        {
            get { return _mainStat; }
            set { this._mainStat = value; }
        }


        public List<EnumCharacterStat> saveStats
        {
            get { return this._saveStats; }
            set { this._saveStats = value; }
        }

    }
}
