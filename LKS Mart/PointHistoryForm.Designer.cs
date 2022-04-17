
namespace LKS_Mart
{
    partial class PointHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblCurrentPointValue = new System.Windows.Forms.Label();
            this.lblCurrentPoint = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPointHistory = new System.Windows.Forms.Label();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.dgvPoint = new System.Windows.Forms.DataGridView();
            this.panelContent.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(682, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.lblCurrentPointValue);
            this.panelContent.Controls.Add(this.lblCurrentPoint);
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.lblPointHistory);
            this.panelContent.Controls.Add(this.panelBorder);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 360);
            this.panelContent.TabIndex = 3;
            // 
            // lblCurrentPointValue
            // 
            this.lblCurrentPointValue.AutoSize = true;
            this.lblCurrentPointValue.Location = new System.Drawing.Point(126, 80);
            this.lblCurrentPointValue.Name = "lblCurrentPointValue";
            this.lblCurrentPointValue.Size = new System.Drawing.Size(65, 15);
            this.lblCurrentPointValue.TabIndex = 14;
            this.lblCurrentPointValue.Text = "<< Point >>";
            // 
            // lblCurrentPoint
            // 
            this.lblCurrentPoint.AutoSize = true;
            this.lblCurrentPoint.Location = new System.Drawing.Point(31, 80);
            this.lblCurrentPoint.Name = "lblCurrentPoint";
            this.lblCurrentPoint.Size = new System.Drawing.Size(77, 15);
            this.lblCurrentPoint.TabIndex = 14;
            this.lblCurrentPoint.Text = "Current Point";
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
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPointHistory
            // 
            this.lblPointHistory.AutoSize = true;
            this.lblPointHistory.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointHistory.ForeColor = System.Drawing.Color.Black;
            this.lblPointHistory.Location = new System.Drawing.Point(26, 24);
            this.lblPointHistory.Name = "lblPointHistory";
            this.lblPointHistory.Size = new System.Drawing.Size(177, 33);
            this.lblPointHistory.TabIndex = 11;
            this.lblPointHistory.Text = "Point History";
            // 
            // panelBorder
            // 
            this.panelBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorder.Controls.Add(this.dgvPoint);
            this.panelBorder.Location = new System.Drawing.Point(35, 98);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(16);
            this.panelBorder.Size = new System.Drawing.Size(633, 228);
            this.panelBorder.TabIndex = 16;
            // 
            // dgvPoint
            // 
            this.dgvPoint.AllowUserToAddRows = false;
            this.dgvPoint.AllowUserToDeleteRows = false;
            this.dgvPoint.AllowUserToResizeColumns = false;
            this.dgvPoint.AllowUserToResizeRows = false;
            this.dgvPoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPoint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPoint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoint.ColumnHeadersVisible = false;
            this.dgvPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoint.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPoint.Location = new System.Drawing.Point(16, 16);
            this.dgvPoint.Name = "dgvPoint";
            this.dgvPoint.ReadOnly = true;
            this.dgvPoint.RowHeadersVisible = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            this.dgvPoint.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoint.RowTemplate.DividerHeight = 8;
            this.dgvPoint.Size = new System.Drawing.Size(601, 196);
            this.dgvPoint.TabIndex = 15;
            // 
            // PointHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panelContent);
            this.Name = "PointHistoryForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.PointHistoryForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPointHistory;
        private System.Windows.Forms.DataGridView dgvPoint;
        private System.Windows.Forms.Label lblCurrentPoint;
        private System.Windows.Forms.Label lblCurrentPointValue;
        private System.Windows.Forms.Panel panelBorder;
    }
}