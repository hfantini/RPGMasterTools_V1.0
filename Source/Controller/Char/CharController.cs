﻿/*

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
    |	Name: [CharController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Char controller class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.RPG;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Char
{
    // == CLASS
    // ==============================================================

    public class CharController : ComponentController<EnumStateChar>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private static List<Player> _playerList = new List<Player>();

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharController(IComponent<EnumStateChar> component, GenericController controller) : base(component, controller)
        {

        }

        // == EVENTS
        // ==============================================================

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            if(this.currentState != EnumStateChar.STATE_IDLE)
            {
                this.currentState = EnumStateChar.STATE_IDLE;
            }
        }

        public static List<Player> getListOfPlayers()
        {
            return new List<Player>(_playerList);
        }

        public static void addPlayerToList(Player player)
        {
            if( !_playerList.Contains(player) )
            {
                _playerList.Add(player);
            }
        }

        public static void removePlayerFromList(Player player)
        {
            _playerList.Remove(player);
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
