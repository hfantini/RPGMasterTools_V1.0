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

    public abstract class CClass
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private string _name = "";
        private EnumDice _lifeDice;
        private EnumCharacterStat _mainStat;
        private List<EnumCharacterStat> _saveStats = new List<EnumCharacterStat>();
        private Bitmap _icon = RPGMasterTools.Properties.Resources.ico_class_none;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CClass(String className, EnumDice lifeDice, EnumCharacterStat mainStat, List<EnumCharacterStat> saveStats, Bitmap icon)
        {
            this._name = className;
            this._lifeDice = lifeDice;
            this._mainStat = mainStat;
            this._saveStats = saveStats;
            this._icon = icon;
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public string name
        {
            get { return ULanguage.getStringCurrentLanguage(this._name); }
        }

        public Bitmap icon
        {
            get { return this._icon; }
        }

        public EnumDice lifeDice
        {
            get { return _lifeDice; }
        }
    }
}
