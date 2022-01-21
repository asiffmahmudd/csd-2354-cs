namespace Ryans_Late_Fee_Calculator
{
    partial class KidsMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KidsMovie));
            this.btnContainer = new System.Windows.Forms.Panel();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lateFee = new System.Windows.Forms.TextBox();
            this.labelLateFee = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.TextBox();
            this.labelNumberOfDaysLate = new System.Windows.Forms.Label();
            this.numberOfDaysLate = new System.Windows.Forms.TextBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.calculatorImage = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.dueDate);
            this.btnContainer.Controls.Add(this.btnReturn);
            this.btnContainer.Controls.Add(this.btnCalculate);
            this.btnContainer.Controls.Add(this.lateFee);
            this.btnContainer.Controls.Add(this.labelLateFee);
            this.btnContainer.Controls.Add(this.currentDate);
            this.btnContainer.Controls.Add(this.labelNumberOfDaysLate);
            this.btnContainer.Controls.Add(this.numberOfDaysLate);
            this.btnContainer.Controls.Add(this.labelCurrentDate);
            this.btnContainer.Controls.Add(this.labelDueDate);
            this.btnContainer.Location = new System.Drawing.Point(512, 59);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(408, 471);
            this.btnContainer.TabIndex = 8;
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(50, 70);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(312, 22);
            this.dueDate.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(219, 390);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 42);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCalculate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(51, 390);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 42);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lateFee
            // 
            this.lateFee.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateFee.Location = new System.Drawing.Point(51, 332);
            this.lateFee.Name = "lateFee";
            this.lateFee.ReadOnly = true;
            this.lateFee.Size = new System.Drawing.Size(311, 26);
            this.lateFee.TabIndex = 10;
            this.lateFee.TabStop = false;
            // 
            // labelLateFee
            // 
            this.labelLateFee.AutoSize = true;
            this.labelLateFee.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLateFee.Location = new System.Drawing.Point(47, 305);
            this.labelLateFee.Name = "labelLateFee";
            this.labelLateFee.Size = new System.Drawing.Size(86, 24);
            this.labelLateFee.TabIndex = 9;
            this.labelLateFee.Text = "Late Fee";
            // 
            // currentDate
            // 
            this.currentDate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(50, 154);
            this.currentDate.Name = "currentDate";
            this.currentDate.ReadOnly = true;
            this.currentDate.Size = new System.Drawing.Size(311, 26);
            this.currentDate.TabIndex = 6;
            this.currentDate.TabStop = false;
            this.currentDate.Text = "\r\n\r\n\r\n";
            // 
            // labelNumberOfDaysLate
            // 
            this.labelNumberOfDaysLate.AutoSize = true;
            this.labelNumberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfDaysLate.Location = new System.Drawing.Point(46, 217);
            this.labelNumberOfDaysLate.Name = "labelNumberOfDaysLate";
            this.labelNumberOfDaysLate.Size = new System.Drawing.Size(201, 24);
            this.labelNumberOfDaysLate.TabIndex = 7;
            this.labelNumberOfDaysLate.Text = "Number Of Days Late";
            // 
            // numberOfDaysLate
            // 
            this.numberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDaysLate.Location = new System.Drawing.Point(51, 244);
            this.numberOfDaysLate.Name = "numberOfDaysLate";
            this.numberOfDaysLate.ReadOnly = true;
            this.numberOfDaysLate.Size = new System.Drawing.Size(311, 26);
            this.numberOfDaysLate.TabIndex = 8;
            this.numberOfDaysLate.TabStop = false;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(47, 127);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(254, 24);
            this.labelCurrentDate.TabIndex = 5;
            this.labelCurrentDate.Text = "Current Date (mm/dd/yyyy)";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.Location = new System.Drawing.Point(47, 43);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(223, 24);
            this.labelDueDate.TabIndex = 3;
            this.labelDueDate.Text = "Due Date (mm/dd/yyyy)";
            // 
            // calculatorImage
            // 
            this.calculatorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.calculatorImage.Image = ((System.Drawing.Image)(resources.GetObject("calculatorImage.Image")));
            this.calculatorImage.Location = new System.Drawing.Point(36, 213);
            this.calculatorImage.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorImage.Name = "calculatorImage";
            this.calculatorImage.Size = new System.Drawing.Size(233, 297);
            this.calculatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculatorImage.TabIndex = 9;
            this.calculatorImage.TabStop = false;
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.subtitle.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.White;
            this.subtitle.Location = new System.Drawing.Point(32, 129);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(319, 30);
            this.subtitle.TabIndex = 7;
            this.subtitle.Text = "Calculate your due fees here";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.title.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(29, 71);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(379, 41);
            this.title.TabIndex = 6;
            this.title.Text = "Kid\'s Movie ($0.15/Day)";
            // 
            // KidsMovie
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(964, 615);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.calculatorImage);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KidsMovie";
            this.Text = "Kid\'s Movie";
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.TextBox dueDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox lateFee;
        private System.Windows.Forms.Label labelLateFee;
        private System.Windows.Forms.TextBox currentDate;
        private System.Windows.Forms.Label labelNumberOfDaysLate;
        private System.Windows.Forms.TextBox numberOfDaysLate;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.PictureBox calculatorImage;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label title;


    }
}