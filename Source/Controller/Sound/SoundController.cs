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
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
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

        private Preset _currentPreset = null;
        private Preset _savePreset = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundController(IComponent<EnumStateSound> component, GenericController controller) : base(component, controller)
        {
            this._jSerializer = new JsonSerializer();

            this._musicPlaylist = new List<Music>();
            this._musicLastChange = new List<Music>();

            this._ambiencePlaylist = new List<Ambience>();
            this._ambienceLastChange = new List<Ambience>();

            this._sfxPlaylist = new List<SoundFX>();
            this._sfxLastChange = new List<SoundFX>();
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

        public void removeAllAmbienceFromPlaylist()
        {
            if (this._ambiencePlaylist.Count > 0)
            {
                this._ambiencePlaylist.Clear();
                this.currentState = EnumStateSound.STATE_AMBIENCE_LIST_CLEAR;
            }
        }

        public void addSFXToPlaylist(JObject jSoundFX)
        {
            SoundFX sfx = this._jSerializer.Deserialize<SoundFX>(jSoundFX.CreateReader());
            this._sfxPlaylist.Add(sfx);
            this._sfxLastChange.Add(sfx);

            this.currentState = EnumStateSound.STATE_SFX_LIST_ADDED;
        }

        public void removeSFXFromPlaylist(SoundFX soundFX)
        {
            int sfxIndex = this._sfxPlaylist.IndexOf(soundFX);

            if (sfxIndex != -1)
            {
                this._sfxPlaylist.RemoveAt(sfxIndex);
                this.currentState = EnumStateSound.STATE_SFX_LIST_REMOVED;
            }
        }

        public void removeAllSFXFromPlaylist()
        {
            if (this._sfxPlaylist.Count > 0)
            {
                this._sfxPlaylist.Clear();
                this.currentState = EnumStateSound.STATE_SFX_LIST_CLEAR;
            }
        }

        public void loadPresetFromFile( JObject jPreset )
        {
            try
            {
                String presetPath = jPreset.Value<String>("PATH") + "\\" + jPreset.Value<String>("NAME");
                this._currentPreset = parsePresetFile(presetPath);
                this._currentPreset.path = presetPath;

                this._musicPlaylist = new List<Music>( this._currentPreset.musicPreset.musicList );
                this._ambiencePlaylist = new List<Ambience>( this._currentPreset.ambiencePreset.ambienceList );
                this._sfxPlaylist = new List<SoundFX>( this._currentPreset.sfxPreset.sfxList );

                this.currentState = EnumStateSound.STATE_PRESET_LOADED;
            }
            catch (Exception e)
            {
                UExceptionHandler.handleWithException( new EMasterToolsPresetException(e, ExceptionType.TYPE_ERROR, e.Message) );
            }

        }

        private Preset parsePresetFile( String path )
        {
            Preset retValue = null;

            StreamReader sReader = new StreamReader(path);
            JObject obj = (JObject)this._jSerializer.Deserialize(new JsonTextReader(sReader));
            sReader.Close();

            if (obj.ContainsKey("parentPreset") && obj.Value<String>("parentPreset") != null)
            {
                retValue = parsePresetFile(obj.Value<String>("parentPreset"));
                retValue.parentPreset = path;

                // == PROCESS THE INHERITANCE

                // MUSIC

                if (obj.ContainsKey("musicPreset"))
                {
                    JObject jMusic = obj.Value<JObject>("musicPreset");

                    // MASTER VOLUME
                    if (jMusic.ContainsKey("masterVolume"))
                    {
                        retValue.musicPreset.masterVolume = jMusic.Value<int>("masterVolume");
                    }

                    // REPEAT
                    if (jMusic.ContainsKey("repeat"))
                    {
                        retValue.musicPreset.repeat = jMusic.Value<bool>("repeat");
                    }

                    // RANDOM
                    if (jMusic.ContainsKey("random"))
                    {
                        retValue.musicPreset.random = jMusic.Value<bool>("random");
                    }

                    // AUTOPLAY
                    if (jMusic.ContainsKey("autoPlay"))
                    {
                        retValue.musicPreset.autoPlay = jMusic.Value<bool>("autoPlay");
                    }

                    // MUSIC LIST
                    JArray mArray = jMusic.Value<JArray>("musicList");

                    if (mArray != null && mArray.Count > 0)
                    {
                        foreach (JObject musicObject in mArray)
                        {
                            Music music = this._jSerializer.Deserialize<Music>(musicObject.CreateReader());

                            if (!retValue.musicPreset.musicList.Contains(music))
                            {
                                retValue.musicPreset.musicList.Add(music);
                            }
                        }
                    }
                }

                // AMBIENCE

                if (obj.ContainsKey("ambiencePreset"))
                {
                    JObject jAmbience = obj.Value<JObject>("ambiencePreset");

                    // MASTER VOLUME
                    if (jAmbience.ContainsKey("masterVolume"))
                    {
                        retValue.ambiencePreset.masterVolume = jAmbience.Value<int>("masterVolume");
                    }

                    // AUTOPLAY
                    if (jAmbience.ContainsKey("autoPlay"))
                    {
                        retValue.ambiencePreset.autoPlay = jAmbience.Value<bool>("autoPlay");
                    }

                    // AMBIENCE LIST
                    JArray aArray = jAmbience.Value<JArray>("ambienceList");

                    if (aArray != null && aArray.Count > 0)
                    {
                        foreach (JObject ambienceObject in aArray)
                        {
                            Ambience ambience = this._jSerializer.Deserialize<Ambience>(ambienceObject.CreateReader());

                            if (!retValue.ambiencePreset.ambienceList.Contains(ambience))
                            {
                                retValue.ambiencePreset.ambienceList.Add(ambience);
                            }
                        }
                    }
                }

                // SOUNDFX

                if (obj.ContainsKey("sfxPreset"))
                {
                    JObject jSoundFX = obj.Value<JObject>("sfxPreset");

                    // MASTER VOLUME
                    if (jSoundFX.ContainsKey("masterVolume"))
                    {
                        retValue.sfxPreset.masterVolume = jSoundFX.Value<int>("masterVolume");
                    }

                    // SFX LIST
                    JArray sfxArray = jSoundFX.Value<JArray>("sfxList");

                    if (sfxArray != null && sfxArray.Count > 0)
                    {
                        foreach (JObject sfxObject in sfxArray)
                        {
                            SoundFX sfx = this._jSerializer.Deserialize<SoundFX>(sfxObject.CreateReader());

                            if (!retValue.sfxPreset.sfxList.Contains(sfx))
                            {
                                retValue.sfxPreset.sfxList.Add(sfx);
                            }
                        }
                    }
                }
            }
            else
            {
                retValue = this._jSerializer.Deserialize<Preset>(obj.CreateReader());
            }            

            return retValue;
        }

        private void saveCurrentPreset()
        {
            bool inheritFromPreset = false;

            if(currentPreset != null)
            {
                inheritFromPreset = USystemMessage.createQuestionDialog(ULanguage.getStringCurrentLanguage("GENERAL.QUESTION"), ULanguage.getStringCurrentLanguage("SOUND.PRESET.INHERIT_QUESTION") );
            }

            if(inheritFromPreset)
            {
                this._savePreset.parentPreset = this._currentPreset.path;

                // == ADDING NON REPEATING TRACKS

                // MUSIC

                foreach(Music music in this._musicPlaylist)
                {
                    if( !this._currentPreset.musicPreset.musicList.Contains(music) )
                    {
                        this._savePreset.musicPreset.musicList.Add(music);
                    }
                }

                // AMBIENCE

                foreach (Ambience ambience in this._ambiencePlaylist)
                {
                    if (!this._currentPreset.ambiencePreset.ambienceList.Contains(ambience))
                    {
                        this._savePreset.ambiencePreset.ambienceList.Add(ambience);
                    }
                }

                // SFX

                foreach (SoundFX sfx in this._sfxPlaylist)
                {
                    if (!this._currentPreset.sfxPreset.sfxList.Contains(sfx))
                    {
                        this._savePreset.sfxPreset.sfxList.Add(sfx);
                    }
                }
            }
            else
            {
                // ADDING TRACKS

                this._savePreset.musicPreset.musicList = this._musicPlaylist;
                this._savePreset.ambiencePreset.ambienceList = this._ambiencePlaylist;
                this._savePreset.sfxPreset.sfxList = this._sfxPlaylist;
            }

            // DEFINE TARGET FILE OPTIONS

            string filename = USystemMessage.createInputDialog(ULanguage.getStringCurrentLanguage("GENERAL.MESSAGE"), ULanguage.getStringCurrentLanguage("CHARACTER.EXPORT.SET_FILENAME")) + ".json";
            string filePath = UFileIO.getUserCustomPresetFolder() + "\\" + filename;

            bool overWrite = true;

            if ( File.Exists(filePath) )
            {
                if( !USystemMessage.createQuestionDialog(ULanguage.getStringCurrentLanguage("GENERAL.QUESTION"), ULanguage.getStringCurrentLanguage("SOUND.PRESET.OVERWRITE_QUESTION") ) )
                {
                    overWrite = false;
                }
            }

            if (overWrite)
            {
                // WRITES THE FILE TO DISK

                JObject jSavePreset = JObject.FromObject(this._savePreset);
                UFileIO.writeJsonToFile(filePath, jSavePreset);

                // DISPLAY SUCCESS 

                USystemMessage.createMessageBox(ULanguage.getStringCurrentLanguage("GENERAL.SUCCESS"), ULanguage.getStringCurrentLanguage("CHARACTER.EXPORT.SUCCESS"));
            }
        }

        protected override bool allowStateChange(EnumStateSound currentState, EnumStateSound nextState)
        {
            bool retValue = true;

            if(nextState == EnumStateSound.STATE_PRESET_SAVE)
            {
                if(currentState != EnumStateSound.STATE_PRESET_PREPARE_SAVE)
                {
                    retValue = false;
                }
            }

            return retValue;
        }

        protected override void update()
        {
            base.update();

            if (this.currentState == EnumStateSound.STATE_PRESET_PREPARE_SAVE)
            {
                this._savePreset = new Preset();
                this.currentState = EnumStateSound.STATE_PRESET_SAVE;
            }
            else if (this.currentState == EnumStateSound.STATE_PRESET_SAVE)
            {
                saveCurrentPreset();
            }

            // DEFAULT STATE

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

        public Preset currentPreset
        {
            get { return this._currentPreset; }
        }
    }
}
