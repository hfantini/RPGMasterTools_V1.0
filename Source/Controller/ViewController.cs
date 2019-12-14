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
    |	Name: [ViewController.cs]
    |	Type: [Controller]
    |	Author: Henrique Fantini
    |	
    |	Description: Define the base controller for system views. 
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Controller;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller
{
    // == CLASS
    // ==============================================================

    public abstract class ViewController<T> : GenericController where T : System.Enum 
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private IView<T> _currentView;
        private T _lastState;
        private T _currentState;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewController( IView<T> currentView ) : base(EnumControllerType.TYPE_VIEW, null)
        {
            this._currentView = currentView;

            init();
        }

        // == METHODS
        // ==============================================================

        protected virtual void init()
        {
            if (this._currentView == null)
            {
                throw new EMasterToolsException();
            }
        }

        protected override void update()
        {
            this._currentView.update(this._lastState, this._currentState);
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public override Object getCurrentState()
        {
            return this._currentState;
        }

        public T lastState
        {
            get { return this._lastState; }
        }

        public T currentState
        {
            get { return this._currentState; }

            set
            {
                this._lastState = this._currentState;
                this._currentState = value;

                onParentStateChange(this);
                update();
            }
        }
    }
}
