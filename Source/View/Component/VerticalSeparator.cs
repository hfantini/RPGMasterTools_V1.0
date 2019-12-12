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
    |	Name: [VerticalSeparator.cs]
    |	Type: [TYPE]
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

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Component
{
    // == CLASS
    // ==============================================================

    public partial class VerticalSeparator : UserControl
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public VerticalSeparator()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(LineSeparator_Paint);
            this.MaximumSize = new Size(2, 2000);
            this.MinimumSize = new Size(2, 0);
            this.Width = 350;
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        private void LineSeparator_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.DarkGray, new Point(0, 0), new Point(0, this.Height));
            g.DrawLine(Pens.White, new Point(1, 0), new Point(1, this.Height));
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
