namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDiscountAmount = new System.Windows.Forms.Label();
            this.labelProductTotal = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btnChangePercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(173, 198);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(48, 198);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(161, 20);
            this.txtProductTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(111, 22);
            this.txtProductTotal.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(23, 149);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(125, 25);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscountAmount
            // 
            this.labelDiscountAmount.Location = new System.Drawing.Point(23, 52);
            this.labelDiscountAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountAmount.Name = "labelDiscountAmount";
            this.labelDiscountAmount.Size = new System.Drawing.Size(125, 25);
            this.labelDiscountAmount.TabIndex = 2;
            this.labelDiscountAmount.Text = "Discount amount:";
            this.labelDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductTotal
            // 
            this.labelProductTotal.Location = new System.Drawing.Point(23, 20);
            this.labelProductTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductTotal.Name = "labelProductTotal";
            this.labelProductTotal.Size = new System.Drawing.Size(125, 25);
            this.labelProductTotal.TabIndex = 0;
            this.labelProductTotal.Text = "Product total:";
            this.labelProductTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(161, 52);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(111, 22);
            this.txtDiscountAmount.TabIndex = 3;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(161, 150);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 22);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(23, 89);
            this.labelSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(59, 16);
            this.labelSubtotal.TabIndex = 4;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(161, 85);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(111, 22);
            this.txtSubtotal.TabIndex = 5;
            this.txtSubtotal.TabStop = false;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(23, 122);
            this.labelTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(80, 16);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "Tax (5.06%):";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(161, 118);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(111, 22);
            this.txtTax.TabIndex = 7;
            this.txtTax.TabStop = false;
            // 
            // btnChangePercent
            // 
            this.btnChangePercent.Location = new System.Drawing.Point(299, 115);
            this.btnChangePercent.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePercent.Name = "btnChangePercent";
            this.btnChangePercent.Size = new System.Drawing.Size(124, 28);
            this.btnChangePercent.TabIndex = 8;
            this.btnChangePercent.Text = "Change &Percent";
            this.btnChangePercent.Click += new System.EventHandler(this.btnChangePercent_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(443, 249);
            this.Controls.Add(this.btnChangePercent);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtProductTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscountAmount);
            this.Controls.Add(this.labelProductTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDiscountAmount;
        private System.Windows.Forms.Label labelProductTotal;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnChangePercent;
    }
}

