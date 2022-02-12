namespace AreaAndParameter
{
    partial class areaAndParameter
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
            this.labelDiameter = new System.Windows.Forms.Label();
            this.textDiameter = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textPerimeter = new System.Windows.Forms.TextBox();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDiameter.Location = new System.Drawing.Point(32, 34);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(83, 20);
            this.labelDiameter.TabIndex = 0;
            this.labelDiameter.Text = "Diameter:";
            // 
            // textDiameter
            // 
            this.textDiameter.Location = new System.Drawing.Point(161, 34);
            this.textDiameter.Name = "textDiameter";
            this.textDiameter.Size = new System.Drawing.Size(143, 22);
            this.textDiameter.TabIndex = 1;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(161, 83);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(143, 22);
            this.textArea.TabIndex = 3;
            this.textArea.TabStop = false;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelArea.Location = new System.Drawing.Point(32, 85);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(49, 20);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Area:";
            // 
            // textPerimeter
            // 
            this.textPerimeter.Location = new System.Drawing.Point(161, 139);
            this.textPerimeter.Name = "textPerimeter";
            this.textPerimeter.ReadOnly = true;
            this.textPerimeter.Size = new System.Drawing.Size(143, 22);
            this.textPerimeter.TabIndex = 5;
            this.textPerimeter.TabStop = false;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPerimeter.Location = new System.Drawing.Point(32, 139);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(87, 20);
            this.labelPerimeter.TabIndex = 4;
            this.labelPerimeter.Text = "Perimeter:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(200, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // areaAndParameter
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(342, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textPerimeter);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textDiameter);
            this.Controls.Add(this.labelDiameter);
            this.Name = "areaAndParameter";
            this.Text = "Area and Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.TextBox textDiameter;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textPerimeter;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

