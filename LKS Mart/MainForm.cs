using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Mart
{
    public partial class MainForm : CoreForm
    {
        public int customerID = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            lblDatetime.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss");
            timerDatetime.Start();

            //DrawOrnament();
        }

        private void DrawOrnament()
        {
            int width = 400;
            int height = 200;

            Bitmap ornament = new Bitmap(width + 4, height + 4);

            Graphics canvas = Graphics.FromImage(ornament);
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.FillEllipse(new SolidBrush(Color.FromArgb(255, 255, 255)), -50, -60, width + 50, height + 60);

            picBoxTopLeftOrnament.Image = ornament;
            canvas.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void timerDatetime_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss");
        }
    }
}
