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
    |	Name: [BaseController.cs]
    |	Type: [Controller]
    |	Author: Henrique Fantini
    |	
    |	Description: Define the base controller. All system
    |                controllers inherits from that structure.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller
{
    // == CLASS
    // ==============================================================

    public abstract class BaseController<T> where T : System.Enum
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private BaseController<System.Enum> _parentController;
        private IView<T> _currentView;
        private T _lastState;
        private T _currentState;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public BaseController( IView<T> currentView )
        {
            this._currentView = currentView;
            this._parentController = null;

            init();
            this._currentView.update(this._lastState, this._currentState);
        }

        public BaseController( IView<T> currentView, BaseController<System.Enum> parentController )
        {
            this._currentView = currentView;
            this._parentController = parentController;

            init();
            this._currentView.update( this._lastState, this._currentState );
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

        // == GETTERS AND SETTERS
        // ==============================================================

        public BaseController<System.Enum> parentController
        {
            get { return _parentController; }
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

                this._currentView.update(this._lastState, this._currentState);
            }
        }
    }
}
