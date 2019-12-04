using RPGMasterTools.Source.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMasterTools
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run( new ViewMain() );
            }
            catch( Exception e )
            {
                // THROW FATAL EXCEPTIONS
            }
        }
    }
}
