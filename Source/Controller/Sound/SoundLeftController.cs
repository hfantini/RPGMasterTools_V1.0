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

using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private BackgroundWorker bwLoad = null;
        public int counter = 0;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundLeftController(IComponent<EnumStateSoundLeft> component, GenericController parentController) : base(component, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        public override void update()
        {
            if(this.currentState == EnumStateSoundLeft.STATE_NONE)
            {
                throw new EMasterToolsInvalidStateChangeException();
            }
            else if(this.currentState == EnumStateSoundLeft.STATE_LOADING)
            {
                if (this.lastState == EnumStateSoundLeft.STATE_NONE)
                {
                    bwLoad = new BackgroundWorker();
                    bwLoad.DoWork += loadTask;
                    bwLoad.RunWorkerCompleted += onLoadTaskFinished;

                    bwLoad.RunWorkerAsync();
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

        private void loadTask(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }

        // == EVENTS
        // ==============================================================

        private void onLoadTaskFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            this.currentState = EnumStateSoundLeft.STATE_READY;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
