
namespace LKS_Mart
{
    partial class CartForm
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
            this.lblCart = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.comboPaymentType = new System.Windows.Forms.ComboBox();
            this.checkPayUsingPoint = new System.Windows.Forms.CheckBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblFeeValue = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.panelLineAdd = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAvailablePointValue = new System.Windows.Forms.Label();
            this.lblAvailablePoint = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panelLineSubtract = new System.Windows.Forms.Panel();
            this.lblSubtract = new System.Windows.Forms.Label();
            this.lblAmountToPayValue = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(682, 22);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.btnSubmit);
            this.panelContent.Controls.Add(this.lblSubtract);
            this.panelContent.Controls.Add(this.panelLineSubtract);
            this.panelContent.Controls.Add(this.panelLineAdd);
            this.panelContent.Controls.Add(this.checkPayUsingPoint);
            this.panelContent.Controls.Add(this.comboPaymentType);
            this.panelContent.Controls.Add(this.lblTotal);
            this.panelContent.Controls.Add(this.lblAvailablePoint);
            this.panelContent.Controls.Add(this.lblAmountToPay);
            this.panelContent.Controls.Add(this.lblAmountToPayValue);
            this.panelContent.Controls.Add(this.lblAvailablePointValue);
            this.panelContent.Controls.Add(this.lblAdd);
            this.panelContent.Controls.Add(this.lblTotalValue);
            this.panelContent.Controls.Add(this.lblFeeValue);
            this.panelContent.Controls.Add(this.lblSubtotalValue);
            this.panelContent.Controls.Add(this.lblFee);
            this.panelContent.Controls.Add(this.lblSubtotal);
            this.panelContent.Controls.Add(this.lblPaymentType);
            this.panelContent.Controls.Add(this.panelCart);
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.lblCart);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 660);
            this.panelContent.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.Black;
            this.lblCart.Location = new System.Drawing.Point(26, 24);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(68, 33);
            this.lblCart.TabIndex = 6;
            this.lblCart.Text = "Cart";
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
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panelCart
            // 
            this.panelCart.Location = new System.Drawing.Point(32, 70);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(635, 200);
            this.panelCart.TabIndex = 10;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(29, 288);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(81, 15);
            this.lblPaymentType.TabIndex = 11;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // comboPaymentType
            // 
            this.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentType.FormattingEnabled = true;
            this.comboPaymentType.Location = new System.Drawing.Point(125, 285);
            this.comboPaymentType.Name = "comboPaymentType";
            this.comboPaymentType.Size = new System.Drawing.Size(170, 23);
            this.comboPaymentType.TabIndex = 12;
            // 
            // checkPayUsingPoint
            // 
            this.checkPayUsingPoint.AutoSize = true;
            this.checkPayUsingPoint.Location = new System.Drawing.Point(32, 322);
            this.checkPayUsingPoint.Name = "checkPayUsingPoint";
            this.checkPayUsingPoint.Size = new System.Drawing.Size(156, 19);
            this.checkPayUsingPoint.TabIndex = 13;
            this.checkPayUsingPoint.Text = "Pay using available point";
            this.checkPayUsingPoint.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(29, 369);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(57, 15);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Sub-Total";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(190, 369);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(80, 15);
            this.lblSubtotalValue.TabIndex = 11;
            this.lblSubtotalValue.Text = "<<Sub Total>>";
            // 
            // lblFeeValue
            // 
            this.lblFeeValue.AutoSize = true;
            this.lblFeeValue.Location = new System.Drawing.Point(190, 398);
            this.lblFeeValue.Name = "lblFeeValue";
            this.lblFeeValue.Size = new System.Drawing.Size(97, 15);
            this.lblFeeValue.TabIndex = 11;
            this.lblFeeValue.Text = "<<Platform Fee>>";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(29, 398);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(91, 15);
            this.lblFee.TabIndex = 11;
            this.lblFee.Text = "5% Platform Fee";
            // 
            // panelLineAdd
            // 
            this.panelLineAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelLineAdd.Location = new System.Drawing.Point(32, 432);
            this.panelLineAdd.Name = "panelLineAdd";
            this.panelLineAdd.Size = new System.Drawing.Size(431, 2);
            this.panelLineAdd.TabIndex = 14;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(190, 451);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(57, 15);
            this.lblTotalValue.TabIndex = 11;
            this.lblTotalValue.Text = "<<Total>>";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(33, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // lblAvailablePointValue
            // 
            this.lblAvailablePointValue.AutoSize = true;
            this.lblAvailablePointValue.Location = new System.Drawing.Point(190, 480);
            this.lblAvailablePointValue.Name = "lblAvailablePointValue";
            this.lblAvailablePointValue.Size = new System.Drawing.Size(109, 15);
            this.lblAvailablePointValue.TabIndex = 11;
            this.lblAvailablePointValue.Text = "<<Available Point>>";
            // 
            // lblAvailablePoint
            // 
            this.lblAvailablePoint.AutoSize = true;
            this.lblAvailablePoint.Location = new System.Drawing.Point(33, 480);
            this.lblAvailablePoint.Name = "lblAvailablePoint";
            this.lblAvailablePoint.Size = new System.Drawing.Size(85, 15);
            this.lblAvailablePoint.TabIndex = 11;
            this.lblAvailablePoint.Text = "Available Point";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(469, 424);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(13, 15);
            this.lblAdd.TabIndex = 11;
            this.lblAdd.Text = "+";
            // 
            // panelLineSubtract
            // 
            this.panelLineSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelLineSubtract.Location = new System.Drawing.Point(32, 514);
            this.panelLineSubtract.Name = "panelLineSubtract";
            this.panelLineSubtract.Size = new System.Drawing.Size(431, 2);
            this.panelLineSubtract.TabIndex = 15;
            // 
            // lblSubtract
            // 
            this.lblSubtract.AutoSize = true;
            this.lblSubtract.Location = new System.Drawing.Point(469, 506);
            this.lblSubtract.Name = "lblSubtract";
            this.lblSubtract.Size = new System.Drawing.Size(11, 15);
            this.lblSubtract.TabIndex = 16;
            this.lblSubtract.Text = "-";
            // 
            // lblAmountToPayValue
            // 
            this.lblAmountToPayValue.AutoSize = true;
            this.lblAmountToPayValue.Location = new System.Drawing.Point(190, 533);
            this.lblAmountToPayValue.Name = "lblAmountToPayValue";
            this.lblAmountToPayValue.Size = new System.Drawing.Size(111, 15);
            this.lblAmountToPayValue.TabIndex = 11;
            this.lblAmountToPayValue.Text = "<<Amount To Pay>>";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(33, 533);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(85, 15);
            this.lblAmountToPay.TabIndex = 11;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(303, 600);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.panelContent);
            this.Name = "CartForm";
            this.Text = "LKS Mart";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.Controls.SetChildIndex(this.panelContent, 0);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox comboPaymentType;
        private System.Windows.Forms.CheckBox checkPayUsingPoint;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblFeeValue;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Panel panelLineAdd;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAvailablePoint;
        private System.Windows.Forms.Label lblAvailablePointValue;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panelLineSubtract;
        private System.Windows.Forms.Label lblSubtract;
        private System.Windows.Forms.Label lblAmountToPayValue;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Button btnSubmit;
    }
}