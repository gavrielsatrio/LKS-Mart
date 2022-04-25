
namespace LKS_Mart
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblBtnPoint = new System.Windows.Forms.Label();
            this.lblBtnTransaction = new System.Windows.Forms.Label();
            this.lblBtnShop = new System.Windows.Forms.Label();
            this.lblBtnProfile = new System.Windows.Forms.Label();
            this.picBoxBtnPoint = new System.Windows.Forms.PictureBox();
            this.picBoxBtnTransaction = new System.Windows.Forms.PictureBox();
            this.picBoxBtnShop = new System.Windows.Forms.PictureBox();
            this.picBoxBtnProfile = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.picBoxProfile = new System.Windows.Forms.PictureBox();
            this.picBoxTopLeftOrnament = new System.Windows.Forms.PictureBox();
            this.timerDatetime = new System.Windows.Forms.Timer(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTopLeftOrnament)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.lblBtnPoint);
            this.panelContent.Controls.Add(this.lblBtnTransaction);
            this.panelContent.Controls.Add(this.lblBtnShop);
            this.panelContent.Controls.Add(this.lblBtnProfile);
            this.panelContent.Controls.Add(this.picBoxBtnPoint);
            this.panelContent.Controls.Add(this.picBoxBtnTransaction);
            this.panelContent.Controls.Add(this.picBoxBtnShop);
            this.panelContent.Controls.Add(this.picBoxBtnProfile);
            this.panelContent.Controls.Add(this.btnLogout);
            this.panelContent.Controls.Add(this.lblDatetime);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Controls.Add(this.btnCart);
            this.panelContent.Controls.Add(this.picBoxProfile);
            this.panelContent.Controls.Add(this.picBoxTopLeftOrnament);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 560);
            this.panelContent.TabIndex = 3;
            // 
            // lblBtnPoint
            // 
            this.lblBtnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnPoint.AutoSize = true;
            this.lblBtnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnPoint.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnPoint.ForeColor = System.Drawing.Color.Black;
            this.lblBtnPoint.Location = new System.Drawing.Point(111, 457);
            this.lblBtnPoint.Name = "lblBtnPoint";
            this.lblBtnPoint.Size = new System.Drawing.Size(66, 44);
            this.lblBtnPoint.TabIndex = 10;
            this.lblBtnPoint.Text = "Point\r\nHistory";
            this.lblBtnPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnPoint.Click += new System.EventHandler(this.lblBtnPoint_Click);
            // 
            // lblBtnTransaction
            // 
            this.lblBtnTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnTransaction.AutoSize = true;
            this.lblBtnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnTransaction.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnTransaction.ForeColor = System.Drawing.Color.Black;
            this.lblBtnTransaction.Location = new System.Drawing.Point(580, 263);
            this.lblBtnTransaction.Name = "lblBtnTransaction";
            this.lblBtnTransaction.Size = new System.Drawing.Size(100, 44);
            this.lblBtnTransaction.TabIndex = 10;
            this.lblBtnTransaction.Text = "Transaction\r\nHistory";
            this.lblBtnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnTransaction.Click += new System.EventHandler(this.lblBtnTransaction_Click);
            // 
            // lblBtnShop
            // 
            this.lblBtnShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnShop.AutoSize = true;
            this.lblBtnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnShop.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnShop.ForeColor = System.Drawing.Color.Black;
            this.lblBtnShop.Location = new System.Drawing.Point(368, 263);
            this.lblBtnShop.Name = "lblBtnShop";
            this.lblBtnShop.Size = new System.Drawing.Size(49, 22);
            this.lblBtnShop.TabIndex = 10;
            this.lblBtnShop.Text = "Shop";
            this.lblBtnShop.Click += new System.EventHandler(this.lblBtnShop_Click);
            // 
            // lblBtnProfile
            // 
            this.lblBtnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnProfile.AutoSize = true;
            this.lblBtnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnProfile.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnProfile.ForeColor = System.Drawing.Color.Black;
            this.lblBtnProfile.Location = new System.Drawing.Point(114, 263);
            this.lblBtnProfile.Name = "lblBtnProfile";
            this.lblBtnProfile.Size = new System.Drawing.Size(60, 22);
            this.lblBtnProfile.TabIndex = 10;
            this.lblBtnProfile.Text = "Profile";
            this.lblBtnProfile.Click += new System.EventHandler(this.lblBtnProfile_Click);
            // 
            // picBoxBtnPoint
            // 
            this.picBoxBtnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxBtnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxBtnPoint.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBtnPoint.Image")));
            this.picBoxBtnPoint.Location = new System.Drawing.Point(94, 345);
            this.picBoxBtnPoint.Name = "picBoxBtnPoint";
            this.picBoxBtnPoint.Size = new System.Drawing.Size(100, 100);
            this.picBoxBtnPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBtnPoint.TabIndex = 9;
            this.picBoxBtnPoint.TabStop = false;
            this.picBoxBtnPoint.Click += new System.EventHandler(this.picBoxBtnPoint_Click);
            // 
            // picBoxBtnTransaction
            // 
            this.picBoxBtnTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxBtnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxBtnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBtnTransaction.Image")));
            this.picBoxBtnTransaction.Location = new System.Drawing.Point(578, 153);
            this.picBoxBtnTransaction.Name = "picBoxBtnTransaction";
            this.picBoxBtnTransaction.Size = new System.Drawing.Size(100, 100);
            this.picBoxBtnTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBtnTransaction.TabIndex = 9;
            this.picBoxBtnTransaction.TabStop = false;
            this.picBoxBtnTransaction.Click += new System.EventHandler(this.picBoxBtnTransaction_Click);
            // 
            // picBoxBtnShop
            // 
            this.picBoxBtnShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxBtnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxBtnShop.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBtnShop.Image")));
            this.picBoxBtnShop.Location = new System.Drawing.Point(344, 153);
            this.picBoxBtnShop.Name = "picBoxBtnShop";
            this.picBoxBtnShop.Size = new System.Drawing.Size(100, 100);
            this.picBoxBtnShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBtnShop.TabIndex = 9;
            this.picBoxBtnShop.TabStop = false;
            this.picBoxBtnShop.Click += new System.EventHandler(this.picBoxBtnShop_Click);
            // 
            // picBoxBtnProfile
            // 
            this.picBoxBtnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxBtnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxBtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBtnProfile.Image")));
            this.picBoxBtnProfile.Location = new System.Drawing.Point(94, 153);
            this.picBoxBtnProfile.Name = "picBoxBtnProfile";
            this.picBoxBtnProfile.Size = new System.Drawing.Size(100, 100);
            this.picBoxBtnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBtnProfile.TabIndex = 9;
            this.picBoxBtnProfile.TabStop = false;
            this.picBoxBtnProfile.Click += new System.EventHandler(this.picBoxBtnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(659, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDatetime
            // 
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDatetime.Location = new System.Drawing.Point(108, 61);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(89, 17);
            this.lblDatetime.TabIndex = 1;
            this.lblDatetime.Text = "Date time now";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(106, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(207, 26);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, <<name>>!";
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(603, 24);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(28, 28);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCart.TabIndex = 0;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // picBoxProfile
            // 
            this.picBoxProfile.Location = new System.Drawing.Point(20, 20);
            this.picBoxProfile.Name = "picBoxProfile";
            this.picBoxProfile.Size = new System.Drawing.Size(70, 70);
            this.picBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfile.TabIndex = 0;
            this.picBoxProfile.TabStop = false;
            // 
            // picBoxTopLeftOrnament
            // 
            this.picBoxTopLeftOrnament.Location = new System.Drawing.Point(-40, -60);
            this.picBoxTopLeftOrnament.Name = "picBoxTopLeftOrnament";
            this.picBoxTopLeftOrnament.Size = new System.Drawing.Size(400, 200);
            this.picBoxTopLeftOrnament.TabIndex = 8;
            this.picBoxTopLeftOrnament.TabStop = false;
            // 
            // timerDatetime
            // 
            this.timerDatetime.Interval = 1000;
            this.timerDatetime.Tick += new System.EventHandler(this.timerDatetime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContent);
            this.Name = "MainForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBtnProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTopLeftOrnament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox picBoxProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.PictureBox btnCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picBoxTopLeftOrnament;
        private System.Windows.Forms.PictureBox picBoxBtnProfile;
        private System.Windows.Forms.Label lblBtnProfile;
        private System.Windows.Forms.PictureBox picBoxBtnShop;
        private System.Windows.Forms.PictureBox picBoxBtnTransaction;
        private System.Windows.Forms.Label lblBtnShop;
        private System.Windows.Forms.Label lblBtnTransaction;
        private System.Windows.Forms.PictureBox picBoxBtnPoint;
        private System.Windows.Forms.Label lblBtnPoint;
        private System.Windows.Forms.Timer timerDatetime;
    }
}