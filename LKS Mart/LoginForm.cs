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
        private LKSMartEntities db = new LKSMartEntities();

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPhoneEmail.Text != "")
            {
                if(txtPIN.Text != "")
                {
                    var getPIN = db.Customers.Where(x => x.email == txtPhoneEmail.Text || x.phone_number == txtPhoneEmail.Text).ToArray();

                    if(getPIN.Length > 0)
                    {
                        if(txtPIN.Text == getPIN[0].pin_number)
                        {
                            MessageBox.Show("Correct data ...");
                        }
                        else
                        {
                            MessageBox.Show("Login data invalid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login data invalid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up your PIN ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill up your email / phone number ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
