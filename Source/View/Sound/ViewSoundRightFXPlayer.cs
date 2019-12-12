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
    |	Name: [ViewSoundRightFXPlayer.cs]
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
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Model.Sound;

// == NAMESPACE
// ==================================================================,

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightFXPlayer : UserControl, IComponent<EnumStateSoundRightFXPlayer>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private SoundRightFXPlayerController _controller = null;
        private System.Timers.Timer _timer;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightFXPlayer()
        {
            InitializeComponent();
        }

        // == DESTRUCTOR
        // ==============================================================

        public ViewSoundRightFXPlayer(int id, GenericController parentController, SoundFX sfx)
        {
            InitializeComponent();
            Disposed += onDispose;

            // INITIALIZE VALUES
            this._controller = new SoundRightFXPlayerController(id, this, parentController, sfx);

            this._timer = new System.Timers.Timer();
            this._timer.Interval = 100;
            this._timer.Elapsed += OnTimedEvent;

            // CONFIGURE CONTROLLER

            // CONFIGURE COMPONENTS
            this.lblID.Text = this._controller.id.ToString();
            this.lblSFXName.Text = sfx.name;
            this.tBarVolume.Value = (sfx.volume / 10);
            this.lblVolume.Text = sfx.volume + "%";
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightFXPlayer lastState, EnumStateSoundRightFXPlayer currentState)
        {
            if(currentState == EnumStateSoundRightFXPlayer.STATE_PLAYING)
            {
                btnPlay.Enabled = false;
                btnStop.Enabled = true;
            }
            if (currentState == EnumStateSoundRightFXPlayer.STATE_STOP)
            {
                btnPlay.Enabled = true;
                btnStop.Enabled = false;
            }

            // TIMER

            if( currentState == EnumStateSoundRightFXPlayer.STATE_PLAYING )
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

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            WMPLib.WMPPlayState pState = this._controller.wmpIsPlaying;

            if (pState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Invoke(new Action(() =>
                {
                    this._controller.currentState = EnumStateSoundRightFXPlayer.STATE_MEDIA_END;
                }));
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightFXPlayer.STATE_PLAY;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightFXPlayer.STATE_STOP;
        }

        private void tBarVolume_Scroll(object sender, EventArgs e)
        {
            int value = tBarVolume.Value * 10;
            lblVolume.Text = value + "%";
            this._controller.volume = value;
        }

        private void lblSFXName_DoubleClick(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightFXPlayer.STATE_PLAY;
        }

        private void onDispose(object sender, EventArgs e)
        {
            this._timer.Enabled = false;
            this._timer.Dispose();

            this._controller.Dispose();
            this._controller = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SoundController controller = (SoundController)this._controller.parentController.parentController.parentController;
            controller.removeSFXFromPlaylist(this._controller.currentSFX);
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public SoundRightFXPlayerController controller
        {
            get { return this._controller; }
        }

        public int id
        {
            get { return this._controller.id; }
            set
            {
                this._controller.id = value;
                this.lblID.Text = this._controller.id.ToString();
            }
        }
    }
}
