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
    |	Name: [UFormUtil.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Provides methods related with form
    |   manipulation.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Model.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class UFormUtil
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static void applyLanguageToForm(Form form)
        {
            form.Text = ULanguage.getStringCurrentLanguage( form.Text );
        }

        public static void applyLanguageToTabPanel(TabControl tabControl)
        {
            foreach ( TabPage page in tabControl.TabPages )
            {
                page.Text = ULanguage.getStringCurrentLanguage(page.Text);
            }
        }

        public static void applyLanguageToMenu(Object menu)
        {
            if(menu is MenuStrip)
            {
                foreach (ToolStripMenuItem item in ( (MenuStrip) menu ).Items)
                {
                    String languageKey = item.Text;
                    item.Text = ULanguage.getStringCurrentLanguage(languageKey);

                    if (item.DropDown.Items.Count > 0)
                    {
                        UFormUtil.applyLanguageToMenu(item);
                    }
                }
            }
            else if(menu is ToolStripMenuItem)
            {
                foreach (ToolStripMenuItem item in ( (ToolStripMenuItem) menu).DropDown.Items)
                {
                    String languageKey = item.Text;
                    item.Text = ULanguage.getStringCurrentLanguage(languageKey);

                    if (item.DropDown.Items.Count > 0)
                    {
                        UFormUtil.applyLanguageToMenu(item);
                    }
                }
            }
            else
            {
                throw new EMasterToolsException("applyLanguageToMenu: Invalid parameter type.");
            }

        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
    }
}
