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
    |	Name: [ULanguage.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines an class that provides a multilang
    |   system.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Model.Language;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class ULanguage
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private static List<MLanguage> _availableLanguageList = new List<MLanguage>( new MLanguage[] 
            {
                new MLanguage("English/US", "enUS.json"),
                new MLanguage("Português/BR", "ptBR.json")
            } 
        );

        private static MLanguage _currentLanguage = ULanguage._availableLanguageList[1];
        private static Dictionary<MLanguage, JObject> _loadedLanguageStructure = new Dictionary<MLanguage, JObject>();

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        private static JObject loadLanguageStrings(MLanguage language)
        {
            if (!ULanguage._loadedLanguageStructure.ContainsKey(language))
            {
                Stream stream = UFileIO.getEmbeddedResourceStream("Resources.Strings." + language.stringsFileName);
                StreamReader sReader = new StreamReader(stream);

                JsonSerializer serializer = new JsonSerializer();                
                JObject languageStrings = (JObject) serializer.Deserialize( new JsonTextReader( sReader ) );

                ULanguage._loadedLanguageStructure.Add(language, languageStrings);
            }

            return ULanguage._loadedLanguageStructure[language];
        }

        public static string getString( MLanguage language, string key )
        {
            JObject stringSet = loadLanguageStrings(language);
            return stringSet.SelectToken(key).ToString();
        }

        public static string getStringCurrentLanguage( string key )
        {
            return getString(ULanguage._currentLanguage, key);
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
