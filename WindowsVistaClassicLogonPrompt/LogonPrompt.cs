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
    public partial class LogonPrompt : Form
    {
        private bool ctrlAltDelReq;
        private string username;
        private string command;
        private string defaultPowerAction;

        public LogonPrompt(string username, string defaultPowerAction, bool ctrlAltDelReq = false)
        {
            this.username = username;
            this.ctrlAltDelReq = ctrlAltDelReq;
            this.defaultPowerAction = defaultPowerAction;
            InitializeComponent();
        }

        private void LogonPrompt_Load(object sender, EventArgs e)
        {
            textBox_userName.Text = username;
            button_cancel.Enabled = ctrlAltDelReq;
            if (ctrlAltDelReq)
            {
                showCtrlAltDel();
            }
        }

        private void button_shutDown_Click(object sender, EventArgs e)
        {
            ShutDownDialog shutDown = new ShutDownDialog(defaultPowerAction, false);
            shutDown.ShowDialog();
            if (shutDown.Command != "")
            {
                command = shutDown.Command;
                Close();
            }

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_userName.Text == "")
            {
                MessageBox.Show("Please enter a user name", "Logon Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_userName.Text.ToUpper() == "SYSTEM")
            {
                MessageBox.Show("Cannot logon as SYSTEM", "Logon Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                username = textBox_userName.Text;
                command = "log on";
                Close();
            }
            
        }

        private void showCtrlAltDel()
        {
            CtrlAltDelLogon ctrlAltDel = new CtrlAltDelLogon();
            Hide();
            ctrlAltDel.ShowDialog();
            Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            showCtrlAltDel();
        }

        private void LogonPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (ctrlAltDelReq)
                {
                    showCtrlAltDel();
                }
            }
        }


        public string Username
        {
            get
            {
                return username;
            }
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
