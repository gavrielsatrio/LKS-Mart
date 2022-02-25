
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEditName = new System.Windows.Forms.PictureBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnEditPIN = new System.Windows.Forms.PictureBox();
            this.lblErrorPIN = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnEditDateOfBirth = new System.Windows.Forms.PictureBox();
            this.lblErrorDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnEditAddress = new System.Windows.Forms.PictureBox();
            this.btnEditGender = new System.Windows.Forms.PictureBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblProfilePicture = new System.Windows.Forms.Label();
            this.picBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.comboGender);
            this.panelContent.Controls.Add(this.dateTimePicker1);
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
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 480);
            this.panelContent.TabIndex = 5;
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(25, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(97, 33);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Profile";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(673, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 22);
            this.txtName.TabIndex = 9;
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 109);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(300, 22);
            this.txtPhoneNumber.TabIndex = 9;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 9;
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
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(120, 165);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(300, 22);
            this.txtPIN.TabIndex = 9;
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
            // btnEditDateOfBirth
            // 
            this.btnEditDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDateOfBirth.Image")));
            this.btnEditDateOfBirth.Location = new System.Drawing.Point(426, 193);
            this.btnEditDateOfBirth.Name = "btnEditDateOfBirth";
            this.btnEditDateOfBirth.Size = new System.Drawing.Size(22, 22);
            this.btnEditDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditDateOfBirth.TabIndex = 10;
            this.btnEditDateOfBirth.TabStop = false;
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 221);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 75);
            this.txtAddress.TabIndex = 9;
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
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.Location = new System.Drawing.Point(32, 334);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(80, 15);
            this.lblProfilePicture.TabIndex = 6;
            this.lblProfilePicture.Text = "Profile Picture";
            // 
            // picBoxProfilePicture
            // 
            this.picBoxProfilePicture.Location = new System.Drawing.Point(120, 334);
            this.picBoxProfilePicture.Name = "picBoxProfilePicture";
            this.picBoxProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.picBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfilePicture.TabIndex = 12;
            this.picBoxProfilePicture.TabStop = false;
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
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(120, 302);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(300, 23);
            this.comboGender.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboGender;
    }
}