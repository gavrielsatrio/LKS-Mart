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
using System.Text.Json;
using System.IO;

namespace LKS_Mart
{
    public partial class LoginForm : CoreForm
    {
        private LKSMartEntities db = new LKSMartEntities();
        private AppDataController appDataController = new AppDataController();
        private Color defaultBackgroundColor = Color.FromArgb(255, 250, 250, 250);
        private Color defaultPlaceholderColor = Color.FromArgb(255, 80, 80, 80);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            appDataController.CreateAppDataFile();

            lblHeader.ForeColor = defaultBackgroundColor;
            timerHeader.Start();

            panelPhoneEmail.BackColor = defaultBackgroundColor;
            txtPhoneEmail.BackColor = defaultBackgroundColor;
            lblPlaceholderPhoneEmail.ForeColor = defaultBackgroundColor;

            panelPIN.BackColor = defaultBackgroundColor;
            txtPIN.BackColor = defaultBackgroundColor;
            lblPlaceholderPIN.ForeColor = defaultBackgroundColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhoneEmail_Enter(object sender, EventArgs e)
        {
            timerPlaceholderPhoneEmailDown.Stop();
            timerPlaceholderPhoneEmailUp.Start();
        }

        private void txtPhoneEmail_Leave(object sender, EventArgs e)
        {
            timerPlaceholderPhoneEmailUp.Stop();
            SetPlaceholderStateBasedOnTextBox(panelPhoneEmail, txtPhoneEmail, lblPlaceholderPhoneEmail);
        }

        private void txtPIN_Enter(object sender, EventArgs e)
        {
            timerPlaceholderPINDown.Stop();
            timerPlaceholderPINUp.Start();
        }

        private void txtPIN_Leave(object sender, EventArgs e)
        {
            timerPlaceholderPINUp.Stop();
            SetPlaceholderStateBasedOnTextBox(panelPIN, txtPIN, lblPlaceholderPIN);
        }

