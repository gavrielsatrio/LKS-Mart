
namespace LKS_Mart
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.picBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblErrorDateOfBirth = new System.Windows.Forms.Label();
            this.lblErrorPIN = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.btnEditGender = new System.Windows.Forms.PictureBox();
            this.btnEditAddress = new System.Windows.Forms.PictureBox();
            this.btnEditDateOfBirth = new System.Windows.Forms.PictureBox();
            this.btnEditPIN = new System.Windows.Forms.PictureBox();
            this.btnEditName = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblProfilePicture = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.comboGender);
            this.panelContent.Controls.Add(this.dtpDateOfBirth);
            this.panelContent.Controls.Add(this.picBoxProfilePicture);
            this.panelContent.Controls.Add(this.lblErrorDateOfBirth);
            this.panelContent.Controls.Add(this.lblErrorPIN);
            this.panelContent.Controls.Add(this.lblErrorName);
            this.panelContent.Controls.Add(this.btnEditGender);
            this.panelContent.Controls.Add(this.btnEditAddress);
            this.panelContent.Controls.Add(this.btnEditDateOfBirth);
            this.panelContent.Controls.Add(this.btnEditPIN);
            this.panelContent.Controls.Add(this.btnEditName);
            this.panelContent.Controls.Add(this.txtAddress);
            this.panelContent.Controls.Add(this.lblProfilePicture);
            this.panelContent.Controls.Add(this.lblGender);
            this.panelContent.Controls.Add(this.lblAddress);
            this.panelContent.Controls.Add(this.txtPIN);
            this.panelContent.Controls.Add(this.lblDateOfBirth);
            this.panelContent.Controls.Add(this.txtEmail);
            this.panelContent.Controls.Add(this.lblPIN);
            this.panelContent.Controls.Add(this.txtPhoneNumber);
            this.panelContent.Controls.Add(this.lblEmail);
            this.panelContent.Controls.Add(this.txtName);
            this.panelContent.Controls.Add(this.lblPhoneNumber);
            this.panelContent.Controls.Add(this.btnUpload);
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Controls.Add(this.lblProfile);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 480);
            this.panelContent.TabIndex = 0;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Enabled = false;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Prefer not to say",
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(120, 302);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(300, 23);
            this.comboGender.TabIndex = 6;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(120, 193);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(300, 22);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // picBoxProfilePicture
            // 
            this.picBoxProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePicture.Image")));
            this.picBoxProfilePicture.Location = new System.Drawing.Point(120, 334);
            this.picBoxProfilePicture.Name = "picBoxProfilePicture";
            this.picBoxProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.picBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfilePicture.TabIndex = 12;
            this.picBoxProfilePicture.TabStop = false;
            // 
            // lblErrorDateOfBirth
            // 
            this.lblErrorDateOfBirth.AutoSize = true;
            this.lblErrorDateOfBirth.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDateOfBirth.Location = new System.Drawing.Point(460, 196);
            this.lblErrorDateOfBirth.Name = "lblErrorDateOfBirth";
            this.lblErrorDateOfBirth.Size = new System.Drawing.Size(31, 15);
            this.lblErrorDateOfBirth.TabIndex = 11;
            this.lblErrorDateOfBirth.Text = "Error";
            this.lblErrorDateOfBirth.Visible = false;
            // 
            // lblErrorPIN
            // 
            this.lblErrorPIN.AutoSize = true;
            this.lblErrorPIN.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPIN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPIN.Location = new System.Drawing.Point(460, 168);
            this.lblErrorPIN.Name = "lblErrorPIN";
            this.lblErrorPIN.Size = new System.Drawing.Size(31, 15);
            this.lblErrorPIN.TabIndex = 11;
            this.lblErrorPIN.Text = "Error";
            this.lblErrorPIN.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(460, 84);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(31, 15);
            this.lblErrorName.TabIndex = 11;
            this.lblErrorName.Text = "Error";
            this.lblErrorName.Visible = false;
            // 
            // btnEditGender
            // 
            this.btnEditGender.Image = ((System.Drawing.Image)(resources.GetObject("btnEditGender.Image")));
            this.btnEditGender.Location = new System.Drawing.Point(426, 302);
            this.btnEditGender.Name = "btnEditGender";
            this.btnEditGender.Size = new System.Drawing.Size(22, 22);
            this.btnEditGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditGender.TabIndex = 10;
            this.btnEditGender.TabStop = false;
            this.btnEditGender.Click += new System.EventHandler(this.btnEditGender_Click);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAddress.Image")));
            this.btnEditAddress.Location = new System.Drawing.Point(426, 221);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(22, 22);
            this.btnEditAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditAddress.TabIndex = 10;
            this.btnEditAddress.TabStop = false;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnEditDateOfBirth
            // 
            this.btnEditDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDateOfBirth.Image")));
            this.btnEditDateOfBirth.Location = new System.Drawing.Point(426, 193);
            this.btnEditDateOfBirth.Name = "btnEditDateOfBirth";
            this.btnEditDateOfBirth.Size = new System.Drawing.Size(22, 22);
            this.btnEditDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditDateOfBirth.TabIndex = 10;
            this.btnEditDateOfBirth.TabStop = false;
            this.btnEditDateOfBirth.Click += new System.EventHandler(this.btnEditDateOfBirth_Click);
            // 
            // btnEditPIN
            // 
            this.btnEditPIN.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPIN.Image")));
            this.btnEditPIN.Location = new System.Drawing.Point(426, 165);
            this.btnEditPIN.Name = "btnEditPIN";
            this.btnEditPIN.Size = new System.Drawing.Size(22, 22);
            this.btnEditPIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditPIN.TabIndex = 10;
            this.btnEditPIN.TabStop = false;
            this.btnEditPIN.Click += new System.EventHandler(this.btnEditPIN_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Image = ((System.Drawing.Image)(resources.GetObject("btnEditName.Image")));
            this.btnEditName.Location = new System.Drawing.Point(426, 81);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(22, 22);
            this.btnEditName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditName.TabIndex = 10;
            this.btnEditName.TabStop = false;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(120, 221);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 75);
            this.txtAddress.TabIndex = 5;
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.Location = new System.Drawing.Point(32, 334);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(80, 15);
            this.lblProfilePicture.TabIndex = 6;
            this.lblProfilePicture.Text = "Profile Picture";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(32, 305);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 224);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtPIN
            // 
            this.txtPIN.Enabled = false;
            this.txtPIN.Location = new System.Drawing.Point(120, 165);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(300, 22);
            this.txtPIN.TabIndex = 3;
            this.txtPIN.UseSystemPasswordChar = true;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(28, 196);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(73, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(120, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(28, 168);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(25, 15);
            this.lblPIN.TabIndex = 6;
            this.lblPIN.Text = "PIN";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 109);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(300, 22);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(120, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(28, 112);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(86, 15);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.Black;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(232, 404);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 30);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(670, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Black;
            this.lblProfile.Location = new System.Drawing.Point(25, 23);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(97, 33);
            this.lblProfile.TabIndex = 5;
            this.lblProfile.Text = "Profile";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panelContent);
            this.Name = "ProfileForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox btnEditName;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblErrorDateOfBirth;
        private System.Windows.Forms.Label lblErrorPIN;
        private System.Windows.Forms.PictureBox btnEditAddress;
        private System.Windows.Forms.PictureBox btnEditDateOfBirth;
        private System.Windows.Forms.PictureBox btnEditPIN;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.PictureBox btnEditGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblProfilePicture;
        private System.Windows.Forms.PictureBox picBoxProfilePicture;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox comboGender;
    }
}