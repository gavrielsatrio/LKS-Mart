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
    public partial class LoginForm : CoreForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhoneEmail_Enter(object sender, EventArgs e)
        {
            lblPlaceholderPhoneEmail.Visible = false;
        }

        private void txtPhoneEmail_Leave(object sender, EventArgs e)
        {
            SetPlaceholderStateBasedOnTextBox(txtPhoneEmail, lblPlaceholderPhoneEmail);
        }

        private void txtPIN_Enter(object sender, EventArgs e)
        {
            lblPlaceholderPIN.Visible = false;
        }

        private void txtPIN_Leave(object sender, EventArgs e)
        {
            SetPlaceholderStateBasedOnTextBox(txtPIN, lblPlaceholderPIN);
        }

        private void SetPlaceholderStateBasedOnTextBox(TextBox txt, Label lbl)
        {
            if(txt.Text == "")
            {
                lbl.Visible = true;
            }
            else
            {
                lbl.Visible = false;
            }
        }
    }
}
