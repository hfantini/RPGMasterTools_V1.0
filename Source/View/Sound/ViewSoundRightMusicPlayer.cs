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
    |	Name: [ViewSoundRightMusicPlayer]
    |	Type: [VIEW]
    |	Author: Henrique Fantini
    |	
    |	Description:
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
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Model.Sound;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightMusicPlayer : UserControl, Interface.IComponent<EnumStateSoundRightMusicPlayer>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private SoundRightMusicPlayerController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusicPlayer()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusicPlayer(GenericController parentController)
        {
            InitializeComponent();

            // CONFIGURE CONTROLLER
            this._controller = new SoundRightMusicPlayerController(this, parentController);

            // CONFIGURE COMPONENTS
            lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.WAITING_FOR_PLAY");
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightMusicPlayer lastState, EnumStateSoundRightMusicPlayer currentState)
        {
            if (currentState == EnumStateSoundRightMusicPlayer.STATE_UPDATE)
            {
                // WATCH FOR PARENT CONTROLLER STATE

                SoundRightMusicController pController = ((SoundRightMusicController)this._controller.parentController);
                EnumStateSoundRightMusic state = pController.currentState;

                if (state == EnumStateSoundRightMusic.STATE_NOTHING_TO_PLAY)
                {
                    lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.NOTHING_TO_PLAY");
                }
                else if (state == EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    Music currentMusic = ((SoundRightMusicController)this._controller.parentController).currentMusic;

                    if (currentMusic != null)
                    {
                        lblDisplayInfo.Text = currentMusic.name;

                        // CHANGE BUTTON IMAGE
                        this.btnPausePlay.BackgroundImage = Properties.Resources.ico_pause;
                    }
                }
                else if (state == EnumStateSoundRightMusic.STATE_PAUSED)
                {
                    lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.PAUSED");
                    this.btnPausePlay.BackgroundImage = Properties.Resources.ico_play;
                }
                else if (state == EnumStateSoundRightMusic.STATE_IDLE)
                {
                    lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.WAITING_FOR_PLAY");
                    this.btnPausePlay.BackgroundImage = Properties.Resources.ico_play;
                }
                else if (state == EnumStateSoundRightMusic.STATE_OPTION_UPDATE)
                {
                    // REPEAT

                    if (pController.repeat)
                    {
                        btnRepeat.BackColor = SystemColors.ControlDark;
                    }
                    else
                    {
                        btnRepeat.BackColor = SystemColors.Control;
                    }

                    // RANDOM

                    if (pController.random)
                    {
                        btnRandom.BackColor = SystemColors.ControlDark;
                    }
                    else
                    {
                        btnRandom.BackColor = SystemColors.Control;
                    }
                }

                // RETURNS TO IDLE STATE

                this._controller.currentState = EnumStateSoundRightMusicPlayer.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        private void btnPlay_Click(object sender, EventArgs e)
        {
            EnumStateSoundRightMusic state = ((SoundRightMusicController)this._controller.parentController).currentState;

            if (state == EnumStateSoundRightMusic.STATE_IDLE || state == EnumStateSoundRightMusic.STATE_NONE)
            {
                ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_PLAY;
            }
            else if (state == EnumStateSoundRightMusic.STATE_PAUSED)
            {
                ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_RESUME;
            }
            else if (state == EnumStateSoundRightMusic.STATE_PLAYING)
            {
                ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_PAUSE;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_STOP;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_NEXT;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((SoundRightMusicController)this._controller.parentController).currentState = EnumStateSoundRightMusic.STATE_BACK;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            SoundRightMusicController controller = (SoundRightMusicController) this._controller.parentController;

            if(controller.repeat)
            {
                controller.repeat = false;
            }
            else
            {
                controller.repeat = true;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            SoundRightMusicController controller = (SoundRightMusicController)this._controller.parentController;

            if (controller.random)
            {
                controller.random = false;
            }
            else
            {
                controller.random = true;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
