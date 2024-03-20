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
    public partial class CtrlAltDelLocked : Form
    {
        private string username = "user";
        private string command = "";

        public CtrlAltDelLocked(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void CtrlAltDelLocked_Load(object sender, EventArgs e)
        {
            label_userLoggedOn.Text = username + " is loggon on.";
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

        private void CtrlAltDelLocked_KeyDown(object sender, KeyEventArgs e)
        {
            Locked locked = new Locked(username, true);
            Hide();
            locked.ShowDialog();
            switch (locked.Command)
            {
                case "ok":
                    Close();
                    break;

                case "switch user":
                    command = locked.Command;
                    Close();
                    break;

                default:
                    Show();
                    break;
            }
        }
    }
}
