using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LKS_Mart
{
    public partial class ProfileForm : CoreForm
    {
        private AppDataController appDataController = new AppDataController();
        private LKSMartEntities db = new LKSMartEntities();
        private int customerID = -1;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            LoadData();
        }

        private void LoadData()
        {
            customerID = appDataController.GetAppData().LoginCustomerID;
            var customer = db.Customers.Where(x => x.id == customerID).ToList()[0];
            txtName.Text = customer.name;
            txtPhoneNumber.Text = customer.phone_number;
            txtEmail.Text = customer.email;
            txtPIN.Text = customer.pin_number;
            dtpDateOfBirth.Value = customer.date_of_birth.Value;
            txtAddress.Text = customer.address;
            comboGender.SelectedItem = customer.gender == null ? "Prefer not to say" : customer.gender;

            if (customer.profile_image_name == "" || customer.profile_image_name == null)
            {
                picBoxProfilePicture.ImageLocation = Application.StartupPath + "/images/profile_pictures/default_profile_picture.png";
            }
            else
            {
                picBoxProfilePicture.ImageLocation = Application.StartupPath + "/images/profile_pictures/" + customer.profile_image_name + ".png";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            lblErrorName.Visible = false;

            btnEditClick(txtName);
            if(txtName.Enabled == false)
            {
                // Finish edit name
                if(txtName.Text != "")
                {
                    var query = db.Customers.Find(customerID);
                    query.name = txtName.Text;
                    query.last_updated_at = DateTime.Now;

                    db.SaveChanges();
                }
                else
                {
                    lblErrorName.Text = "Fill up name ...";
                    lblErrorName.Visible = true;

                    txtName.Enabled = true;
                    txtName.Focus();
                }
            }
        }

        private void btnEditPIN_Click(object sender, EventArgs e)
        {
            lblErrorPIN.Visible = false;

            btnEditClick(txtPIN);
            if (txtPIN.Enabled == false)
            {
                // Finish edit PIN
                if(txtPIN.Text != "")
                {
                    if(txtPIN.Text.Length <= 6)
                    {
                        var query = db.Customers.Find(customerID);
                        query.pin_number = txtPIN.Text;
                        query.last_updated_at = DateTime.Now;

                        db.SaveChanges();
                    }
                    else
                    {
                        lblErrorPIN.Text = "PIN length must be below or equals to 6 ...";
                        lblErrorPIN.Visible = true;

                        txtPIN.Enabled = true;
                        txtPIN.Focus();
                    }
                }
                else
                {
                    lblErrorPIN.Text = "Fill up PIN ...";
                    lblErrorPIN.Visible = true;

                    txtPIN.Enabled = true;
                    txtPIN.Focus();
                }
            }
        }

        private void btnEditDateOfBirth_Click(object sender, EventArgs e)
        {
            lblErrorDateOfBirth.Visible = false;

            btnEditClick(dtpDateOfBirth);
            if (dtpDateOfBirth.Enabled == false)
            {
                // Finish edit date of birth
                if (dtpDateOfBirth.Value <= DateTime.Now)
                {
                    var query = db.Customers.Find(customerID);
                    query.date_of_birth = dtpDateOfBirth.Value;
                    query.last_updated_at = DateTime.Now;

                    db.SaveChanges();
                }
                else
                {
                    lblErrorDateOfBirth.Text = "Date of birth can't be in the future ...";
                    lblErrorDateOfBirth.Visible = true;

                    dtpDateOfBirth.Enabled = true;
                    dtpDateOfBirth.Focus();
                }
            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            btnEditClick(txtAddress);
            if (txtAddress.Enabled == false)
            {
                // Finish edit address
                var query = db.Customers.Find(customerID);
                if (txtAddress.Text != "")
                {
                    query.address = txtAddress.Text;
                }
                else
                {
                    query.address = null;
                }
                query.last_updated_at = DateTime.Now;

                db.SaveChanges();
            }
        }

        private void btnEditGender_Click(object sender, EventArgs e)
        {
            btnEditClick(comboGender);
            if (comboGender.Enabled == false)
            {
                // Finish edit gender
                var query = db.Customers.Find(customerID);
                if (comboGender.SelectedIndex != 0)
                {
                    query.gender = comboGender.SelectedItem.ToString();
                }
                else
                {
                    query.gender = null;
                }
                query.last_updated_at = DateTime.Now;

                db.SaveChanges();
            }
        }

        private void btnEditClick(Control controlToEnable)
        {
            if (controlToEnable.Enabled == true)
            {
                controlToEnable.Enabled = false;
            }
            else
            {
                controlToEnable.Enabled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var openFD = new OpenFileDialog()
            {
                Filter = "Image Files (*.png; *.jpg; *jpeg;)|*.png; *.jpg; *jpeg;"
            };

            if(openFD.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFD.FileName.Split('\\')[openFD.FileName.Split('\\').Length - 1];
                var fileNameWithoutExtension = fileName.Split('.')[0];

                File.Copy(openFD.FileName, Application.StartupPath + "/images/profile_pictures/" + fileNameWithoutExtension + ".png");

                var query = db.Customers.Find(customerID);
                query.profile_image_name = fileNameWithoutExtension;
                query.last_updated_at = DateTime.Now;

                db.SaveChanges();

                picBoxProfilePicture.ImageLocation = Application.StartupPath + "/images/profile_pictures/" + fileNameWithoutExtension + ".png";
            }
        }
    }
}