        private void SetPlaceholderStateBasedOnTextBox(Panel panel, TextBox txt, Label lbl)
        {
            if(txt.Text == "")
            {
                // Empty field
                // lbl.Location = new Point(panel.Location.X, panel.Location.Y + 7);

                if(lbl.Name.Contains("PhoneEmail"))
                {
                    timerPlaceholderPhoneEmailDown.Start();
                }
                else
                {
                    timerPlaceholderPINDown.Start();
                }
            }
            else
            {
                // Filled field
                // lbl.Location = new Point(panel.Location.X, panel.Location.Y - 18);

                if(lbl.Name.Contains("PhoneEmail"))
                {
                    timerPlaceholderPhoneEmailUp.Start();
                }
                else
                {
                    timerPlaceholderPINUp.Start();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPhoneEmail.Text != "")
            {
                if(txtPIN.Text != "")
                {
                    var getPIN = db.Customers.Where(x => (x.email == txtPhoneEmail.Text || x.phone_number == txtPhoneEmail.Text) && x.deleted_at == null).ToArray();

                    if(getPIN.Length > 0)
                    {
                        if(txtPIN.Text == getPIN[0].pin_number)
                        {
                            LogUserIn(getPIN[0].id);
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

        private void panelPhoneEmail_Click(object sender, EventArgs e)
        {
            txtPhoneEmail.Focus();
        }

        private void lblPlaceholderPhoneEmail_Click(object sender, EventArgs e)
        {
            txtPhoneEmail.Focus();
        }

        private void panelPIN_Click(object sender, EventArgs e)
        {
            txtPIN.Focus();
        }

        private void lblPlaceholderPIN_Click(object sender, EventArgs e)
        {
            txtPIN.Focus();
        }

        private void LogUserIn(int customerID)
        {
            appDataController.LoginCustomer(customerID);

            this.Hide();
            new MainForm().Show();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if(appDataController.GetAppData().LoginCustomerID != -1)
            {
                LogUserIn(appDataController.GetAppData().LoginCustomerID);
            }
        }

        private void timerHeader_Tick(object sender, EventArgs e)
        {
            if(lblHeader.Location.Y == 48)
            {
                timerHeader.Stop();
                timerPhoneEmail.Start();
                timerPlaceholderPhoneEmailDown.Start();
            }
            else
            {
                lblHeader.Location = new Point(lblHeader.Location.X, lblHeader.Location.Y + 1);

                int colorChanges = lblHeader.ForeColor.R;
                int colorReduction = 7;
                if(colorChanges - colorReduction < 0)
                {
                    colorChanges = 0;
                }
                else
                {
                    colorChanges -= colorReduction;
                }

                lblHeader.ForeColor = Color.FromArgb(lblHeader.ForeColor.A, colorChanges, colorChanges, colorChanges);
            }
        }

        private void timerPhoneEmail_Tick(object sender, EventArgs e)
        {
            if(panelPhoneEmail.Location.X == 48)
            {
                timerPhoneEmail.Stop();
                timerPIN.Start();
                timerPlaceholderPINDown.Start();
            }
            else
            {
                int colorAddition = 2;
                int colorReduction = 11;
                int colorChangesBackground = panelPhoneEmail.BackColor.R;
                int colorChangesForeground = lblPlaceholderPhoneEmail.ForeColor.R;

                if(colorChangesBackground + colorAddition > 255)
                {
                    colorChangesBackground = 255;
                }
                else
                {
                    colorChangesBackground += colorAddition;
                }

                
                if(colorChangesForeground - colorReduction < 80)
                {
                    colorChangesForeground = 80;
                }
                else
                {
                    colorChangesForeground -= colorReduction;
                }

                panelPhoneEmail.BackColor = Color.FromArgb(panelPhoneEmail.BackColor.A, colorChangesBackground, colorChangesBackground, colorChangesBackground);
                txtPhoneEmail.BackColor = Color.FromArgb(txtPhoneEmail.BackColor.A, colorChangesBackground, colorChangesBackground, colorChangesBackground);
                lblPlaceholderPhoneEmail.ForeColor = Color.FromArgb(lblPlaceholderPhoneEmail.ForeColor.A, colorChangesForeground, colorChangesForeground, colorChangesForeground);

                panelPhoneEmail.Location = new Point(panelPhoneEmail.Location.X + 1, panelPhoneEmail.Location.Y);
            }
        }

        private void timerPIN_Tick(object sender, EventArgs e)
        {
            if(panelPIN.Location.X == 48)
            {
                timerPIN.Stop();
                txtPhoneEmail.Focus();
            }
            else
            {
                int colorAddition = 2;
                int colorReduction = 11;
                int colorChangesBackground = panelPIN.BackColor.R;
                int colorChangesForeground = lblPlaceholderPIN.ForeColor.R;

                if(colorChangesBackground + colorAddition > 255)
                {
                    colorChangesBackground = 255;
                }
                else
                {
                    colorChangesBackground += colorAddition;
                }

                if (colorChangesForeground - colorReduction < 80)
                {
                    colorChangesForeground = 80;
                }
                else
                {
                    colorChangesForeground -= colorReduction;
                }

                panelPIN.BackColor = Color.FromArgb(panelPIN.BackColor.A, colorChangesBackground, colorChangesBackground, colorChangesBackground);
                txtPIN.BackColor = Color.FromArgb(txtPIN.BackColor.A, colorChangesBackground, colorChangesBackground, colorChangesBackground);
                lblPlaceholderPIN.ForeColor = Color.FromArgb(lblPlaceholderPIN.ForeColor.A, colorChangesForeground, colorChangesForeground, colorChangesForeground);

                panelPIN.Location = new Point(panelPIN.Location.X + 1, panelPIN.Location.Y);
            }
        }

        private void timerPlaceholderPhoneEmailUp_Tick(object sender, EventArgs e)
        {
            if(lblPlaceholderPhoneEmail.Location.Y == 109)
            {
                timerPlaceholderPhoneEmailUp.Stop();
            }
            else
            {
                lblPlaceholderPhoneEmail.Location = new Point(lblPlaceholderPhoneEmail.Location.X - 1 > 48 ? lblPlaceholderPhoneEmail.Location.X - 1 : 48, lblPlaceholderPhoneEmail.Location.Y - 1);
                lblPlaceholderPhoneEmail.BackColor = defaultBackgroundColor;
            }
        }

        private void timerPlaceholderPINUp_Tick(object sender, EventArgs e)
        {
            if(lblPlaceholderPIN.Location.Y == 169)
            {
                timerPlaceholderPINUp.Stop();
            }
            else
            {
                lblPlaceholderPIN.Location = new Point(lblPlaceholderPIN.Location.X - 1 > 48 ? lblPlaceholderPIN.Location.X - 1 : 48, lblPlaceholderPIN.Location.Y - 1);
                lblPlaceholderPIN.BackColor = defaultBackgroundColor;
            }
        }

        private void timerPlaceholderPhoneEmailDown_Tick(object sender, EventArgs e)
        {
            if(lblPlaceholderPhoneEmail.Location.Y == 134)
            {
                timerPlaceholderPhoneEmailDown.Stop();
            }
            else
            {
                lblPlaceholderPhoneEmail.Location = new Point(lblPlaceholderPhoneEmail.Location.X + 1 < 56 ? lblPlaceholderPhoneEmail.Location.X + 1 : 56, lblPlaceholderPhoneEmail.Location.Y + 1);
                lblPlaceholderPhoneEmail.BackColor = Color.FromArgb(255, 255, 255, 255);
            }
        }

        private void timerPlaceholderPINDown_Tick(object sender, EventArgs e)
        {
            if(lblPlaceholderPIN.Location.Y == 194)
            {
                timerPlaceholderPINDown.Stop();
            }
            else
            {
                lblPlaceholderPIN.Location = new Point(lblPlaceholderPIN.Location.X + 1 < 56 ? lblPlaceholderPIN.Location.X + 1 : 56, lblPlaceholderPIN.Location.Y + 1);
                lblPlaceholderPIN.BackColor = Color.FromArgb(255, 255, 255, 255);
            }
        }
    }
}
