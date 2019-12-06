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

        private Music _music = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusicPlate()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusicPlate(Music music)
        {
            InitializeComponent();

            this._music = music;
            updateInfo();
        }

        // == METHODS
        // ==============================================================

        public void updateInfo()
        {
            if (this._music != null)
            {
                lblName.Text = this._music.name;
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // =============================================================
    }
}
