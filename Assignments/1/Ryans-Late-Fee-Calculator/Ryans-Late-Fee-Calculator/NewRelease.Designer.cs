namespace Ryans_Late_Fee_Calculator
{
    partial class newRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newRelease));
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelNumberOfDaysLate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelLateFee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.title.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(29, 71);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(235, 41);
            this.title.TabIndex = 1;
            this.title.Text = "New Releases";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.subtitle.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.White;
            this.subtitle.Location = new System.Drawing.Point(32, 129);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(406, 30);
            this.subtitle.TabIndex = 4;
            this.subtitle.Text = "Check out our new releases and fees";
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.btnReturn);
            this.btnContainer.Controls.Add(this.btnCalculate);
            this.btnContainer.Controls.Add(this.textBox4);
            this.btnContainer.Controls.Add(this.labelLateFee);
            this.btnContainer.Controls.Add(this.textBox3);
            this.btnContainer.Controls.Add(this.labelNumberOfDaysLate);
            this.btnContainer.Controls.Add(this.textBox2);
            this.btnContainer.Controls.Add(this.labelCurrentDate);
            this.btnContainer.Controls.Add(this.textBox1);
            this.btnContainer.Controls.Add(this.labelDueDate);
            this.btnContainer.Location = new System.Drawing.Point(512, 59);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(408, 471);
            this.btnContainer.TabIndex = 6;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.Location = new System.Drawing.Point(46, 40);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(94, 24);
            this.labelDueDate.TabIndex = 0;
            this.labelDueDate.Text = "Due Date";
            this.labelDueDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 22);
            this.textBox2.TabIndex = 3;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(47, 127);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(125, 24);
            this.labelCurrentDate.TabIndex = 2;
            this.labelCurrentDate.Text = "Current Date";
            this.labelCurrentDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 22);
            this.textBox3.TabIndex = 5;
            // 
            // labelNumberOfDaysLate
            // 
            this.labelNumberOfDaysLate.AutoSize = true;
            this.labelNumberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfDaysLate.Location = new System.Drawing.Point(46, 217);
            this.labelNumberOfDaysLate.Name = "labelNumberOfDaysLate";
            this.labelNumberOfDaysLate.Size = new System.Drawing.Size(201, 24);
            this.labelNumberOfDaysLate.TabIndex = 4;
            this.labelNumberOfDaysLate.Text = "Number Of Days Late";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 332);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 22);
            this.textBox4.TabIndex = 7;
            // 
            // labelLateFee
            // 
            this.labelLateFee.AutoSize = true;
            this.labelLateFee.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLateFee.Location = new System.Drawing.Point(47, 305);
            this.labelLateFee.Name = "labelLateFee";
            this.labelLateFee.Size = new System.Drawing.Size(86, 24);
            this.labelLateFee.TabIndex = 6;
            this.labelLateFee.Text = "Late Fee";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCalculate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(51, 390);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 42);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(219, 390);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 42);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // newRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 615);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newRelease";
            this.Text = "New Release";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelLateFee;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelNumberOfDaysLate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReturn;
    }
}