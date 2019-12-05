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

        private GenericController _parentController;
        private IComponent<T> _currentComponent;
        private T _lastState;
        private T _currentState;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ComponentController( IComponent<T> currentComponent, GenericController parentController ) : base(EnumControllerType.TYPE_COMPONENT)
        {
            this._currentComponent = currentComponent;
            this._parentController = parentController;
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
            if (this._parentController == null)
            {
                throw new EMasterToolsException();
            }

            if (this._currentComponent == null)
            {
                throw new EMasterToolsException();
            }
        }

        public override void update()
        {
            this._currentComponent.update(this._lastState, this._currentState);

            foreach (GenericController childController in this.children)
            {
                if (childController.allowUpdatePropagation)
                {
                    childController.update();
                }
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public GenericController parentController
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

                update();
            }
        }

        public override Object getCurrentState()
        {
            return this._currentState;
        }
    }
}
