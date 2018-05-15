using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Softeem
{
    public partial class PicViewForm : Form
    {
        private Image image = null;
        public PicViewForm(Image _image)
        {
            this.image = _image;
            InitializeComponent();

        }

        private void PicViewForm_Load(object sender, EventArgs e)
        {
            
            this.pictureBox1.Image = image;
            
        }
        int x,y;
       
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int lengx, lengy;
            if (e.Button == MouseButtons.Left)
            {
                lengx = e.X - this.x;
                lengy = e.Y - this.y;
                this.Left += lengx;
                this.Top += lengy;
            }
        }
    }
}
