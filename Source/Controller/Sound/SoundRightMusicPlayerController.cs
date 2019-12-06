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
using RPGMasterTools.Source.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if(parentController is SoundRightMusicController)
            {
                SoundRightMusicController controller = (SoundRightMusicController) parentController;

                this.currentState = EnumStateSoundRightMusicPlayer.STATE_UPDATE;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
