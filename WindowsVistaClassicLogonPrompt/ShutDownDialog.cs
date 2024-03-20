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
    public partial class ShutDownDialog : Form
    {
        private string command = "";
        private bool loggedIn;
        private string defaultAction;

        public ShutDownDialog(string defaultAction, bool loggedIn)
        {
            this.loggedIn = loggedIn;
            this.defaultAction = defaultAction;
            InitializeComponent();
        }

        private void ShutDownDialog_Load(object sender, EventArgs e)
        {
            switch (defaultAction)
            {
                case "sleep":
                    comboBox_Actions.SelectedIndex = 3;
                    break;
                case "shut down":
                    comboBox_Actions.SelectedIndex = 4;
                    break;

            }
            if (!loggedIn)
            {
                comboBox_Actions.Items.Remove("Switch User");
                comboBox_Actions.Items.Remove("Log off");
            }
        }

        private void comboBox_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Actions.Text)
            {
                case "Switch User":
                    label_description.Text = "Lets another user log on while your programs and files remain open.";
                    break;
                case "Log off":
                    label_description.Text = "Ends your session, leaving the computer running on full power.";
                    break;
                case "Sleep":
                    label_description.Text = "Keeps your session in memory and puts the computer in a low-power state so that you can quickly resume working.";
                    break;
                case "Shut Down":
                    label_description.Text = "Closes all open programs, shuts down Windows, and then turns off your computer.";
                    break;
                case "Restart":
                    label_description.Text = "Closes all open programs, shuts down Windows, and then starts Windows again.";
                    break;
                default:
                    label_description.Text = "";
                    break;
            }
            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            command = comboBox_Actions.Text.ToLower();
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
