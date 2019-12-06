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
    |	Name: [SoundController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: Sound controller class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundController : ComponentController<EnumStateSound>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private JsonSerializer _jSerializer;

        private JArray _assetsFromTheDisk = null;
        private List<Music> _musicPlaylist = null;
        private List<Music> _musicLastChange = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundController(IComponent<EnumStateSound> component, GenericController controller) : base(component, controller)
        {
            this._jSerializer = new JsonSerializer();

            this._musicPlaylist = new List<Music>();
            this._musicLastChange = new List<Music>();
        }

        // == METHODS
        // ==============================================================

        public void addMusicToPlaylist(JObject jMusic)
        {
            Music music = this._jSerializer.Deserialize<Music>( jMusic.CreateReader() );
            this._musicPlaylist.Add(music);
            this._musicLastChange.Add(music);

            this.currentState = EnumStateSound.STATE_MUSIC_LIST_CHANGED;
        }

        protected override void update()
        {
            base.update();

            if(this.currentState != EnumStateSound.STATE_IDLE)
            {
                this.currentState = EnumStateSound.STATE_IDLE;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public JArray assetsFromTheDisk
        {
            get { return this._assetsFromTheDisk; }
            set { this._assetsFromTheDisk = value; }
        }

        public List<Music> musicPlaylist
        {
            get { return new List<Music>(this._musicPlaylist); }
        }
        public List<Music> musicLastChange
        {
            get { return this._musicLastChange; }
        }

    }
}
