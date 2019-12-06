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
    |	Name: [ComponentController.cs]
    |	Type: [Controller]
    |	Author: Henrique Fantini
    |	
    |	Description: Define the base controller for system 
    |   components. 
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Controller;
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

    public abstract class ComponentController<T> : GenericController where T : System.Enum 
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        
        private IComponent<T> _currentComponent;
        private T _lastState;
        private T _currentState;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ComponentController( IComponent<T> currentComponent, GenericController parentController ) : base(EnumControllerType.TYPE_COMPONENT, parentController)
        {
            this._currentComponent = currentComponent;
            parentController.addChildrenController(this);

            init();
        }

        // == DESTRUCTOR
        // ==============================================================

        ~ComponentController()
        {
            parentController.removeChildrenController(this);
        }

        // == METHODS
        // ==============================================================

        protected virtual void init()
        {
            if (this.parentController == null)
            {
                throw new EMasterToolsException();
            }

            if (this._currentComponent == null)
            {
                throw new EMasterToolsException();
            }
        }

        protected virtual bool allowStateChange(T currentState, T nextState)
        {
            return true;
        }

        protected override void update()
        {
            this._currentComponent.update(this._lastState, this._currentState);
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public T lastState
        {
            get { return this._lastState; }
        }

        public T currentState
        {
            get { return this._currentState; }

            set
            {
                if ( !this._currentState.Equals(value) && allowStateChange(this._currentState, value ) )
                {
                    this._lastState = this._currentState;
                    this._currentState = value;

                    onParentStateChange(this);
                    update();
                }
            }
        }

        public override Object getCurrentState()
        {
            return this._currentState;
        }
    }
}
