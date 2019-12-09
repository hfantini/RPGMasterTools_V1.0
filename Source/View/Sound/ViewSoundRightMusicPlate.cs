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
    |	Name: [ViewSoundRightMusicPlate.cs]
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
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Controller.Sound;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightMusicPlate : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private SoundRightMusicController _controller = null;
        private Music _music = null;
        private EnumStateSoundRightMusicPlate _currentState = new EnumStateSoundRightMusicPlate();

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusicPlate()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusicPlate(SoundRightMusicController controller, Music music)
        {
            InitializeComponent();

            this._controller = controller;
            this._music = music;

            updateInfo();
        }

        // == METHODS
        // ==============================================================

        public void updateInfo()
        {
            if (this._music != null)
            {
                lblMscName.Text = this._music.name;
            }
        }

        public void setState(EnumStateSoundRightMusicPlate state)
        {
            this._currentState = state;

            if(this._currentState == EnumStateSoundRightMusicPlate.STATE_PLAYING)
            {
                pBoxImageStatus.Image = RPGMasterTools.Properties.Resources.ico_play;
                this.BackColor = SystemColors.InactiveCaption;
            }
            else if( this._currentState == EnumStateSoundRightMusicPlate.STATE_STOPPED )
            {
                pBoxImageStatus.Image = RPGMasterTools.Properties.Resources.ico_stop;
                this.BackColor = SystemColors.Control;
            }
            else if (this._currentState == EnumStateSoundRightMusicPlate.STATE_PAUSED)
            {
                pBoxImageStatus.Image = RPGMasterTools.Properties.Resources.ico_pause;
                this.BackColor = SystemColors.Control;
            }
        }

        private void ViewSoundRightMusicPlate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this._controller.jumpToMusic(this._music);
        }

        private void lblMscName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this._controller.jumpToMusic(this._music);
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // =============================================================
    }
}
