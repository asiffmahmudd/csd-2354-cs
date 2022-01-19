namespace BasicForm
{
    partial class Form1
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
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.doscountPercentText = new System.Windows.Forms.TextBox();
            this.discountAmountText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subTotalLabel.Location = new System.Drawing.Point(47, 56);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(84, 20);
            this.subTotalLabel.TabIndex = 0;
            this.subTotalLabel.Text = "&Subtotal:";
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.discountPercentLabel.Location = new System.Drawing.Point(47, 104);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(161, 20);
            this.discountPercentLabel.TabIndex = 2;
            this.discountPercentLabel.Text = "Discount Percent:";
            this.discountPercentLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.discountAmountLabel.Location = new System.Drawing.Point(47, 153);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(159, 20);
            this.discountAmountLabel.TabIndex = 4;
            this.discountAmountLabel.Text = "Discount Amount:";
            this.discountAmountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(47, 207);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalText
            // 
            this.subtotalText.Location = new System.Drawing.Point(233, 53);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(167, 22);
            this.subtotalText.TabIndex = 1;
            // 
            // doscountPercentText
            // 
            this.doscountPercentText.Location = new System.Drawing.Point(233, 102);
            this.doscountPercentText.Name = "doscountPercentText";
            this.doscountPercentText.ReadOnly = true;
            this.doscountPercentText.Size = new System.Drawing.Size(167, 22);
            this.doscountPercentText.TabIndex = 3;
            this.doscountPercentText.TabStop = false;
            // 
            // discountAmountText
            // 
            this.discountAmountText.Location = new System.Drawing.Point(233, 151);
            this.discountAmountText.Name = "discountAmountText";
            this.discountAmountText.Size = new System.Drawing.Size(167, 22);
            this.discountAmountText.TabIndex = 5;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(233, 205);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(167, 22);
            this.totalText.TabIndex = 7;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateBtn.Location = new System.Drawing.Point(106, 263);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(128, 39);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(272, 263);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(128, 39);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.discountAmountText);
            this.Controls.Add(this.doscountPercentText);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Name = "Form1";
            this.Text = "calculateTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalText;
        private System.Windows.Forms.TextBox doscountPercentText;
        private System.Windows.Forms.TextBox discountAmountText;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

