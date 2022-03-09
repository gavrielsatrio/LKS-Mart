
namespace LKS_Mart
{
    partial class ShopForm
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
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.txtToPrice = new System.Windows.Forms.NumericUpDown();
            this.txtFromPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDash = new System.Windows.Forms.Label();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.lblSearchPlaceholder = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblShop = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelResult);
            this.panelContent.Controls.Add(this.panelCategory);
            this.panelContent.Controls.Add(this.txtToPrice);
            this.panelContent.Controls.Add(this.txtFromPrice);
            this.panelContent.Controls.Add(this.lblDash);
            this.panelContent.Controls.Add(this.lblPriceRange);
            this.panelContent.Controls.Add(this.lblSearchPlaceholder);
            this.panelContent.Controls.Add(this.txtSearch);
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.lblShop);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 500);
            this.panelContent.TabIndex = 0;
            // 
            // panelResult
            // 
            this.panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResult.AutoScroll = true;
            this.panelResult.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panelResult.Location = new System.Drawing.Point(31, 187);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(8);
            this.panelResult.Size = new System.Drawing.Size(742, 280);
            this.panelResult.TabIndex = 4;
            // 
            // panelCategory
            // 
            this.panelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategory.Location = new System.Drawing.Point(31, 146);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(742, 35);
            this.panelCategory.TabIndex = 3;
            // 
            // txtToPrice
            // 
            this.txtToPrice.Location = new System.Drawing.Point(244, 113);
            this.txtToPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtToPrice.Name = "txtToPrice";
            this.txtToPrice.Size = new System.Drawing.Size(120, 22);
            this.txtToPrice.TabIndex = 2;
            this.txtToPrice.ValueChanged += new System.EventHandler(this.txtToPrice_ValueChanged);
            // 
            // txtFromPrice
            // 
            this.txtFromPrice.Location = new System.Drawing.Point(101, 113);
            this.txtFromPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtFromPrice.Name = "txtFromPrice";
            this.txtFromPrice.Size = new System.Drawing.Size(120, 22);
            this.txtFromPrice.TabIndex = 1;
            this.txtFromPrice.ValueChanged += new System.EventHandler(this.txtFromPrice_ValueChanged);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblDash.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.Color.Black;
            this.lblDash.Location = new System.Drawing.Point(227, 115);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(11, 15);
            this.lblDash.TabIndex = 12;
            this.lblDash.Text = "-";
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblPriceRange.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRange.ForeColor = System.Drawing.Color.Black;
            this.lblPriceRange.Location = new System.Drawing.Point(28, 115);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(67, 15);
            this.lblPriceRange.TabIndex = 12;
            this.lblPriceRange.Text = "Price Range";
            // 
            // lblSearchPlaceholder
            // 
            this.lblSearchPlaceholder.AutoSize = true;
            this.lblSearchPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblSearchPlaceholder.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSearchPlaceholder.Location = new System.Drawing.Point(35, 82);
            this.lblSearchPlaceholder.Name = "lblSearchPlaceholder";
            this.lblSearchPlaceholder.Size = new System.Drawing.Size(89, 15);
            this.lblSearchPlaceholder.TabIndex = 12;
            this.lblSearchPlaceholder.Text = "Search keyword";
            this.lblSearchPlaceholder.Click += new System.EventHandler(this.lblSearchPlaceholder_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(31, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(742, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.ForeColor = System.Drawing.Color.Black;
            this.lblShop.Location = new System.Drawing.Point(25, 23);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(75, 33);
            this.lblShop.TabIndex = 6;
            this.lblShop.Text = "Shop";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.panelContent);
            this.Name = "ShopForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchPlaceholder;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.NumericUpDown txtFromPrice;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.NumericUpDown txtToPrice;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelResult;
    }
}