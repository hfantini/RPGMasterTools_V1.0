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
    |	Name: [UComponent.cs]
    |	Type: [UTIL]
    |	Author: Henrique Fantini
    |	
    |	Description: Provides methods related with component
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
using static System.Windows.Forms.Control;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Util
{
    // == CLASS
    // ==============================================================

    public class UComponent
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        // == METHODS
        // ==============================================================

        public static void applyLanguageToComponent(Control control)
        {
            control.Text = ULanguage.getStringCurrentLanguage(control.Text );
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
                        UComponent.applyLanguageToMenu(item);
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
                        UComponent.applyLanguageToMenu(item);
                    }
                }
            }
            else
            {
                throw new EMasterToolsException("applyLanguageToMenu: Invalid parameter type.");
            }

        }

        public static void removeAllChildren(Control control)
        {
            control.Controls.Clear();
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
    }
}
