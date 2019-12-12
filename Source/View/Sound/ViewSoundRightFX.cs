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
    |	Name: [ViewSoundRightFX.cs]
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
using RPGMasterTools.Source.Interface;
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

    public partial class ViewSoundRightFX : UserControl, IComponent<EnumStateSoundRightFX>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private SoundRightFXController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightFX()
        {
            InitializeComponent();
        }

        public ViewSoundRightFX(GenericController parentController)
        {
            InitializeComponent();

            // INITIALIZE VALUES

            // CREATE CONTROLLER

            this._controller = new SoundRightFXController(this, parentController);

            // CONFIGURE COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightFX lastState, EnumStateSoundRightFX currentState)
        {
            if(currentState == EnumStateSoundRightFX.STATE_UPDATE_LIST_ADD)
            {
                this.updateListOfSoundFX();
            }
            else if (currentState == EnumStateSoundRightFX.STATE_UPDATE_LIST_REMOVE)
            {
                updateRemoveSFXList();
            }
            else if (currentState == EnumStateSoundRightFX.STATE_PRESET_LOADED)
            {
                this.recreateListOfSoundFX();
            }
            else if (currentState == EnumStateSoundRightFX.STATE_MASTER_VOLUME_CHANGED)
            {
                lblVolume.Text = this._controller.masterVolumeFX + "%";
                tBarMasterVolume.Value = this._controller.masterVolumeFX / 10;
            }
        }

        private void updateRemoveSFXList()
        {
            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<ViewSoundRightFXPlayer> removeList = new List<ViewSoundRightFXPlayer>();

            int idRegen = 0;

            // CHECK THE CHANGES

            foreach (ViewSoundRightFXPlayer currentControl in fLayoutSFX.Controls)
            {
                if (!controller.soundFXPlaylist.Contains(currentControl.controller.currentSFX))
                {
                    currentControl.controller.currentState = EnumStateSoundRightFXPlayer.STATE_REMOVE;
                    removeList.Add(currentControl);
                }
                else
                {
                    idRegen++;
                    currentControl.id = idRegen;
                }
            }

            // REMOVE CONTROLS

            foreach (ViewSoundRightFXPlayer currentControl in removeList)
            {
                currentControl.Dispose();
            }
        }

        private void updateListOfSoundFX()
        {
            SoundController sController = (SoundController) this._controller.parentController.parentController;
            List<SoundFX> currentSFXList = sController.soundFXPlaylist;
            List<SoundFX> lastChangeList = sController.soundFXLastChange;

            for (int count = 0; count < lastChangeList.Count; count++)
            {
                SoundFX sfx = lastChangeList[count];

                ViewSoundRightFXPlayer sfxPlayer = new ViewSoundRightFXPlayer(currentSFXList.Count + count, this._controller, sfx);
                sfxPlayer.Width = fLayoutSFX.Width;

                fLayoutSFX.Controls.Add(sfxPlayer);
            }

            lastChangeList.Clear();
        }

        private void recreateListOfSoundFX()
        {
            UComponent.removeAllChildren(this.fLayoutSFX);

            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<SoundFX> sfxPlaylist = controller.soundFXPlaylist;
 
            for (int count = 0; count < sfxPlaylist.Count; count++)
            {
                SoundFX sfx = sfxPlaylist[count];

                ViewSoundRightFXPlayer aPlayer = new ViewSoundRightFXPlayer(count + 1, this._controller, sfx);
                aPlayer.Width = fLayoutSFX.Width;

                fLayoutSFX.Controls.Add(aPlayer);
            }
        }

        private void tBarMasterVolume_Scroll(object sender, EventArgs e)
        {
            int value = tBarMasterVolume.Value * 10;
            this.lblVolume.Text = value + "%";
            this._controller.masterVolumeFX = value;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
