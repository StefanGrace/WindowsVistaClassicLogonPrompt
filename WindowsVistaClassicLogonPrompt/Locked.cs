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
    public partial class Locked : Form
    {
        private string username = "user";
        private string command = "";
        private bool ctrlAltDelReq;

        public Locked(string username, bool ctrlAltDelReq = false)
        {
            this.username = username;
            this.ctrlAltDelReq = ctrlAltDelReq;
            InitializeComponent();
        }

        private void Locked_Load(object sender, EventArgs e)
        {
            label_userLoggedOn.Text = username + " is logged on";
            button_cancel.Enabled = ctrlAltDelReq;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            command = "ok";
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
