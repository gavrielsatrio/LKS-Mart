using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LKS_Mart
{
    public partial class CoreForm : Form
    {
        private int beforeX;
        private int beforeY;

        public CoreForm()
        {
            InitializeComponent();
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {
            DrawButton(btnClose, Color.FromArgb(254, 94, 83));
            DrawButton(btnMinimize, Color.FromArgb(255, 191, 8));
            DrawButton(btnFullscreen, Color.FromArgb(21, 204, 56));
        }

        private void DrawButton(PictureBox picBox, Color color)
        {
            int size = 16;
            Bitmap btn = new Bitmap(size, size);

            Graphics canvas = Graphics.FromImage(btn);
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.FillEllipse(new SolidBrush(color), 0, 0, size, size);

            picBox.Image = btn;

            canvas.Dispose();
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - beforeX), this.Location.Y + (e.Y - beforeY));
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beforeX = e.X;
                beforeY = e.Y;
            }
        }
    }
}
