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
    public partial class LoadingWindow : Form
    {
        private string currentAction = "starting up";
        private string username = "";
        private DateTime logonDate;
        private string[] loggedOnUsers = new string[256];
        private bool restart = false;
        private bool shutDown = false;
        private bool ctrlAltDelReq = false;
        private bool displayLastUser = true;
        private bool lockAfterSleep = true;
        private bool displayBackground = false;
        private string defaultPowerAction = "shut down";

        public LoadingWindow()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("Save.txt");
                username = lines[0];
                ctrlAltDelReq = bool.Parse(lines[1]);
                displayLastUser = bool.Parse(lines[2]);
                lockAfterSleep = bool.Parse(lines[3]);
                displayBackground = bool.Parse(lines[4]);
                defaultPowerAction = lines[5];
            }
            catch { }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = { false.ToString() };
            string[] usersLoggedOn = new string[256];
            try
            {
                lines = System.IO.File.ReadAllLines("Hiberfile.txt");
                usersLoggedOn = lines = System.IO.File.ReadAllLines("LoggedOnUsers.txt");
            }
            catch { }

            try
            {
                if (System.IO.File.Exists("Hiberfile.txt"))
                {
                    System.IO.File.Delete("Hiberfile.txt");
                }
            }
            catch { }

            try
            {
                if (System.IO.File.Exists("LoggonOnUsers.txt"))
                {
                    System.IO.File.Delete("LoggonOnUsers.txt");
                }
            }
            catch { }

            bool sleep = false;
            string lastUser = "SYSTEM";
            try
            {
                sleep = bool.Parse(lines[0]);
                lastUser = lines[1];
            }
            catch { }
            if (lastUser == "" || lastUser == null)
            {
                sleep = false;
            }

            if (sleep)
            {
                try
                {
                    logonDate = new DateTime(int.Parse(lines[2]), int.Parse(lines[3]), int.Parse(lines[4])
                        , int.Parse(lines[5]), int.Parse(lines[6]), int.Parse(lines[7]));
                }
                catch
                {
                    logonDate = DateTime.Now;
                }

                loggedOnUsers = usersLoggedOn;
                if (lastUser.ToUpper() == "SYSTEM")
                {
                    DisplayLogonPrompt();
                }
                else
                {
                    username = lastUser;
                    Logon(lockAfterSleep);
                }
            }
            else
            {
                SetAction("starting up");
            }
            
        }

        private void SetAction(string action)
        {
            currentAction = action;
            label_loadingText.Text = "Windows is " + action + "...";
            switch (action)
            {
                case "starting up":
                    timer_startingUp.Start();
                    break;

                case "shutting down":
                    timer_shuttingDown.Start();
                    break;

                case "logging on":
                    if (loggedOnUsers.Contains(username))
                    {
                        Logon();
                    }
                    else
                    {
                        timer_loggingOn.Start();
                    }
                    break;

                case "logging off":
                    timer_loggingOff.Start();
                    break;
            }
        }

        private void timer_startingUp_Tick(object sender, EventArgs e)
        {
            timer_startingUp.Stop();
            DisplayLogonPrompt();
        }

        private void timer_shuttingDown_Tick(object sender, EventArgs e)
        {
            Save();
            if (restart)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void timer_loggingOn_Tick(object sender, EventArgs e)
        {
            timer_loggingOn.Stop();
            logonDate = DateTime.Now;
            for (int i = 0; i < loggedOnUsers.Length; i++)
            {
                if (loggedOnUsers[i] == username)
                {
                    break;
                }
                if (loggedOnUsers[i] == null)
                {
                    loggedOnUsers[i] = username;
                    break;
                }
            }
            Logon();
        }

        private void Logon(bool lock_ = false)
        {
            UserDesktop userDesktop = new UserDesktop(
                username, logonDate, ctrlAltDelReq, displayBackground, displayLastUser, lockAfterSleep, defaultPowerAction, lock_);

            if (displayBackground)
            {
                DesktopWallpaper wallpaper = new DesktopWallpaper(userDesktop);
                Hide();
                wallpaper.ShowDialog();
            }
            else
            {
                Hide();
                userDesktop.ShowDialog();
            }
            Show();
            ctrlAltDelReq = userDesktop.CtrlAltDelReq;
            displayLastUser = userDesktop.DisplayLastUser;
            if (!displayLastUser)
            {
                username = "";
            }
            displayBackground = userDesktop.DisplayBackground;
            lockAfterSleep = userDesktop.LockAfterSleep;
            defaultPowerAction = userDesktop.DefaultPowerAction;
            switch (userDesktop.Command)
            {
                case "switch user":
                    DisplayLogonPrompt();
                    break;

                case "log off":
                    for (int i = 0; i < loggedOnUsers.Length; i++)
                    {
                        if (loggedOnUsers[i] == userDesktop.Username)
                        {
                            loggedOnUsers[i] = null;
                        }
                    }
                    SetAction("logging off");
                    break;

                case "shut down":
                    shutDown = true;
                    SetAction("logging off");
                    break;

                case "restart":
                    shutDown = true;
                    restart = true;
                    SetAction("logging off");
                    break;

                case "sleep":
                    Sleep(userDesktop.Username);
                    break;
            }
        }

        private void DisplayLogonPrompt()
        {
            LogonPrompt logonPrompt = new LogonPrompt(username, defaultPowerAction, ctrlAltDelReq);
            Hide();
            logonPrompt.ShowDialog();
            Show();
            switch (logonPrompt.Command)
            {
                case "log on":
                    username = logonPrompt.Username;
                    SetAction("logging on");
                    break;

                case "shut down":
                    SetAction("shutting down");
                    break;

                case "restart":
                    restart = true;
                    SetAction("shutting down");
                    break;

                case "sleep":
                    Sleep("SYSTEM");
                    break;
            }
        }

        private void timer_loggingOff_Tick(object sender, EventArgs e)
        {
            timer_loggingOff.Stop();
            if (shutDown)
            {
                SetAction("shutting down");
            }
            else
            {
                DisplayLogonPrompt();
            }
        }

        private void Save()
        {
            string[] lines = {username,
                ctrlAltDelReq.ToString(),
                displayLastUser.ToString(),
                lockAfterSleep.ToString(),
                displayBackground.ToString(),
                defaultPowerAction};
            try
            {
                System.IO.File.WriteAllLines("Save.txt", lines);
            }
            catch { }
        }

        private void Sleep(string currentUser)
        {
            Save();
            try
            {
                System.IO.File.WriteAllLines("Hiberfile.txt", new string[] {true.ToString(), currentUser,
                    logonDate.Year.ToString(), logonDate.Month.ToString(),logonDate.Day.ToString(),
                    logonDate.Hour.ToString(), logonDate.Minute.ToString(), logonDate.Second.ToString()});
                System.IO.File.WriteAllLines("LoggonOnUsers.txt", loggedOnUsers);
            }
            catch { }
            Application.Exit();
        }

    }
}
