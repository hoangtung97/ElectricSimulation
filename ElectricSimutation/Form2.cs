using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricSimutation
{
    public partial class Form2 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\Video3d\Box01.avi";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_fullscreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_fullscreen.Visible = false;
            btn_restoredown.Visible = true;
        }

        private void btn_restoredown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_fullscreen.Visible = true;
            btn_restoredown.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
