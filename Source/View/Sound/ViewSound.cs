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
    |	Name: [ViewSound.cs]
    |	Type: [COMPONENT]
    |	Author: Henrique Fantini
    |	
    |	Description: Sound component.
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
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Controller;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSound : UserControl, IComponent<EnumStateSound>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        ViewSoundLeft _viewSoundLeft = null;
        ViewSoundRight _viewSoundRight = null;

        private SoundController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSound( GenericController parentController )
        {
            InitializeComponent();

            this._controller = new SoundController(this, parentController);

            // ADDING COMPONENTS

            this._viewSoundLeft = new ViewSoundLeft(this._controller);
            this._viewSoundLeft.Dock = DockStyle.Fill;
            this.pnlSoundLeft.Controls.Add(this._viewSoundLeft);

            this._viewSoundRight = new ViewSoundRight(this._controller);
            this._viewSoundRight.Dock = DockStyle.Fill;
            this.pnlSoundRight.Controls.Add(this._viewSoundRight);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSound lastState, EnumStateSound currentState)
        {

        }

        // == EVENTS
        // ==============================================================

        private void ViewSound_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSound.STATE_IDLE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================

    }
}
