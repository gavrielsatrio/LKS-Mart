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
        private string windowStatus;

        public CoreForm()
        {
            InitializeComponent();
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {
            DrawButton(btnClose, Color.FromArgb(254, 94, 83), Color.FromArgb(219, 120, 113));
            DrawButton(btnMinimize, Color.FromArgb(255, 191, 8), Color.FromArgb(227, 173, 27));
            DrawButton(btnFullscreen, Color.FromArgb(21, 204, 56), Color.FromArgb(39, 186, 67));

            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void DrawButton(PictureBox picBox, Color color, Color colorBorder)
        {
            int size = 14;
            Bitmap btn = new Bitmap(size + 4, size + 4);

            Graphics canvas = Graphics.FromImage(btn);
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.FillEllipse(new SolidBrush(color), 0, 0, size, size);
            canvas.DrawEllipse(new Pen(colorBorder), 0, 0, size, size);

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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beforeX = e.X;
                beforeY = e.Y;
            }
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - beforeX), this.Location.Y + (e.Y - beforeY));
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if(windowStatus != "Maximize")
            {
                windowStatus = "Minimize";
            }
            this.WindowState = FormWindowState.Minimized;

            //timerMinimize.Start();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if(windowStatus == "Maximize")
            {
                windowStatus = "Normal";
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                windowStatus = "Maximize";
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CoreForm_Resize(object sender, EventArgs e)
        {
            //if(windowStatus == "Minimize" && this.WindowState == FormWindowState.Minimized)
            //{
            //    MessageBox.Show("Test");
            //}
        }

        private void timerMinimize_Tick(object sender, EventArgs e)
        {
            if(this.Size.Height >= 50)
            {
                int reduction = 20;

                this.Size = new Size(this.Size.Width - reduction, this.Size.Height - reduction);
                this.Location = new Point(this.Location.X + (reduction / 2), this.Location.Y + reduction);
            }
            else
            {
                timerMinimize.Stop();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void timerNormal_Tick(object sender, EventArgs e)
        {
            int addition = 8;

            this.Size = new Size(this.Size.Width + addition, this.Size.Height + addition);
            this.Location = new Point(this.Location.X - (addition / 2), this.Location.Y - addition);
        }
    }
}
