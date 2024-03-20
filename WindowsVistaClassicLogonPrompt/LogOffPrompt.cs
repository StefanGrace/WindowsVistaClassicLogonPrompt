using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsVistaClassicLogonPrompt
{
    public partial class LogOffPrompt : Form
    {
        private string command = "";

        public LogOffPrompt()
        {
            InitializeComponent();
        }

        private void button_LogOff_Click(object sender, EventArgs e)
        {
            command = "log off";
            Close();
        }

        private void button_switchUser_Click(object sender, EventArgs e)
        {
            command = "switch user";
            Close();
        }

        public string Command
        {
            get
            {
                return command;
            }
        }

    }


}
