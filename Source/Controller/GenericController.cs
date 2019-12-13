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
    |	Name: [GenericController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines an abstract generic controller.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Controller;
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

    public abstract class GenericController : IDisposable
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private EnumControllerType _type;
        private List<GenericController> _children;
        private GenericController _parentController;
        private bool _disposed = false;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public GenericController(EnumControllerType type, GenericController parentController)
        {
            this._type = type;
            this._parentController = parentController;
            this._children = new List<GenericController>();
        }

        // == METHODS
        // ==============================================================

        protected abstract void update();

        public void addChildrenController(GenericController controller)
        {
            if( !this._children.Contains(controller) )
            {
                this._children.Add(controller);
            }
        }

        public void removeChildrenController(GenericController controller)
        {
            if ( this._children.Contains(controller) )
            {
                this._children.Remove(controller);
            }
        }

        public virtual void Dispose()
        {
            this._disposed = true;

            // DISPOSE CHILDREN CONTROLLERS
            foreach(GenericController childController in this._children)
            {
                childController.Dispose();
            }
        }

        // == EVENTS
        // ==============================================================

        protected virtual void onParentStateChange(GenericController parentController)
        {
            List<GenericController> controllerMarkedForExclusion = new List<GenericController>();

            foreach (GenericController childController in this.children)
            {
                if (!childController._disposed)
                {
                    childController.onParentStateChange(parentController);
                }
                else
                {
                    controllerMarkedForExclusion.Add(childController);
                }
            }

            // REMOVE REFERENCES OF DISPOSED CONTROLLERS

            foreach (GenericController disposedController in controllerMarkedForExclusion)
            {
                this._children.Remove(disposedController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public GenericController parentController
        {
            get { return _parentController; }
        }

        public EnumControllerType type
        {
            get { return this._type; }
        }

        public List<GenericController> children
        {
            get { return new List<GenericController>(this._children); }
        }

        public abstract Object getCurrentState();

        public bool disposed
        {
            get { return this._disposed; }
        }
    }
}
