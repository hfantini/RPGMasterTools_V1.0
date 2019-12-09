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
    |	Name: [ViewSoundRightAmbiencePlayer.cs]
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
using WMPLib;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightAmbiencePlayer : UserControl, IComponent<EnumStateSoundRightAmbiencePlayer>
    {
        // -- CONST -----------------------------------------------------

        private const string DEFAULT_DISPLAY_TIME = "[00:00 / 00:00]";

        // -- VAR -------------------------------------------------------

        private SoundRightAmbiencePlayerController _controller = null;
        private System.Timers.Timer _timer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightAmbiencePlayer()
        {
            InitializeComponent();
        }

        public ViewSoundRightAmbiencePlayer(GenericController parentController, Ambience ambience)
        {
            InitializeComponent();

            // INITIALIZING VALUES
            this._timer = new System.Timers.Timer();
            this._timer.Interval = 250;
            this._timer.Elapsed += OnTimedEvent;

            // CONFIGURING COMPONENTS

            lblDisplayInfo.Text = ambience.name;
            lblDisplayTiming.Text = DEFAULT_DISPLAY_TIME;

            // CONFIGURING CONTROLLER

            this._controller = new SoundRightAmbiencePlayerController(this, parentController, ambience);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightAmbiencePlayer lastState, EnumStateSoundRightAmbiencePlayer currentState)
        {
            if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_PLAY)
            {
                pBoxPlayerDisplayIcon.Image = RPGMasterTools.Properties.Resources.ico_play_display;
                btnPausePlay.BackgroundImage = RPGMasterTools.Properties.Resources.ico_pause;
            }
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_STOP)
            {
                pBoxPlayerDisplayIcon.Image = RPGMasterTools.Properties.Resources.ico_stop_display;
                btnPausePlay.BackgroundImage = RPGMasterTools.Properties.Resources.ico_play;
            }
            else if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_PAUSE)
            {
                pBoxPlayerDisplayIcon.Image = RPGMasterTools.Properties.Resources.ico_pause_display;
                btnPausePlay.BackgroundImage = RPGMasterTools.Properties.Resources.ico_play;
            }

            // TIMER

            if (currentState == EnumStateSoundRightAmbiencePlayer.STATE_PLAYING)
            {
                this._timer.Enabled = true;
            }
            else
            {
                this._timer.Enabled = false;
            }
        }

        // == EVENTS
        // ==============================================================

        private void ViewSoundRightAmbiencePlayer_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PLAY;
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (this._controller.currentState == EnumStateSoundRightAmbiencePlayer.STATE_PLAYING)
            {
                this._controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PAUSE;
            }
            else 
            {
                this._controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_PLAY;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_STOP;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            string currentTime = this._controller.currentMusicPositionTime;
            string totalTime = this._controller.totalMusicTime;
            WMPLib.WMPPlayState pState = this._controller.wmpIsPlaying;

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
                    this._controller.currentState = EnumStateSoundRightAmbiencePlayer.STATE_MEDIA_END;
                }));
            }
        }

        private void tbrVolume_Scroll(object sender, EventArgs e)
        {
            int value = tbrVolume.Value * 10;
            lblVolume.Text = Convert.ToString(value) + "%";

            // SEND VALUE TO PLAYER
            this._controller.volume = value;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
