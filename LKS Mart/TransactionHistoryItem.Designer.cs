
namespace LKS_Mart
{
    partial class TransactionHistoryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutTransactionHistoryItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutTransactionHistoryItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutTransactionHistoryItem
            // 
            this.tableLayoutTransactionHistoryItem.ColumnCount = 4;
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTransactionHistoryItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTransactionHistoryItem.Controls.Add(this.lblQty, 3, 0);
            this.tableLayoutTransactionHistoryItem.Controls.Add(this.lblPrice, 2, 0);
            this.tableLayoutTransactionHistoryItem.Controls.Add(this.picBoxImage, 0, 0);
            this.tableLayoutTransactionHistoryItem.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutTransactionHistoryItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTransactionHistoryItem.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutTransactionHistoryItem.Name = "tableLayoutTransactionHistoryItem";
            this.tableLayoutTransactionHistoryItem.RowCount = 1;
            this.tableLayoutTransactionHistoryItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTransactionHistoryItem.Size = new System.Drawing.Size(568, 98);
            this.tableLayoutTransactionHistoryItem.TabIndex = 1;
            // 
            // lblQty
            // 
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQty.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(485, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(80, 98);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "<< Quantity >>";
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(343, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(136, 98);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "<< Product Price >>";
            // 
            // picBoxImage
            // 
            this.picBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxImage.Location = new System.Drawing.Point(3, 3);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(107, 92);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImage.TabIndex = 1;
            this.picBoxImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(116, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 98);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "<< Product Name >>";
            // 
            // TransactionHistoryItemLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutTransactionHistoryItem);
            this.Name = "TransactionHistoryItemLayout";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(600, 130);
            this.tableLayoutTransactionHistoryItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutTransactionHistoryItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Label lblName;
    }
}
