
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
    |	Name: [ViewSoundRightMusic.cs]
    |	Type: [VIEW
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

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightMusic : UserControl, RPGMasterTools.Source.Interface.IComponent<EnumStateSoundRightMusic>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private ViewSoundRightMusicPlayer _viewMusicPlayer;

        private SoundRightMusicController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusic()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusic(GenericController parentController)
        {
            InitializeComponent();

            // CONFIGURE CONTROLLER

            this._controller = new SoundRightMusicController(this, parentController);

            // CREATE COMPONENTS
            this._viewMusicPlayer = new ViewSoundRightMusicPlayer(this._controller);

            // CONFIGURE COMPONENTS
            this._viewMusicPlayer.Dock = DockStyle.Fill;
            pnlBottom.Controls.Add(this._viewMusicPlayer);


        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightMusic lastState, EnumStateSoundRightMusic currentState)
        {
            throw new NotImplementedException();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
