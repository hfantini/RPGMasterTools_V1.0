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
    |	Name: [ViewSoundLeftDetailFolder.cs]
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
using RPGMasterTools.Source.Util;
using Newtonsoft.Json.Linq;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundLeftDetailFolder : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundLeftDetailFolder()
        {
            InitializeComponent();

            // CONFIGURE COMPONENTS

            UComponent.applyLanguageToComponent(lblNameText);
            UComponent.applyLanguageToComponent(lblTypeText);
            UComponent.applyLanguageToComponent(lblDescText);

            lblTypeValue.Text = ULanguage.getStringCurrentLanguage("SOUND.LEFT.DETAIL.FOLDER");
        }

        // == METHODS
        // ==============================================================

        public void update(JObject info)
        {
            lblNameValue.Text = info.Value<String>("NAME");
            txtDesc.Text = info.Value<String>("DESCRIPTION");
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
