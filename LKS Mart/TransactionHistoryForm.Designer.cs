
namespace LKS_Mart
{
    partial class TransactionHistoryForm
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
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.lblProductsBought = new System.Windows.Forms.Label();
            this.panelTransactionDetail = new System.Windows.Forms.Panel();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(682, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelTransactionDetail);
            this.panelContent.Controls.Add(this.lblProductsBought);
            this.panelContent.Controls.Add(this.dgvTransaction);
            this.panelContent.Controls.Add(this.lblTransaction);
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.lblTransactionHistory);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 540);
            this.panelContent.TabIndex = 3;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionHistory.Location = new System.Drawing.Point(26, 24);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(259, 33);
            this.lblTransactionHistory.TabIndex = 9;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(565, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(29, 79);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(67, 15);
            this.lblTransaction.TabIndex = 12;
            this.lblTransaction.Text = "Transaction";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(32, 97);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(633, 180);
            this.dgvTransaction.TabIndex = 13;
            // 
            // lblProductsBought
            // 
            this.lblProductsBought.AutoSize = true;
            this.lblProductsBought.Location = new System.Drawing.Point(29, 296);
            this.lblProductsBought.Name = "lblProductsBought";
            this.lblProductsBought.Size = new System.Drawing.Size(238, 15);
            this.lblProductsBought.TabIndex = 14;
            this.lblProductsBought.Text = "Products bought for the selected transaction";
            // 
            // panelTransactionDetail
            // 
            this.panelTransactionDetail.Location = new System.Drawing.Point(32, 314);
            this.panelTransactionDetail.Name = "panelTransactionDetail";
            this.panelTransactionDetail.Size = new System.Drawing.Size(633, 180);
            this.panelTransactionDetail.TabIndex = 15;
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 580);
            this.Controls.Add(this.panelContent);
            this.Name = "TransactionHistoryForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblProductsBought;
        private System.Windows.Forms.Panel panelTransactionDetail;
    }
}