using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Mart
{
    public partial class NotificationForm : CoreForm
    {
        private string paymentType = "";
        private string paymentCode = "";

        public NotificationForm(string paymentTypeParam, string paymentCodeParam)
        {
            InitializeComponent();

            this.paymentType = paymentTypeParam;
            this.paymentCode = paymentCodeParam;
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            lblNotifTop.Text = $"Your order has been submitted successfully.\nPlease continue the payment process in your\n{ paymentType } application.\n\nPlease input this code for the payment process.";
            lblPaymentCode.Text = paymentCode;

            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
