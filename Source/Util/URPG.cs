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
    |	Name: [URPG.cs]
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
using RPGMasterTools.Source.Enumeration.RPG.DND5E;
using RPGMasterTools.Source.Model.RPG.DND5E;
using System;
using System.Drawing;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class URPG
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static Bitmap getClassIcon( PClass clazz )
        {
            Bitmap retValue = null;

            if (clazz != null)
            {
                switch (clazz.clazz)
                {
                    case EnumCharacterClass.BARBARIAN:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_barbarian;
                        break;

                    case EnumCharacterClass.BARD:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_bard;
                        break;

                    case EnumCharacterClass.CLERIC:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_priest;
                        break;

                    case EnumCharacterClass.DRUID:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_druid;
                        break;

                    case EnumCharacterClass.FIGHTER:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_warrior;
                        break;

                    case EnumCharacterClass.MONK:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_monk;
                        break;

                    case EnumCharacterClass.PALADIN:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_paladin;
                        break;

                    case EnumCharacterClass.RANGER:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_hunter;
                        break;

                    case EnumCharacterClass.ROGUE:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_rogue;
                        break;

                    case EnumCharacterClass.SORCERER:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_sorcerer;
                        break;

                    case EnumCharacterClass.WARLOCK:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_warlock;
                        break;

                    case EnumCharacterClass.WIZARD:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_mage;
                        break;

                    default:
                        retValue = RPGMasterTools.Properties.Resources.ico_class_none;
                        break;
                }
            }
            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
