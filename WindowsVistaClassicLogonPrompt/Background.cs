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
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(1920, 1200);
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            pictureBox1.Size = new Size(screenWidth, (screenWidth / 8) * 5);

            if (((double)screenWidth / screenHeight) < (8.0 / 5.0))
            {
                pictureBox1.Size = new Size((screenHeight / 5) * 8, screenHeight);
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            int x = screenWidth / 2;
            int y = screenHeight / 2;
            x -= pictureBox1.Size.Width / 2;
            y -= pictureBox1.Size.Height / 2;
            pictureBox1.Location = new Point(x, y);
            LoadingWindow lw = new LoadingWindow();
            lw.ShowDialog();
            Close();
        }
    }
}
