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
    |	Name: [ViewCombatPanel.cs]
    |	Type: [VIEW]
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
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Model.RPG;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanel : UserControl, IComponent<EnumStateCombatPanel>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatPanelController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanel()
        {
            InitializeComponent();
        }

        public ViewCombatPanel(GenericController parentController, Model.RPG.Combat combat)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLLER
            this._controller = new CombatPanelController(this, parentController, combat);
            
            // CONFIG COMPONENTS
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatPanel lastState, EnumStateCombatPanel currentState)
        {
            if(currentState == EnumStateCombatPanel.STATE_CREATE)
            {
                if (this._controller.combat.combatState == Enumeration.RPG.CombatState.PREPARATION)
                {
                    UComponent.removeAllChildren(this.fLayoutList);

                    foreach (Model.RPG.Character character in this._controller.combat.characterList)
                    {
                        ViewCombatPanelCharacter vCombatPanelChar = new ViewCombatPanelCharacter(this._controller, new Model.RPG.CombatCharacter(character, 0));
                        vCombatPanelChar.Size = new Size(fLayoutList.Size.Width, vCombatPanelChar.Size.Height);
                        this.fLayoutList.Controls.Add(vCombatPanelChar);
                    }

                    // DETAIL PANEL

                    ViewCombatPanelDetailPreparation vDetail = new ViewCombatPanelDetailPreparation(this._controller);
                    vDetail.Dock = DockStyle.Fill;

                    this.pnlDetailContent.Controls.Clear();
                    this.pnlDetailContent.Controls.Add(vDetail);
                }
                else if (this._controller.combat.combatState == Enumeration.RPG.CombatState.FIGHT)
                {
                    UComponent.removeAllChildren(this.fLayoutList);

                    foreach (Model.RPG.CombatCharacter character in this._controller.combat.characterCombatList)
                    {
                        ViewCombatPanelCharacter vCombatPanelChar = new ViewCombatPanelCharacter(this._controller, character);
                        vCombatPanelChar.Size = new Size(fLayoutList.Size.Width, vCombatPanelChar.Size.Height);
                        this.fLayoutList.Controls.Add(vCombatPanelChar);
                    }

                    // DETAIL PANEL

                    ViewCombatPanelDetailFight vDetail = new ViewCombatPanelDetailFight(this._controller);
                    vDetail.Dock = DockStyle.Fill;

                    this.pnlDetailContent.Controls.Clear();
                    this.pnlDetailContent.Controls.Add(vDetail);
                }
                else if (this._controller.combat.combatState == Enumeration.RPG.CombatState.FINISHED)
                {
                    // DETAIL PANEL

                    ViewCombatPanelDetailFight vDetail = new ViewCombatPanelDetailFight(this._controller);
                    vDetail.Dock = DockStyle.Fill;

                    this.pnlDetailContent.Controls.Clear();
                    //this.pnlDetailContent.Controls.Add(vDetail);
                }
            }
            else if (currentState == EnumStateCombatPanel.STATE_START_BATTLE)
            {
                // VALIDATING VIEWS

                bool validation = true;

                foreach(ViewCombatPanelCharacter view in this.fLayoutList.Controls)
                {
                    if(view.initiative < 1 || view.initiative > 20)
                    {
                        validation = false;
                    }

                    if(view.life < 0)
                    {
                        validation = false;
                    }


                    if (view.maxLife < 0)
                    {
                        validation = false;
                    }
                }

                if(!validation)
                {
                    MessageBox.Show("VALIDATION PROBLEMS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<CombatCharacter> combatCharacterList = new List<CombatCharacter>();

                    // PERSIST VALUES

                    foreach (ViewCombatPanelCharacter view in this.fLayoutList.Controls)
                    {
                        view.controller.combatCharacter.initiative = view.initiative;
                        view.controller.combatCharacter.character.maxLifePoints = view.maxLife;
                        view.controller.combatCharacter.character.lifePoints = view.life;

                        combatCharacterList.Add(view.controller.combatCharacter);
                    }

                    // SORT LIST BY INITIATIVE DESC

                    combatCharacterList.Sort((CombatCharacter val1, CombatCharacter val2) =>
                    {
                        int retValue = 0;

                        if (val1.initiative == val2.initiative)
                        {
                            retValue = 0;
                        }
                        else if (val1.initiative < val2.initiative)
                        {
                            retValue = 1;
                        }
                        else if (val1.initiative > val2.initiative)
                        {
                            retValue = -1;
                        }

                        return retValue;
                    });

                    this._controller.combat.characterCombatList = combatCharacterList;
                    this._controller.combat.goToNextState();
                    this._controller.currentState = EnumStateCombatPanel.STATE_CREATE;
                }
            }
        }

        // == EVENTS
        // ==============================================================

        private void fLayoutList_ControlAdded(object sender, ControlEventArgs e)
        {
            if (fLayoutList.Controls.Count % 10 == 0)
            {
                fLayoutList.SetFlowBreak(e.Control as Control, true);
            }
        }

        private void ViewCombatPanel_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatPanel.STATE_CREATE;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
