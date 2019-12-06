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

    public abstract class GenericController
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private EnumControllerType _type;
        private List<GenericController> _children;
        private GenericController _parentController;

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

        // == EVENTS
        // ==============================================================

        protected virtual void onParentStateChange(GenericController parentController)
        {
            foreach (GenericController childController in this.children)
            {
                childController.onParentStateChange(parentController);
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
    }
}
