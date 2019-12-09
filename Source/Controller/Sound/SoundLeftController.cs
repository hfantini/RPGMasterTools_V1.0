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
    |	Name: [SoundLeftController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Controller of SoundLeftPanel
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    public class SoundLeftController : ComponentController<EnumStateSoundLeft>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private BackgroundWorker _bwLoad = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundLeftController(IComponent<EnumStateSoundLeft> component, GenericController parentController) : base(component, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            if(this.currentState == EnumStateSoundLeft.STATE_NONE)
            {
                throw new EMasterToolsInvalidStateChangeException();
            }
            else if(this.currentState == EnumStateSoundLeft.STATE_LOADING)
            {
                if (this.lastState == EnumStateSoundLeft.STATE_NONE)
                {
                    this._bwLoad = new BackgroundWorker();
                    this._bwLoad.DoWork += loadTask;
                    this._bwLoad.RunWorkerCompleted += onLoadTaskFinished;

                    this._bwLoad.RunWorkerAsync();
                }
                else
                {
                    throw new EMasterToolsInvalidStateChangeException();
                }
            }
            else
            {

            }

            base.update();
        }

        private JObject scanDirectory(String path, String fileType)
        {
            JObject retValue = new JObject();

            if ( Directory.Exists( path ) )
            {
                // LOOKING FOR DESCRIPTOR.JSON
                JObject descriptor = null;
                string descriptorPath = path + "\\descriptor.json";

                if (File.Exists(descriptorPath) )
                {
                    JsonSerializer serializer = new JsonSerializer();
                    StreamReader sReader = new StreamReader(descriptorPath);

                    descriptor = (JObject) serializer.Deserialize( new JsonTextReader(sReader) );

                    // SEARCH AUDIO FILES IN THE DIRECTORY

                    string[] files = Directory.GetFiles(path, "*.mp3");
                    JArray fileArray = new JArray();

                    foreach( String file in files )
                    {
                        FileInfo fInfo = new FileInfo(file);

                        JObject jsonFileInfo = new JObject();
                        jsonFileInfo.Add("NAME", fInfo.Name);
                        jsonFileInfo.Add("TYPE", fileType);
                        jsonFileInfo.Add("PATH", path);

                        fileArray.Add(jsonFileInfo);
                    }

                    descriptor.Add("FILES", fileArray);

                    // SCANING SUBFOLDERS

                    JArray children = new JArray();
                    string[] directories = Directory.GetDirectories(path);

                    foreach( String directory in directories)
                    {
                        children.Add( scanDirectory(directory, fileType) );
                    }

                    descriptor.Add("CHILDREN", children);

                    // ATTACHING COLLETED INFO TO RETURN

                    retValue = descriptor;
                    sReader.Close();
                }
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        private void loadTask(object sender, DoWorkEventArgs e)
        {
            JArray loadResult = new JArray();

            // SCANNING FOR MUSIC
            loadResult.Add( scanDirectory( UFileIO.getAssetFolderPath() + "\\music", "MUSIC") );

            // SCANNING FOR AMBIENCE
            loadResult.Add( scanDirectory(UFileIO.getAssetFolderPath() + "\\ambience", "AMBIENCE") );

            // SCANING FOR SOUNDFX
            loadResult.Add( scanDirectory(UFileIO.getAssetFolderPath() + "\\soundfx", "SOUNDFX") );

            ((SoundController)this.parentController).assetsFromTheDisk = loadResult;
        }

        private void onLoadTaskFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            this.currentState = EnumStateSoundLeft.STATE_REFRESH;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
