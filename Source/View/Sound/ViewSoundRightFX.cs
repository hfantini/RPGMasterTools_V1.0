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

            }
            else if (currentState == EnumStateSoundRightFX.STATE_UPDATE_LIST_REMOVE)
            {

            }
        }

        private void updateListOfSoundFX()
        {
            SoundController sController = (SoundController) this._controller.parentController;
            List<SoundFX> lastChangeList = sController.soundFXLastChange;

            for (int count = 0; count < lastChangeList.Count; count++)
            {
                SoundFX sfx = lastChangeList[count];

                //ViewSoundRightAmbiencePlayer aPlayer = new ViewSoundRightAmbiencePlayer(this._controller, ambience);
                //aPlayer.Width = fLayoutAmbience.Width;

                //fLayoutAmbience.Controls.Add(aPlayer);
            }

            lastChangeList.Clear();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
