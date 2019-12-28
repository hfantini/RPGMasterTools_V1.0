
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
    |	Name: [ViewCharacter.cs]
    |	Type: [TYPE]
    |	Author: Henrique Fantini
    |	
    |	Description: -
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.View.Combat;
using RPGMasterTools.Source.Util;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Character
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombat : UserControl, IComponent<EnumStateCombat>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private ViewCombatPanelEmpty _pCombatEmpty = null;
        private ViewCombatPanel _pCombat = null;
        private CombatController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombat()
        {
            InitializeComponent();
        }

        public ViewCombat(GenericController parentController)
        {
            InitializeComponent();

            // INIT VALUES
            
            // CONFIGURE CONTROLLER

            this._controller = new CombatController(this, parentController);

            // CONFIGURE COMPONENTS

            this._pCombatEmpty = new ViewCombatPanelEmpty(this._controller);
            this._pCombatEmpty.Dock = DockStyle.Fill;
            this.pnlCombatPanel.Controls.Add(this._pCombatEmpty);

        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombat lastState, EnumStateCombat currentState)
        {
            if (currentState == EnumStateCombat.STATE_UPDATE_LIST)
            {
                UComponent.removeAllChildren(fLayoutPanel);

                foreach (Model.RPG.Combat combat in this._controller.combatList)
                {
                    ViewCombatNamePlate combatNamePlate = new ViewCombatNamePlate(this._controller, combat, false);
                    combatNamePlate.Size = new Size(fLayoutPanel.Size.Width, combatNamePlate.Size.Height);

                    fLayoutPanel.Controls.Add(combatNamePlate);
                }

                if(fLayoutPanel.Controls.Count == 1)
                {
                    // SELECT DEFAULT
                    ViewCombatNamePlate combatNamePlate = (ViewCombatNamePlate)fLayoutPanel.Controls[0];
                    combatNamePlate.select();
                }
            }
            else if (currentState == EnumStateCombat.STATE_COMBAT_SELECT)
            {
                foreach (ViewCombatNamePlate vCombat in this.fLayoutPanel.Controls)
                {
                    if (vCombat.combat == this._controller.selectedCombat)
                    {
                        vCombat.selected = true;
                        break;
                    }
                }

                this._pCombat = new ViewCombatPanel(this._controller, this._controller.selectedCombat);
                this._pCombat.Dock = DockStyle.Fill;

                this.pnlCombatPanel.Controls.Clear();
                this.pnlCombatPanel.Controls.Add(this._pCombat);
            }
            else if (currentState == EnumStateCombat.STATE_COMBAT_UNSELECT)
            {
                foreach (ViewCombatNamePlate vCombat in this.fLayoutPanel.Controls)
                {
                    if( vCombat.selected )
                    {
                        vCombat.selected = false;
                        break;
                    }
                }

                this.pnlCombatPanel.Controls.Clear();
                this.pnlCombatPanel.Controls.Add(this._pCombatEmpty);
            }
        }

        // == EVENTS
        // ==============================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombat.STATE_NEW;
        }

        private void fLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (fLayoutPanel.Controls.Count % 10 == 0)
            {
                fLayoutPanel.SetFlowBreak(e.Control as Control, true);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
