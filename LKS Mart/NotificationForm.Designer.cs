
namespace LKS_Mart
{
    partial class NotificationForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelNotif = new System.Windows.Forms.Panel();
            this.panelNotifTop = new System.Windows.Forms.Panel();
            this.lblNotifTop = new System.Windows.Forms.Label();
            this.panelNotifBottom = new System.Windows.Forms.Panel();
            this.lblPaymentCode = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.panelNotif.SuspendLayout();
            this.panelNotifTop.SuspendLayout();
            this.panelNotifBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(432, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.btnOK);
            this.panelContent.Controls.Add(this.panelNotif);
            this.panelContent.Controls.Add(this.lblNotification);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(450, 380);
            this.panelContent.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(179, 319);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 30);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panelNotif
            // 
            this.panelNotif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotif.Controls.Add(this.panelNotifTop);
            this.panelNotif.Controls.Add(this.panelNotifBottom);
            this.panelNotif.Location = new System.Drawing.Point(32, 68);
            this.panelNotif.Name = "panelNotif";
            this.panelNotif.Size = new System.Drawing.Size(386, 220);
            this.panelNotif.TabIndex = 9;
            // 
            // panelNotifTop
            // 
            this.panelNotifTop.Controls.Add(this.lblNotifTop);
            this.panelNotifTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotifTop.Location = new System.Drawing.Point(0, 0);
            this.panelNotifTop.Name = "panelNotifTop";
            this.panelNotifTop.Size = new System.Drawing.Size(384, 148);
            this.panelNotifTop.TabIndex = 1;
            // 
            // lblNotifTop
            // 
            this.lblNotifTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotifTop.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifTop.Location = new System.Drawing.Point(0, 0);
            this.lblNotifTop.Name = "lblNotifTop";
            this.lblNotifTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblNotifTop.Size = new System.Drawing.Size(384, 148);
            this.lblNotifTop.TabIndex = 13;
            this.lblNotifTop.Text = "Your order has been submitted successfully.\r\nPlease continue the payment process " +
    "in your\r\n<<payment type>> application.\r\n\r\nPlease input this code for the payment" +
    " process.";
            this.lblNotifTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelNotifBottom
            // 
            this.panelNotifBottom.Controls.Add(this.lblPaymentCode);
            this.panelNotifBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotifBottom.Location = new System.Drawing.Point(0, 148);
            this.panelNotifBottom.Name = "panelNotifBottom";
            this.panelNotifBottom.Size = new System.Drawing.Size(384, 70);
            this.panelNotifBottom.TabIndex = 0;
            // 
            // lblPaymentCode
            // 
            this.lblPaymentCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentCode.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentCode.Location = new System.Drawing.Point(0, 0);
            this.lblPaymentCode.Name = "lblPaymentCode";
            this.lblPaymentCode.Size = new System.Drawing.Size(384, 70);
            this.lblPaymentCode.TabIndex = 12;
            this.lblPaymentCode.Text = "<< Payment Code >>";
            this.lblPaymentCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Black;
            this.lblNotification.Location = new System.Drawing.Point(26, 24);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(165, 33);
            this.lblNotification.TabIndex = 8;
            this.lblNotification.Text = "Notification";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.panelContent);
            this.Name = "NotificationForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelNotif.ResumeLayout(false);
            this.panelNotifTop.ResumeLayout(false);
            this.panelNotifBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Panel panelNotif;
        private System.Windows.Forms.Panel panelNotifBottom;
        private System.Windows.Forms.Label lblPaymentCode;
        private System.Windows.Forms.Panel panelNotifTop;
        private System.Windows.Forms.Label lblNotifTop;
        private System.Windows.Forms.Button btnOK;
    }
}