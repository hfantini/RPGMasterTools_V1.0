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
        private List<Ambience> _ambiencePlaylist = null;
        private List<Ambience> _ambienceLastChange = null;
        private List<SoundFX> _sfxPlaylist = null;
        private List<SoundFX> _sfxLastChange = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundController(IComponent<EnumStateSound> component, GenericController controller) : base(component, controller)
        {
            this._jSerializer = new JsonSerializer();

            this._musicPlaylist = new List<Music>();
            this._musicLastChange = new List<Music>();

            this._ambiencePlaylist = new List<Ambience>();
            this._ambienceLastChange = new List<Ambience>();
        }

        // == METHODS
        // ==============================================================

        public void addMusicToPlaylist(JObject jMusic)
        {
            Music music = this._jSerializer.Deserialize<Music>( jMusic.CreateReader() );
            this._musicPlaylist.Add(music);
            this._musicLastChange.Add(music);

            this.currentState = EnumStateSound.STATE_MUSIC_LIST_ADDED;
        }

        public void removeMusicFromPlaylist(Music music)
        {
            int musicIndex = this._musicPlaylist.IndexOf(music);

            if( musicIndex != -1)
            {
                this._musicPlaylist.RemoveAt(musicIndex);
                this.currentState = EnumStateSound.STATE_MUSIC_LIST_REMOVED;
            }
        }

        public void addAmbienceToPlaylist(JObject jAmbience)
        {
            Ambience ambience = this._jSerializer.Deserialize<Ambience>(jAmbience.CreateReader());
            this._ambiencePlaylist.Add(ambience);
            this._ambienceLastChange.Add(ambience);

            this.currentState = EnumStateSound.STATE_AMBIENCE_LIST_ADDED;
        }

        public void removeAmbienceFromPlaylist(Ambience ambience)
        {
            int ambienceIndex = this._ambiencePlaylist.IndexOf(ambience);

            if (ambienceIndex != -1)
            {
                this._ambiencePlaylist.RemoveAt(ambienceIndex);
                this.currentState = EnumStateSound.STATE_AMBIENCE_LIST_REMOVED;
            }
        }

        public void addSFXToPlaylist(JObject jSoundFX)
        {
            SoundFX sfx = this._jSerializer.Deserialize<SoundFX>(jSoundFX.CreateReader());
            this._sfxPlaylist.Add(sfx);
            this._sfxLastChange.Add(sfx);

            this.currentState = EnumStateSound.STATE_AMBIENCE_LIST_ADDED;
        }

        public void removeSFXFromPlaylist(SoundFX soundFX)
        {
            int sfxIndex = this._sfxPlaylist.IndexOf(soundFX);

            if (sfxIndex != -1)
            {
                this._ambiencePlaylist.RemoveAt(sfxIndex);
                this.currentState = EnumStateSound.STATE_SFX_LIST_ADDED;
            }
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

        public List<Ambience> ambiencePlaylist
        {
            get { return new List<Ambience>(this._ambiencePlaylist); }
        }

        public List<Ambience> ambienceLastChange
        {
            get { return this._ambienceLastChange; }
        }

        public List<SoundFX> soundFXPlaylist
        {
            get { return new List<SoundFX>(this._sfxPlaylist); }
        }

        public List<SoundFX> soundFXLastChange
        {
            get { return this._sfxLastChange; }
        }
    }
}
