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
    |	Name: [SoundRightMusicPlayerController.cs]
    |	Type: [Controller]
    |	Author: Henrique Fantini
    |	
    |	Description:
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Enumeration.System;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundRightMusicPlayerController : ComponentController<EnumStateSoundRightMusicPlayer>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightMusicPlayerController( IComponent<EnumStateSoundRightMusicPlayer> component, GenericController parentController ) : base(component, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if (this.currentState == EnumStateSoundRightMusicPlayer.STATE_PRESET_LOADED)
            {
                SoundRightMusicController controller = (SoundRightMusicController)this.parentController;
                PresetMusic preset = ((SoundController)this.parentController.parentController.parentController).currentPreset.musicPreset;

                controller.repeat = preset.repeat;
                controller.random = preset.random;
                controller.volume = preset.masterVolume;

                this.currentState = EnumStateSoundRightMusicPlayer.STATE_UPDATE;
            }
            else if( this.currentState == EnumStateSoundRightMusicPlayer.STATE_UPDATE )
            {
                this.currentState = EnumStateSoundRightMusicPlayer.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is SoundRightMusicController)
            {
                SoundRightMusicController controller = (SoundRightMusicController)parentController;

                if (controller.currentState == EnumStateSoundRightMusic.STATE_PRESET_LOADED)
                {
                    this.currentState = EnumStateSoundRightMusicPlayer.STATE_PRESET_LOADED;
                }
                else
                {
                    this.currentState = EnumStateSoundRightMusicPlayer.STATE_UPDATE;
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
