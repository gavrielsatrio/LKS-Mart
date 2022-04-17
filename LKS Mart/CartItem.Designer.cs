
namespace LKS_Mart
{
    partial class CartItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.tableLayoutCartItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelBorder.SuspendLayout();
            this.tableLayoutCartItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Controls.Add(this.tableLayoutCartItem);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(16);
            this.panelBorder.Size = new System.Drawing.Size(602, 132);
            this.panelBorder.TabIndex = 0;
            // 
            // tableLayoutCartItem
            // 
            this.tableLayoutCartItem.BackColor = System.Drawing.Color.White;
            this.tableLayoutCartItem.ColumnCount = 6;
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutCartItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutCartItem.Controls.Add(this.lblQty, 3, 0);
            this.tableLayoutCartItem.Controls.Add(this.lblPrice, 2, 0);
            this.tableLayoutCartItem.Controls.Add(this.picBoxImage, 0, 0);
            this.tableLayoutCartItem.Controls.Add(this.btnEdit, 4, 0);
            this.tableLayoutCartItem.Controls.Add(this.btnDelete, 5, 0);
            this.tableLayoutCartItem.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutCartItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCartItem.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutCartItem.Name = "tableLayoutCartItem";
            this.tableLayoutCartItem.RowCount = 1;
            this.tableLayoutCartItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutCartItem.Size = new System.Drawing.Size(568, 98);
            this.tableLayoutCartItem.TabIndex = 1;
            // 
            // lblQty
            // 
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQty.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(417, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(67, 98);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "<< Quantity >>";
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(295, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 98);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "<< Product Price >>";
            // 
            // picBoxImage
            // 
            this.picBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxImage.Location = new System.Drawing.Point(3, 3);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(91, 92);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImage.TabIndex = 1;
            this.picBoxImage.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(490, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 92);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(530, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 92);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(100, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(189, 98);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "<< Product Name >>";
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelBorder);
            this.Name = "CartItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.Size = new System.Drawing.Size(602, 148);
            this.Load += new System.EventHandler(this.CartItem_Load);
            this.panelBorder.ResumeLayout(false);
            this.tableLayoutCartItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCartItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label lblName;
    }
}
