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
    public partial class ChangePassword : Form
    {
        private string username;

        public ChangePassword(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            textBox_username.Text = username;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_newPassword.Text == textBox_Confirm.Text)
            {
                MessageBox.Show("Your password has been changed.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("The passwords you typed did not match. Type the new password in both text boxes.",
                    "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_backup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your computer does not have a removable disk drive. A removable medium is required to use this feature.", 
                "No Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
