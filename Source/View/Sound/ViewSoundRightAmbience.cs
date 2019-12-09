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
    |	Name: [ViewSoundRightAmbience.cs]
    |	Type: [VIEW]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Model.Sound;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightAmbience : UserControl, Interface.IComponent<EnumStateSoundRightAmbience>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private SoundRightAmbienceController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightAmbience()
        {
            InitializeComponent();
        }

        public ViewSoundRightAmbience(GenericController parentController)
        {
            InitializeComponent();

            // CONFIGURING COMPONENTS

            // CONFIGURING CONTROLLER

            this._controller = new SoundRightAmbienceController(this, parentController);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightAmbience lastState, EnumStateSoundRightAmbience currentState)
        {
            if (currentState == EnumStateSoundRightAmbience.STATE_UPDATE_LIST)
            {
                updateAmbienceList();
                this._controller.currentState = lastState;
            }
        }


        private void updateAmbienceList()
        {
            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<Ambience> lastChangeList = controller.ambienceLastChange;

            for (int count = 0; count < lastChangeList.Count; count++)
            {
                Ambience ambience = lastChangeList[count];

                ViewSoundRightAmbiencePlayer aPlayer = new ViewSoundRightAmbiencePlayer(this._controller, ambience);
                aPlayer.Width = fLayoutAmbience.Width;

                fLayoutAmbience.Controls.Add(aPlayer);
            }

            lastChangeList.Clear();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
