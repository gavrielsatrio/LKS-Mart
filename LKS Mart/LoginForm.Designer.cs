
namespace LKS_Mart
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelPIN = new System.Windows.Forms.Panel();
            this.lblPlaceholderPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.panelPhoneEmail = new System.Windows.Forms.Panel();
            this.lblPlaceholderPhoneEmail = new System.Windows.Forms.Label();
            this.txtPhoneEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            this.panelPIN.SuspendLayout();
            this.panelPhoneEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(482, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelPIN);
            this.panelContent.Controls.Add(this.panelPhoneEmail);
            this.panelContent.Controls.Add(this.btnLogin);
            this.panelContent.Controls.Add(this.lblHeader);
            this.panelContent.Controls.Add(this.picBoxLogo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(500, 360);
            this.panelContent.TabIndex = 3;
            // 
            // panelPIN
            // 
            this.panelPIN.BackColor = System.Drawing.Color.White;
            this.panelPIN.Controls.Add(this.lblPlaceholderPIN);
            this.panelPIN.Controls.Add(this.txtPIN);
            this.panelPIN.Location = new System.Drawing.Point(48, 153);
            this.panelPIN.Name = "panelPIN";
            this.panelPIN.Padding = new System.Windows.Forms.Padding(6, 7, 6, 6);
            this.panelPIN.Size = new System.Drawing.Size(236, 30);
            this.panelPIN.TabIndex = 4;
            // 
            // lblPlaceholderPIN
            // 
            this.lblPlaceholderPIN.AutoSize = true;
            this.lblPlaceholderPIN.BackColor = System.Drawing.Color.White;
            this.lblPlaceholderPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblPlaceholderPIN.Location = new System.Drawing.Point(9, 7);
            this.lblPlaceholderPIN.Name = "lblPlaceholderPIN";
            this.lblPlaceholderPIN.Size = new System.Drawing.Size(70, 15);
            this.lblPlaceholderPIN.TabIndex = 4;
            this.lblPlaceholderPIN.Text = "PIN Number";
            this.lblPlaceholderPIN.Click += new System.EventHandler(this.lblPlaceholderPIN_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPIN.Location = new System.Drawing.Point(6, 7);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(224, 15);
            this.txtPIN.TabIndex = 0;
            this.txtPIN.UseSystemPasswordChar = true;
            this.txtPIN.Enter += new System.EventHandler(this.txtPIN_Enter);
            this.txtPIN.Leave += new System.EventHandler(this.txtPIN_Leave);
            // 
            // panelPhoneEmail
            // 
            this.panelPhoneEmail.BackColor = System.Drawing.Color.White;
            this.panelPhoneEmail.Controls.Add(this.lblPlaceholderPhoneEmail);
            this.panelPhoneEmail.Controls.Add(this.txtPhoneEmail);
            this.panelPhoneEmail.Location = new System.Drawing.Point(48, 111);
            this.panelPhoneEmail.Name = "panelPhoneEmail";
            this.panelPhoneEmail.Padding = new System.Windows.Forms.Padding(6, 7, 6, 6);
            this.panelPhoneEmail.Size = new System.Drawing.Size(236, 30);
            this.panelPhoneEmail.TabIndex = 3;
            // 
            // lblPlaceholderPhoneEmail
            // 
            this.lblPlaceholderPhoneEmail.AutoSize = true;
            this.lblPlaceholderPhoneEmail.BackColor = System.Drawing.Color.White;
            this.lblPlaceholderPhoneEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblPlaceholderPhoneEmail.Location = new System.Drawing.Point(9, 7);
            this.lblPlaceholderPhoneEmail.Name = "lblPlaceholderPhoneEmail";
            this.lblPlaceholderPhoneEmail.Size = new System.Drawing.Size(123, 15);
            this.lblPlaceholderPhoneEmail.TabIndex = 4;
            this.lblPlaceholderPhoneEmail.Text = "Email / phone number";
            this.lblPlaceholderPhoneEmail.Click += new System.EventHandler(this.lblPlaceholderPhoneEmail_Click);
            // 
            // txtPhoneEmail
            // 
            this.txtPhoneEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneEmail.Location = new System.Drawing.Point(6, 7);
            this.txtPhoneEmail.Multiline = true;
            this.txtPhoneEmail.Name = "txtPhoneEmail";
            this.txtPhoneEmail.Size = new System.Drawing.Size(224, 17);
            this.txtPhoneEmail.TabIndex = 0;
            this.txtPhoneEmail.Enter += new System.EventHandler(this.txtPhoneEmail_Enter);
            this.txtPhoneEmail.Leave += new System.EventHandler(this.txtPhoneEmail_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(97)))), ((int)(((byte)(150)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(48, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(40, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 43);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "LKS Mart";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(343, 227);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(144, 120);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 7;
            this.picBoxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelContent);
            this.Name = "LoginForm";
            this.Text = "LKS Mart";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelPIN.ResumeLayout(false);
            this.panelPIN.PerformLayout();
            this.panelPhoneEmail.ResumeLayout(false);
            this.panelPhoneEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelPIN;
        private System.Windows.Forms.Label lblPlaceholderPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Panel panelPhoneEmail;
        private System.Windows.Forms.Label lblPlaceholderPhoneEmail;
        private System.Windows.Forms.TextBox txtPhoneEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBoxLogo;
    }
}
