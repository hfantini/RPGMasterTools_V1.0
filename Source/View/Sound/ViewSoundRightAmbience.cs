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
using RPGMasterTools.Source.Util;

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
            if (currentState == EnumStateSoundRightAmbience.STATE_UPDATE_LIST_ADD)
            {
                updateAmbienceList();
            }
            else if (currentState == EnumStateSoundRightAmbience.STATE_UPDATE_LIST_REMOVE)
            {
                updateRemoveAmbienceList();
            }
            else if (currentState == EnumStateSoundRightAmbience.STATE_PRESET_LOADED)
            {
                recreateAmbienceList();
            }
            else if(currentState == EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE)
            {
                //UPDATE VOLUME CONTROL
                tBarMasterVolume.Value = (this._controller.masterVolume / 10);
                lblVolume.Text = this._controller.masterVolume + "%";
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

        private void updateRemoveAmbienceList()
        {
            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<ViewSoundRightAmbiencePlayer> removeList = new List<ViewSoundRightAmbiencePlayer>();

            // CHECK THE CHANGES

            foreach( ViewSoundRightAmbiencePlayer currentControl in fLayoutAmbience.Controls )
            {
                if( !controller.ambiencePlaylist.Contains(currentControl.controller.currentAmbience) )
                {
                    currentControl.controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_REMOVE;
                    removeList.Add(currentControl);
                }
            }

            // REMOVE CONTROLS

            foreach (ViewSoundRightAmbiencePlayer currentControl in removeList)
            {
                currentControl.Dispose();
            }
        }

        private void recreateAmbienceList()
        {
            UComponent.removeAllChildren(this.fLayoutAmbience);

            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<Ambience> ambiencePlaylist = controller.ambiencePlaylist;

            for (int count = 0; count < ambiencePlaylist.Count; count++)
            {
                Ambience ambience = ambiencePlaylist[count];

                ViewSoundRightAmbiencePlayer aPlayer = new ViewSoundRightAmbiencePlayer(this._controller, ambience);
                aPlayer.Width = fLayoutAmbience.Width;

                fLayoutAmbience.Controls.Add(aPlayer);
            }
        }

        private void tBarMasterVolume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = (tBarMasterVolume.Value * 10) + "%";
            this._controller.masterVolume = tBarMasterVolume.Value * 10;

            this._controller.currentState = EnumStateSoundRightAmbience.STATE_VOLUME_CHANGE;
        }

        private void btnMasterPlay_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightAmbience.STATE_PLAY;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightAmbience.STATE_PAUSE;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightAmbience.STATE_STOP;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
