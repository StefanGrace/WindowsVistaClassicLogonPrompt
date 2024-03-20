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
    public partial class UserDesktop : Form
    {
        private string username;
        private DateTime logonDate;
        private string command = "";
        private bool initalCtrlAltDelReq;
        private bool initalDisplayBackground;
        private bool initalDisplayLastUser;
        private bool initalLockAfterSleep;
        private string initalDefaultPowerAction;
        private bool initalLock;

        public UserDesktop(string username, DateTime logonDate, bool ctrlAltDelReq, bool displayBackground, bool displayLastUser, bool lockAfterSleep, string defaultPowerAction, bool lock_ = false)
        {
            this.username = username;
            this.logonDate = logonDate;
            initalCtrlAltDelReq = ctrlAltDelReq;
            initalDisplayBackground = displayBackground;
            initalDisplayLastUser = displayLastUser;
            initalLockAfterSleep = lockAfterSleep;
            initalDefaultPowerAction = defaultPowerAction;
            initalLock = lock_;
            InitializeComponent();
        }

        private void UserDesktop_Load(object sender, EventArgs e)
        {
            checkBox_ctrlAltDelReq.Checked = initalCtrlAltDelReq;
            checkBox_displayBackground.Checked = initalDisplayBackground;
            checkBox_displayLastUser.Checked = initalDisplayLastUser;
            checkBox_lockAfterSleep.Checked = initalLockAfterSleep;
            label_username.Text = "Username: " + username;
            switch (initalDefaultPowerAction)
            {
                case "sleep":
                    comboBox_defaultActions.SelectedIndex = 0;
                    break;
                case "shut down":
                    comboBox_defaultActions.SelectedIndex = 1;
                    break;
            }
            if (initalLock)
            {
                Lock();
            }
            
        }

        private void UserDesktop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DisplaySecurityOptions();
            }
        }

        private void button_ws_Click(object sender, EventArgs e)
        {
            DisplaySecurityOptions();
        }

        private void SwitchUser()
        {
            command = "switch user";
            Close();
        }

        private void DisplaySecurityOptions()
        {
            WindowsSecurity ws = new WindowsSecurity(username, logonDate, DefaultPowerAction);
            Hide();
            ws.ShowDialog();
            Show();
            switch (ws.Command)
            {
                case "task manager":
                    System.Diagnostics.Process.Start("taskmgr.exe");
                    break;

                case "lock":
                    Lock();
                    break;

                case "switch user":
                    SwitchUser();
                    break;
                case "log off":
                case "sleep":
                case "shut down":
                case "restart":
                    command = ws.Command;
                    Close();
                    break;
            }
        }

        public void Lock()
        {
            if (CtrlAltDelReq)
            {
                CtrlAltDelLocked ctrlAltDel = new CtrlAltDelLocked(username);
                Hide();
                ctrlAltDel.ShowDialog();
                Show();
                if (ctrlAltDel.Command == "switch user")
                {
                    SwitchUser();
                }
            }
            else
            {
                Locked locked = new Locked(username);
                Hide();
                locked.ShowDialog();
                Show();
                if (locked.Command == "switch user")
                {
                    SwitchUser();
                }
            }
        }

        private void button_lock_Click(object sender, EventArgs e)
        {
            Lock();
        }

        private void button_switchUser_Click(object sender, EventArgs e)
        {
            SwitchUser();
        }

        private void button_logOff_Click(object sender, EventArgs e)
        {
            command = "log off";
            Close();
        }

        private void button_sleep_Click(object sender, EventArgs e)
        {
            command = "sleep";
            Close();
        }


        private void button_restart_Click(object sender, EventArgs e)
        {
            command = "restart";
            Close();
        }

        private void button_shutDown_Click(object sender, EventArgs e)
        {
            command = "shut down";
            Close();
        }

        private void button_shutDownDialogue_Click(object sender, EventArgs e)
        {
            ShutDownDialog shutDown = new ShutDownDialog(DefaultPowerAction, true);
            shutDown.ShowDialog();
            if (shutDown.Command != "")
            {
                command = shutDown.Command;
                Close();
            }
        }


        public string Command
        {
            get
            {
                return command;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public bool CtrlAltDelReq
        {
            get
            {
                return checkBox_ctrlAltDelReq.Checked;
            }
        }

        public bool DisplayLastUser
        {
            get
            {
                return checkBox_displayLastUser.Checked;
            }
        }

        public bool DisplayBackground
        {
            get
            {
                return checkBox_displayBackground.Checked;
            }
        }

        public bool LockAfterSleep
        {
            get
            {
                return checkBox_lockAfterSleep.Checked;
            }
        }

        public string DefaultPowerAction
        {
            get
            {
                switch (comboBox_defaultActions.SelectedIndex)
                {
                    case 0:
                        return "sleep";
                    case 1:
                        return "shut down";
                    default:
                        return "";
                }
            }
        }
    }
}
