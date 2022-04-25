
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelPhoneEmail = new System.Windows.Forms.Panel();
            this.lblPlaceholderPhoneEmail = new System.Windows.Forms.Label();
            this.txtPhoneEmail = new System.Windows.Forms.TextBox();
            this.panelPIN = new System.Windows.Forms.Panel();
            this.lblPlaceholderPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.timerHeader = new System.Windows.Forms.Timer(this.components);
            this.timerPhoneEmail = new System.Windows.Forms.Timer(this.components);
            this.timerPIN = new System.Windows.Forms.Timer(this.components);
            this.timerPlaceholderPhoneEmailUp = new System.Windows.Forms.Timer(this.components);
            this.timerPlaceholderPINUp = new System.Windows.Forms.Timer(this.components);
            this.timerPlaceholderPhoneEmailDown = new System.Windows.Forms.Timer(this.components);
            this.timerPlaceholderPINDown = new System.Windows.Forms.Timer(this.components);
            this.panelContent.SuspendLayout();
            this.panelPhoneEmail.SuspendLayout();
            this.panelPIN.SuspendLayout();
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
            this.panelContent.Controls.Add(this.lblPlaceholderPIN);
            this.panelContent.Controls.Add(this.lblPlaceholderPhoneEmail);
            this.panelContent.Controls.Add(this.panelPhoneEmail);
            this.panelContent.Controls.Add(this.panelPIN);
            this.panelContent.Controls.Add(this.btnLogin);
            this.panelContent.Controls.Add(this.lblHeader);
            this.panelContent.Controls.Add(this.picBoxLogo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(500, 360);
            this.panelContent.TabIndex = 3;
            // 
            // panelPhoneEmail
            // 
            this.panelPhoneEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPhoneEmail.BackColor = System.Drawing.Color.White;
            this.panelPhoneEmail.Controls.Add(this.txtPhoneEmail);
            this.panelPhoneEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPhoneEmail.Location = new System.Drawing.Point(32, 127);
            this.panelPhoneEmail.Name = "panelPhoneEmail";
            this.panelPhoneEmail.Padding = new System.Windows.Forms.Padding(8, 7, 6, 6);
            this.panelPhoneEmail.Size = new System.Drawing.Size(236, 30);
            this.panelPhoneEmail.TabIndex = 1;
            this.panelPhoneEmail.Click += new System.EventHandler(this.panelPhoneEmail_Click);
            // 
            // lblPlaceholderPhoneEmail
            // 
            this.lblPlaceholderPhoneEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaceholderPhoneEmail.AutoSize = true;
            this.lblPlaceholderPhoneEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceholderPhoneEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholderPhoneEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPlaceholderPhoneEmail.Location = new System.Drawing.Point(48, 109);
            this.lblPlaceholderPhoneEmail.Name = "lblPlaceholderPhoneEmail";
            this.lblPlaceholderPhoneEmail.Size = new System.Drawing.Size(123, 15);
            this.lblPlaceholderPhoneEmail.TabIndex = 4;
            this.lblPlaceholderPhoneEmail.Text = "Email / phone number";
            this.lblPlaceholderPhoneEmail.Click += new System.EventHandler(this.lblPlaceholderPhoneEmail_Click);
            // 
            // txtPhoneEmail
            // 
            this.txtPhoneEmail.BackColor = System.Drawing.Color.White;
            this.txtPhoneEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneEmail.Location = new System.Drawing.Point(8, 7);
            this.txtPhoneEmail.Name = "txtPhoneEmail";
            this.txtPhoneEmail.Size = new System.Drawing.Size(222, 15);
            this.txtPhoneEmail.TabIndex = 1;
            this.txtPhoneEmail.Enter += new System.EventHandler(this.txtPhoneEmail_Enter);
            this.txtPhoneEmail.Leave += new System.EventHandler(this.txtPhoneEmail_Leave);
            // 
            // panelPIN
            // 
            this.panelPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPIN.BackColor = System.Drawing.Color.White;
            this.panelPIN.Controls.Add(this.txtPIN);
            this.panelPIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPIN.Location = new System.Drawing.Point(32, 187);
            this.panelPIN.Name = "panelPIN";
            this.panelPIN.Padding = new System.Windows.Forms.Padding(8, 7, 6, 6);
            this.panelPIN.Size = new System.Drawing.Size(236, 30);
            this.panelPIN.TabIndex = 2;
            this.panelPIN.Click += new System.EventHandler(this.panelPIN_Click);
            // 
            // lblPlaceholderPIN
            // 
            this.lblPlaceholderPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaceholderPIN.AutoSize = true;
            this.lblPlaceholderPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblPlaceholderPIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholderPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPlaceholderPIN.Location = new System.Drawing.Point(48, 169);
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
            this.txtPIN.Location = new System.Drawing.Point(8, 7);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(222, 15);
            this.txtPIN.TabIndex = 1;
            this.txtPIN.UseSystemPasswordChar = true;
            this.txtPIN.Enter += new System.EventHandler(this.txtPIN_Enter);
            this.txtPIN.Leave += new System.EventHandler(this.txtPIN_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(97)))), ((int)(((byte)(150)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(48, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(40, 12);
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
            // timerHeader
            // 
            this.timerHeader.Interval = 1;
            this.timerHeader.Tick += new System.EventHandler(this.timerHeader_Tick);
            // 
            // timerPhoneEmail
            // 
            this.timerPhoneEmail.Interval = 1;
            this.timerPhoneEmail.Tick += new System.EventHandler(this.timerPhoneEmail_Tick);
            // 
            // timerPIN
            // 
            this.timerPIN.Interval = 1;
            this.timerPIN.Tick += new System.EventHandler(this.timerPIN_Tick);
            // 
            // timerPlaceholderPhoneEmailUp
            // 
            this.timerPlaceholderPhoneEmailUp.Interval = 1;
            this.timerPlaceholderPhoneEmailUp.Tick += new System.EventHandler(this.timerPlaceholderPhoneEmailUp_Tick);
            // 
            // timerPlaceholderPINUp
            // 
            this.timerPlaceholderPINUp.Interval = 1;
            this.timerPlaceholderPINUp.Tick += new System.EventHandler(this.timerPlaceholderPINUp_Tick);
            // 
            // timerPlaceholderPhoneEmailDown
            // 
            this.timerPlaceholderPhoneEmailDown.Interval = 1;
            this.timerPlaceholderPhoneEmailDown.Tick += new System.EventHandler(this.timerPlaceholderPhoneEmailDown_Tick);
            // 
            // timerPlaceholderPINDown
            // 
            this.timerPlaceholderPINDown.Interval = 1;
            this.timerPlaceholderPINDown.Tick += new System.EventHandler(this.timerPlaceholderPINDown_Tick);
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
            this.panelPhoneEmail.ResumeLayout(false);
            this.panelPhoneEmail.PerformLayout();
            this.panelPIN.ResumeLayout(false);
            this.panelPIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelPIN;
        private System.Windows.Forms.Label lblPlaceholderPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelPhoneEmail;
        private System.Windows.Forms.Label lblPlaceholderPhoneEmail;
        private System.Windows.Forms.TextBox txtPhoneEmail;
        private System.Windows.Forms.Timer timerHeader;
        private System.Windows.Forms.Timer timerPhoneEmail;
        private System.Windows.Forms.Timer timerPIN;
        private System.Windows.Forms.Timer timerPlaceholderPhoneEmailUp;
        private System.Windows.Forms.Timer timerPlaceholderPINUp;
        private System.Windows.Forms.Timer timerPlaceholderPhoneEmailDown;
        private System.Windows.Forms.Timer timerPlaceholderPINDown;
    }
}
