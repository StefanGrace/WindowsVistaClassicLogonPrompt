using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsVistaClassicLogonPrompt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool displayBackground = false;

            try
            {
                string[] lines = System.IO.File.ReadAllLines("Save.txt");
                displayBackground = bool.Parse(lines[4]);
            }
            catch { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (displayBackground)
            {
                Application.Run(new Background());
            }
            else
            {
                Application.Run(new LoadingWindow());
            }
            
        }
    }
}
