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

        private string DEFAULT_DISPLAY_TIMER = "[00:00 / 00:00]";

        // -- VAR -------------------------------------------------------

        private SoundRightMusicPlayerController _controller = null;
        private System.Timers.Timer _timer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusicPlayer()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusicPlayer(GenericController parentController)
        {
            InitializeComponent();

            // INITIALIZE VALUES
            this._timer = new System.Timers.Timer();
            this._timer.Interval = 250;
            this._timer.Elapsed += OnTimedEvent;

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
                    this.btnBack.Enabled = false;
                    this.btnNext.Enabled = false;

                    this._timer.Enabled = false;
                    lblDisplayTiming.Text = DEFAULT_DISPLAY_TIMER;
                }
                else if (state == EnumStateSoundRightMusic.STATE_PLAYING)
                {
                    Music currentMusic = ((SoundRightMusicController)this._controller.parentController).currentMusic;

                    if (currentMusic != null)
                    {
                        lblDisplayInfo.Text = currentMusic.name;

                        // CHANGE IMAGES
                        this.btnPausePlay.BackgroundImage = Properties.Resources.ico_pause;
                        this.pBoxPlayerDisplayIcon.Image = Properties.Resources.ico_play_display;

                        // TRIGGER UPDATE ASYNC TIMER
                        this._timer.Enabled = true;

                        // CHANGE BUTTON STATE
                        this.btnBack.Enabled = true;
                        this.btnNext.Enabled = true;
                    }
                }
                else if (state == EnumStateSoundRightMusic.STATE_PAUSED)
                {
                    lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.PAUSED");
                    this.btnPausePlay.BackgroundImage = Properties.Resources.ico_play;
                    this.pBoxPlayerDisplayIcon.Image = Properties.Resources.ico_pause_display;
                    this.btnBack.Enabled = false;
                    this.btnNext.Enabled = false;

                    this._timer.Enabled = false;
                }
                else if (state == EnumStateSoundRightMusic.STATE_IDLE)
                {
                    lblDisplayInfo.Text = ULanguage.getStringCurrentLanguage("SOUND.RIGHT.MUSIC.WAITING_FOR_PLAY");
                    this.btnPausePlay.BackgroundImage = Properties.Resources.ico_play;
                    this.pBoxPlayerDisplayIcon.Image = Properties.Resources.ico_stop_display;
                    this.btnBack.Enabled = false;
                    this.btnNext.Enabled = false;

                    this._timer.Enabled = false;
                    lblDisplayTiming.Text = DEFAULT_DISPLAY_TIMER;
                }
                else if (state == EnumStateSoundRightMusic.STATE_OPTION_UPDATE || state == EnumStateSoundRightMusic.STATE_PRESET_LOADED) 
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

                    // VOLUME
                    lblVolume.Text = pController.volume + "%";
                    int vValue = pController.volume / 10;
                    tbrVolume.Value = vValue;
                }
                else if (state == EnumStateSoundRightMusic.STATE_MEDIA_END)
                {
                    this._timer.Enabled = false;
                }
                else
                {
                    this._timer.Enabled = false;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                SoundRightMusicController controller = ((SoundRightMusicController)this._controller.parentController);

                string currentTime = controller.currentMusicPositionTime;
                string totalTime = controller.totalMusicTime;
                WMPLib.WMPPlayState pState = controller.wmpIsPlaying;

                if (pState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    lblDisplayTiming.Invoke(new Action(() =>
                    {
                        lblDisplayTiming.Text = $"[{currentTime} / {totalTime}]";
                    }));
                }
                else if (pState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    this.Invoke(new Action(() =>
                  {
                      controller.currentState = EnumStateSoundRightMusic.STATE_MEDIA_END;
                  }));
                }
            }
            catch(Exception ex)
            {
                ULog.writeLog(ex.Message);
            }
        }

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

            controller.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;
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

            controller.currentState = EnumStateSoundRightMusic.STATE_OPTION_UPDATE;
        }

        private void tbrVolume_Scroll(object sender, EventArgs e)
        {
            int value = tbrVolume.Value * 10;
            lblVolume.Text = Convert.ToString(value) + "%";

            // SEND VALUE TO PLAYER
            ( (SoundRightMusicController) this._controller.parentController).volume = value;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public SoundRightMusicPlayerController controller
        {
            get { return this._controller; }
        }
    }
}
