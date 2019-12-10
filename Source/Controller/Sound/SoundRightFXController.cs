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
    |	Name: [SoundRightFXController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: -
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

    public class SoundRightFXController : ComponentController<EnumStateSoundRightFX>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolumeFX = 100;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightFXController(IComponent<EnumStateSoundRightFX> view, GenericController parentController) : base(view, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            this.currentState = EnumStateSoundRightFX.STATE_IDLE;
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is SoundController)
            {
                SoundController controller = (SoundController) parentController;

                if( controller.currentState == EnumStateSound.STATE_SFX_LIST_ADDED )
                {
                    this.currentState = EnumStateSoundRightFX.STATE_UPDATE_LIST_ADD;
                }
                else if ( controller.currentState == EnumStateSound.STATE_SFX_LIST_REMOVED )
                {
                    this.currentState = EnumStateSoundRightFX.STATE_UPDATE_LIST_REMOVE;
                }
                else
                {
                    base.onParentStateChange(parentController);
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public int masterVolumeFX
        {
            get { return this._masterVolumeFX; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    this._masterVolumeFX = value;
                    this.currentState = EnumStateSoundRightFX.STATE_MASTER_VOLUME_CHANGED;
                }
            }
        }
    }
}
