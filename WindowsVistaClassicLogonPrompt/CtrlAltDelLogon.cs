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
    public partial class CtrlAltDelLogon : Form
    {
        public CtrlAltDelLogon()
        {
            InitializeComponent();
        }

        private void CtrlAltDelLogon_Load(object sender, EventArgs e)
        {

        }

        private void CtrlAltDelLogon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Close();
            }
        }
    }
}
