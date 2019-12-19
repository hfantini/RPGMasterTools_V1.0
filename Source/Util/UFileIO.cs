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
    |	Name: [UFileIO.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a Class who helps with File I/O
    |   operations
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

    public class UFileIO
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private static Assembly _assembly = Assembly.GetExecutingAssembly();
        private static string _defaultNamespace = "RPGMasterTools";

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static Stream getEmbeddedResourceStream( String name )
        {
            return UFileIO._assembly.GetManifestResourceStream( UFileIO._defaultNamespace + "." + name );
        }

        public static String getAssetFolderPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "assets";
        }

        public static string getUserCustomPresetFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "assets\\preset\\user";
        }

        public static void writeJsonToFile( string path, JObject content )
        {
            StreamWriter sWriter = File.CreateText(path);

            String value = JsonConvert.SerializeObject(content, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            sWriter.WriteLine(value);
            sWriter.Close();
        }

        public static JObject loadJsonFromFile( string path )
        {
            JObject retValue = null;

            retValue = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(path));

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
