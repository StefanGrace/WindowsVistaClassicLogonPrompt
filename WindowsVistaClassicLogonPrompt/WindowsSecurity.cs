using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsVistaClassicLogonPrompt
{
    public partial class WindowsSecurity : Form
    {
        private string username;
        private DateTime logonDate;
        private string command = "";
        private string defaultPowerAction;

        public WindowsSecurity(string username, DateTime logonDate, string defaultPowerAction)
        {
            this.username = username;
            this.logonDate = logonDate;
            this.defaultPowerAction = defaultPowerAction;
            InitializeComponent();
        }

        private void WindowsSecurity_Load(object sender, EventArgs e)
        {
            label_loggedOnAs.Text = "You are logged on as " + username + ".";
            label_dateLoggedOn.Text = logonDate.ToString();
        }

        private void button_taskManager_Click(object sender, EventArgs e)
        {
            command = "task manager";
            Close();
        }

        public string Command
        {
            get
            {
                return command;
            }
        }

        private void button_lock_Click(object sender, EventArgs e)
        {
            command = "lock";
            Close();
        }

        private void button_logOff_Click(object sender, EventArgs e)
        {
            LogOffPrompt logOffPrompt = new LogOffPrompt();
            logOffPrompt.ShowDialog();
            if (logOffPrompt.Command != "")
            {
                command = logOffPrompt.Command;
                Close();
            }
        }

        private void button_shutDown_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                DialogResult userAwnser = MessageBox.Show("Click OK to immediatly restart your computer. Any un-saved data will be lost. Use this only as a last resort.",
                    "Emergency restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                if (userAwnser == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                ShutDownDialog shutDown = new ShutDownDialog(defaultPowerAction, true);
                shutDown.ShowDialog();
                if (shutDown.Command != "")
                {
                    command = shutDown.Command;
                    Close();
                }
            }
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword passChange = new ChangePassword(username);
            passChange.ShowDialog();
        }
    }
}
