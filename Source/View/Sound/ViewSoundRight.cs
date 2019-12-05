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
    |	Name: [ViewSoundRight.cs]
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Controller.Sound;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRight : UserControl, RPGMasterTools.Source.Interface.IComponent<EnumStateSoundRight>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private ViewSoundRightMusic _viewSoundRightMusic = null;

        private SoundRightController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRight()
        {
            InitializeComponent();
        }

        public ViewSoundRight(GenericController controller)
        {
            InitializeComponent();

            // CONFIGURE CONTROLLER

            this._controller = new SoundRightController(this, controller);

            // CREATE COMPONENTS
            this._viewSoundRightMusic = new ViewSoundRightMusic(this._controller);

            // CONFIGURE COMPONENTS
            UComponent.applyLanguageToComponent(lblMusicTitle);
            UComponent.applyLanguageToComponent(lblAmbienceTitle);
            UComponent.applyLanguageToComponent(lblSoundFXTitle);

            this._viewSoundRightMusic.Dock = DockStyle.Fill;
            this._viewSoundRightMusic.Margin = new Padding(0);
            pnlMusicContent.Controls.Add(this._viewSoundRightMusic);

        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRight lastState, EnumStateSoundRight currentState)
        {
            
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
