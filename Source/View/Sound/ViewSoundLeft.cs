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
    |	Name: [ViewSoundLeft.cs]
    |	Type: [VIEW]
    |	Author: Henrique Fantini
    |	
    |	Description: Left panel of sound system.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// =========================A=========================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundLeft : UserControl, RPGMasterTools.Source.Interface.IComponent<EnumStateSoundLeft>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private ViewSoundLeftDetailEmpty _viewSoundLeftDetailEmpty;
        private ViewSoundLeftDetailFolder _viewSoundLeftDetailFolder;
        private ViewSoundLeftDetailFile _viewSoundLeftDetailFile;

        private SoundLeftController _controller;

        private BackgroundWorker bwUpdateLoad = null;
        private BackgroundWorker bwUpdateRefresh = null;
        private int updateTimerCount = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundLeft( GenericController genericController )
        {
            InitializeComponent();

            // COMPONENT CREATION
            this._viewSoundLeftDetailEmpty = new ViewSoundLeftDetailEmpty();
            this._viewSoundLeftDetailEmpty.Dock = DockStyle.Fill;

            this._viewSoundLeftDetailFolder = new ViewSoundLeftDetailFolder();
            this._viewSoundLeftDetailFolder.Dock = DockStyle.Fill;

            this._viewSoundLeftDetailFile = new ViewSoundLeftDetailFile();
            this._viewSoundLeftDetailFile.Dock = DockStyle.Fill;

            // COMPONENT CONFIGURATION

            UComponent.applyLanguageToComponent(grpDetail);

            tViewData.AfterSelect += onNodeSelect;
            tViewData.NodeMouseDoubleClick += onNodeDoubleClick;

            // CONTROLLER CONFIGURATION

            this._controller = new SoundLeftController(this, genericController);

            // UPDATES
            updateNodeInfo();
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundLeft lastState, EnumStateSoundLeft currentState)
        {
            if(currentState == EnumStateSoundLeft.STATE_NONE)
            {
                throw new EMasterToolsInvalidStateChangeException();
            }
            else if(currentState == EnumStateSoundLeft.STATE_LOADING)
            {
                if( lastState == EnumStateSoundLeft.STATE_NONE )
                {
                    bwUpdateLoad = new BackgroundWorker();
                    bwUpdateLoad.DoWork += updateLoad;
                    bwUpdateLoad.WorkerSupportsCancellation = true;

                    bwUpdateLoad.RunWorkerAsync();
                }
                else
                {
                    throw new EMasterToolsInvalidStateChangeException();
                }
            }
            else if (currentState == EnumStateSoundLeft.STATE_REFRESH)
            {
                bwUpdateRefresh = new BackgroundWorker();
                bwUpdateRefresh.DoWork += updateRefresh;
                bwUpdateRefresh.RunWorkerCompleted += onRefreshTaskFinished;

                bwUpdateRefresh.RunWorkerAsync();
            }   
            else if (currentState == EnumStateSoundLeft.STATE_EXPAND_ALL)
            {
                tViewData.ExpandAll();
                this._controller.currentState = EnumStateSoundLeft.STATE_READY;
            }
            else if (currentState == EnumStateSoundLeft.STATE_COLLAPSE_ALL)
            {
                tViewData.CollapseAll();
                this._controller.currentState = EnumStateSoundLeft.STATE_READY;

                // LET ONLY THE FIRST NODE EXPANDED
                tViewData.Nodes[0].Expand();
            }
            else if (currentState == EnumStateSoundLeft.STATE_READY)
            {
                lblStatus.Text = ULanguage.getStringCurrentLanguage("GENERAL.READY");
            }
        }

        private void insertNodeRecursively(TreeNode currentNode, JArray collection)
        {
            if (collection != null)
            {
                foreach (JObject obj in collection)
                {
                    tViewData.Invoke(new Action(() =>
                    {
                        currentNode.Nodes.Add(obj.GetValue("NAME").Value<String>());
                        var index = currentNode.Nodes.Count - 1;
                        currentNode.Nodes[index].Tag = obj;

                        // ADD CHILDREN

                        if (obj.ContainsKey("CHILDREN"))
                        {
                            JArray children = obj.Value<JArray>("CHILDREN");

                            if (children.Count > 0)
                            {
                                insertNodeRecursively(currentNode.Nodes[index], children);
                            }
                        }

                        // ADD FILES

                        if (obj.ContainsKey("FILES"))
                        {
                            JArray files = obj.Value<JArray>("FILES");

                            if (files.Count > 0)
                            {
                                foreach (JObject file in files)
                                {
                                    currentNode.Nodes[index].Nodes.Add(file.Value<String>("NAME") );
                                    var cIndex = currentNode.Nodes[index].Nodes.Count - 1;
                                    currentNode.Nodes[index].Nodes[cIndex].Tag = file;
                                }
                            }

                        }
                    }));
                }
            }
        }

        private void updateNodeInfo()
        {
            UComponent.removeAllChildren(grpDetail);
            TreeNode currentNode = tViewData.SelectedNode;          

            if (currentNode == null)
            {
                grpDetail.Controls.Add(this._viewSoundLeftDetailEmpty);
            }
            else
            {
                JObject info = (JObject) currentNode.Tag;

                if(info != null && info.ContainsKey("TYPE"))
                {
                    string iType = info.Value<String>("TYPE");

                    if(iType.ToUpper() == "FOLDER")
                    {
                        this._viewSoundLeftDetailFolder.update(info);
                        grpDetail.Controls.Add(this._viewSoundLeftDetailFolder);
                    }
                    else if (iType.ToUpper() == "PRESET")
                    {
                        grpDetail.Controls.Add(this._viewSoundLeftDetailEmpty);
                    }
                    else if (iType.ToUpper() == "MUSIC")
                    {
                        this._viewSoundLeftDetailFile.update(info);
                        grpDetail.Controls.Add(this._viewSoundLeftDetailFile);
                    }
                    else if (iType.ToUpper() == "AMBIENCE")
                    {
                        this._viewSoundLeftDetailFile.update(info);
                        grpDetail.Controls.Add(this._viewSoundLeftDetailFile);
                    }
                    else if (iType.ToUpper() == "SOUNDFX")
                    {
                        this._viewSoundLeftDetailFile.update(info);
                        grpDetail.Controls.Add(this._viewSoundLeftDetailFile);
                    }
                    else
                    {
                        grpDetail.Controls.Add(this._viewSoundLeftDetailEmpty);
                    }
                }
                else
                {
                    grpDetail.Controls.Add(this._viewSoundLeftDetailEmpty);
                }
            }
        }

        private void addSomethingToList()
        {
            TreeNode node = tViewData.SelectedNode;

            if (node != null && node.Tag != null && node.Tag is JObject && ((JObject)node.Tag).ContainsKey("TYPE"))
            {
                string type = getObjectType( ( (JObject) node.Tag ) );

                if (type == "MUSIC")
                {
                    ((SoundController)this._controller.parentController).addMusicToPlaylist(((JObject)node.Tag));
                }
                else if(type == "AMBIENCE")
                {
                    ((SoundController)this._controller.parentController).addAmbienceToPlaylist(((JObject)node.Tag));
                }
                else if (type == "SOUNDFX")
                {
                    ((SoundController)this._controller.parentController).addSFXToPlaylist(((JObject)node.Tag));
                }
                else if (type == "PRESET")
                {
                    ((SoundController)this._controller.parentController).loadPresetFromFile( ( (JObject) node.Tag) );
                }
                else if(type == "FOLDER")
                {
                    foreach (TreeNode cNode in node.Nodes)
                    {
                        if ( cNode.Tag != null && cNode.Tag is JObject && ( (JObject) cNode.Tag ).ContainsKey("TYPE"))
                        {
                            type = getObjectType(((JObject)cNode.Tag));

                            if (type == "MUSIC")
                            {
                                ((SoundController)this._controller.parentController).addMusicToPlaylist(((JObject)cNode.Tag));
                            }
                            else if (type == "AMBIENCE")
                            {
                                ((SoundController)this._controller.parentController).addAmbienceToPlaylist(((JObject)cNode.Tag));
                            }
                            else if (type == "SOUNDFX")
                            {
                                ((SoundController)this._controller.parentController).addSFXToPlaylist(((JObject)cNode.Tag));
                            }
                        }
                    }
                }
            }
        }

        private string getObjectType(JObject obj)
        {
            string retValue = null;

            if( obj.ContainsKey("TYPE") )
            {
                retValue = obj.Value<String>("TYPE");
            }

            return retValue;
        }

        private string getObjectFileType(JObject obj)
        {
            string retValue = null;

            if (obj.ContainsKey("FILETYPE"))
            {
                retValue = obj.Value<String>("FILETYPE");
            }

            return retValue;
        }

        // == EVENTS
        // ==============================================================

        private void ViewSoundLeft_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundLeft.STATE_LOADING;
        }

        public void updateLoad(object sender, DoWorkEventArgs e)
        {
            while ( this._controller.currentState == EnumStateSoundLeft.STATE_LOADING )
            {
                string text = ULanguage.getStringCurrentLanguage("GENERAL.LOADING");

                if (this.updateTimerCount > 4)
                {
                    this.updateTimerCount = 0;
                }

                for (int count = 0; count < this.updateTimerCount; count++)
                {
                    text += ".";
                }

                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.Text = text;
                }));

                this.updateTimerCount++;
                Thread.Sleep(500);
            }
        }

        private void updateRefresh(object sender, DoWorkEventArgs e)
        {
            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.Text = ULanguage.getStringCurrentLanguage("SOUND.LEFT.REFRESH");
            }));

            // CLEAR ALL NODES

            lblStatus.Invoke(new Action(() =>
            {
                tViewData.Nodes.Clear();
            }));

            JArray data = ((SoundController)this._controller.parentController).assetsFromTheDisk;

            tViewData.Invoke(new Action(() =>
            {
                tViewData.Nodes.Add("ALL MEDIA");
            }));

            insertNodeRecursively(tViewData.Nodes[0], data);

            // EXPANDING NODES
            tViewData.Invoke(new Action(() =>
            {
                tViewData.Nodes[0].Expand();
            }));
        }

        private void onRefreshTaskFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            this._controller.currentState = EnumStateSoundLeft.STATE_READY;
        }

        private void onNodeSelect(object sender, EventArgs e)
        {
            this.updateNodeInfo();
        }

        private void onNodeDoubleClick(object sender, EventArgs e)
        {
            this.addSomethingToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundLeft.STATE_REFRESH;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundLeft.STATE_EXPAND_ALL;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundLeft.STATE_COLLAPSE_ALL;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
