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
    public partial class DesktopWallpaper : Form
    {
        UserDesktop userDesktop;

        public DesktopWallpaper(UserDesktop userDesktop)
        {
            this.userDesktop = userDesktop;
            InitializeComponent();
        }

        private void DesktopWallpaper_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            userDesktop.ShowDialog();
            Close();
        }
    }
}
