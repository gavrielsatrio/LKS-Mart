
namespace LKS_Mart
{
    partial class AddToCartForm
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
            this.panelDesc = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableQty = new System.Windows.Forms.TableLayoutPanel();
            this.btnMinQty = new System.Windows.Forms.Button();
            this.btnPlusQty = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.panelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.tableQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(402, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.tableQty);
            this.panelContent.Controls.Add(this.btnSubmit);
            this.panelContent.Controls.Add(this.panelDesc);
            this.panelContent.Controls.Add(this.picBoxImage);
            this.panelContent.Controls.Add(this.lblPrice);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(420, 410);
            this.panelContent.TabIndex = 13;
            // 
            // panelDesc
            // 
            this.panelDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesc.Controls.Add(this.lblDesc);
            this.panelDesc.Location = new System.Drawing.Point(233, 97);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(160, 150);
            this.panelDesc.TabIndex = 17;
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDesc.Location = new System.Drawing.Point(0, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(158, 148);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Description";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(31, 57);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(180, 190);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImage.TabIndex = 16;
            this.picBoxImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPrice.Location = new System.Drawing.Point(230, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(122, 18);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "<< Product Price >>";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(26, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 28);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "<< Product Name >>";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(161, 353);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 35);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // tableQty
            // 
            this.tableQty.ColumnCount = 3;
            this.tableQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableQty.Controls.Add(this.lblQty, 0, 0);
            this.tableQty.Controls.Add(this.btnMinQty, 0, 0);
            this.tableQty.Controls.Add(this.btnPlusQty, 2, 0);
            this.tableQty.Location = new System.Drawing.Point(31, 269);
            this.tableQty.Name = "tableQty";
            this.tableQty.RowCount = 1;
            this.tableQty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableQty.Size = new System.Drawing.Size(180, 37);
            this.tableQty.TabIndex = 19;
            // 
            // btnMinQty
            // 
            this.btnMinQty.BackColor = System.Drawing.Color.White;
            this.btnMinQty.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinQty.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinQty.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinQty.ForeColor = System.Drawing.Color.Black;
            this.btnMinQty.Location = new System.Drawing.Point(12, 3);
            this.btnMinQty.Name = "btnMinQty";
            this.btnMinQty.Size = new System.Drawing.Size(30, 31);
            this.btnMinQty.TabIndex = 19;
            this.btnMinQty.Text = "-";
            this.btnMinQty.UseVisualStyleBackColor = false;
            // 
            // btnPlusQty
            // 
            this.btnPlusQty.BackColor = System.Drawing.Color.White;
            this.btnPlusQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlusQty.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlusQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusQty.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusQty.ForeColor = System.Drawing.Color.Black;
            this.btnPlusQty.Location = new System.Drawing.Point(138, 3);
            this.btnPlusQty.Name = "btnPlusQty";
            this.btnPlusQty.Size = new System.Drawing.Size(30, 31);
            this.btnPlusQty.TabIndex = 20;
            this.btnPlusQty.Text = "+";
            this.btnPlusQty.UseVisualStyleBackColor = false;
            // 
            // lblQty
            // 
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQty.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(48, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(84, 37);
            this.lblQty.TabIndex = 21;
            this.lblQty.Text = "12";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.panelContent);
            this.Name = "AddToCartForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.AddToCartForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.tableQty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableQty;
        private System.Windows.Forms.Button btnMinQty;
        private System.Windows.Forms.Button btnPlusQty;
        private System.Windows.Forms.Label lblQty;
    }
}