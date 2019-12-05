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
    |	Name: [ViewSoundLeftDetailEmpty.cs]
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

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundLeftDetailEmpty : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundLeftDetailEmpty()
        {
            InitializeComponent();

            // CONFIGURE COMPONENTS
            UComponent.applyLanguageToComponent(lblEmpty);
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
