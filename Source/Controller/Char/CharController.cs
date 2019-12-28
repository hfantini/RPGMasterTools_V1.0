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
using System.Windows.Forms;

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
        private static List<Enemy> _enemyList = new List<Enemy>();

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CharController(IComponent<EnumStateChar> component, GenericController controller) : base(component, controller)
        {

        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateChar currentState, EnumStateChar nextState)
        {
            bool retValue = true;

            if(nextState == EnumStateChar.STATE_NEW)
            {
                if(currentState != EnumStateChar.STATE_NEW_CONFIRM)
                {
                    retValue = false;
                }
            }

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if(this.currentState == EnumStateChar.STATE_EXPORT_PRESET)
            {
                exportCharPreset();
            }
            else if (this.currentState == EnumStateChar.STATE_IMPORT_PRESET)
            {
                importCharPreset();
            }
            else if (this.currentState == EnumStateChar.STATE_NEW_CONFIRM)
            {
                bool retValue = USystemMessage.createQuestionDialog("Question", "Confirm?");

                if(retValue)
                {
                    this.currentState = EnumStateChar.STATE_NEW;
                }
            }
            else if (this.currentState == EnumStateChar.STATE_NEW)
            {
                _playerList.Clear();
                _enemyList.Clear();

                this.currentState = EnumStateChar.STATE_PLAYERLIST_UPDATE;
                this.currentState = EnumStateChar.STATE_ENEMYLIST_UPDATE;
            }

            if (this.currentState != EnumStateChar.STATE_IDLE)
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

        public static List<Enemy> getListOfEnemies()
        {
            return new List<Enemy>(_enemyList);
        }

        public static void addEnemyToList(Enemy enemy)
        {
            if (!_enemyList.Contains(enemy))
            {
                _enemyList.Add(enemy);
            }
        }

        public static void removeEnemyFromList(Enemy enemy)
        {
            _enemyList.Remove(enemy);
        }

        private void exportCharPreset()
        {
            if (CharController.getListOfPlayers().Count > 0 || CharController.getListOfEnemies().Count > 0)
            {
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "JSON file|*.json";
                dlgSave.Title = ULanguage.getStringCurrentLanguage("CHARACTER.EXPORT.DLG_SAVE_TITLE");

                DialogResult retValue = dlgSave.ShowDialog();

                if (retValue == DialogResult.OK)
                {
                    if (dlgSave.FileName != null && dlgSave.FileName != "")
                    {
                        JObject jObject = new JObject();
                        jObject.Add("heroes", JsonConvert.SerializeObject(CharController.getListOfPlayers()));
                        jObject.Add("enemies", JsonConvert.SerializeObject(CharController.getListOfEnemies()));

                        UFileIO.writeJsonToFile(dlgSave.FileName, jObject);
                        MessageBox.Show(ULanguage.getStringCurrentLanguage("CHARACTER.EXPORT.SUCCESS"), ULanguage.getStringCurrentLanguage("GENERAL.MESSAGE"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                MessageBox.Show(ULanguage.getStringCurrentLanguage("CHARACTER.EXPORT.NOTHING_TO_EXPORT"), ULanguage.getStringCurrentLanguage("GENERAL.WARNING"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void importCharPreset()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JSON file|*.json";
            dlgOpen.Title = "Load Character Preset";

            DialogResult retValue = dlgOpen.ShowDialog();

            if (retValue == DialogResult.OK)
            {
                if (dlgOpen.FileName != null && dlgOpen.FileName != "")
                {
                    try
                    {
                        JObject loadedObject = UFileIO.loadJsonFromFile(dlgOpen.FileName);

                        if (loadedObject.ContainsKey("heroes") && loadedObject.ContainsKey("enemies"))
                        {
                            JArray jPlayer = JArray.Parse(loadedObject.Value<string>("heroes"));
                            _playerList = jPlayer.ToObject<List<Player>>();

                            JArray jEnemy = JArray.Parse(loadedObject.Value<string>("enemies"));
                            _enemyList = jEnemy.ToObject<List<Enemy>>();

                            this.currentState = EnumStateChar.STATE_PLAYERLIST_UPDATE;
                            this.currentState = EnumStateChar.STATE_ENEMYLIST_UPDATE;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(ULanguage.getStringCurrentLanguage("CHARACTER.IMPORT.FAIL"), ULanguage.getStringCurrentLanguage("GENERAL.ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
