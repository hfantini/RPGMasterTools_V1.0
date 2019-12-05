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

        private SoundLeftController _controller;

        private BackgroundWorker bwUpdateLoad = null;
        private int updateTimerCount = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundLeft( GenericController genericController )
        {
            InitializeComponent();

            this._controller = new SoundLeftController(this, genericController);
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
            else
            {
                if(currentState == EnumStateSoundLeft.STATE_READY)
                {
                    lblStatus.Text = ULanguage.getStringCurrentLanguage("GENERAL.READY");
                }
            }
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
                    lblStatus.Text = text + " " + this._controller.counter;
                }));

                this.updateTimerCount++;
                Thread.Sleep(500);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
