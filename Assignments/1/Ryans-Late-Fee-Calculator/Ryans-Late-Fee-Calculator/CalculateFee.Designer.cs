namespace Ryans_Late_Fee_Calculator
{
    partial class CalculateFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateFee));
            this.title = new System.Windows.Forms.Label();
            this.calculatorImage = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.numberOfDaysLate = new System.Windows.Forms.TextBox();
            this.labelNumberOfDaysLate = new System.Windows.Forms.Label();
            this.labelLateFee = new System.Windows.Forms.Label();
            this.lateFee = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelNumberOfMovies = new System.Windows.Forms.Label();
            this.numberOfMovies = new System.Windows.Forms.TextBox();
            this.labelCustomerType = new System.Windows.Forms.Label();
            this.labelErrorNumberOfMovies = new System.Windows.Forms.Label();
            this.labelNumberOfMoviesCalculated = new System.Windows.Forms.Label();
            this.numberOfMoviesCalculated = new System.Windows.Forms.TextBox();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnAddMovies = new System.Windows.Forms.Button();
            this.currentDate = new System.Windows.Forms.DateTimePicker();
            this.customerType = new System.Windows.Forms.ComboBox();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).BeginInit();
            this.btnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.title.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(31, 102);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(373, 41);
            this.title.TabIndex = 0;
            this.title.Text = "New Releases ($2/Day)";
            // 
            // calculatorImage
            // 
            this.calculatorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.calculatorImage.Image = ((System.Drawing.Image)(resources.GetObject("calculatorImage.Image")));
            this.calculatorImage.Location = new System.Drawing.Point(38, 241);
            this.calculatorImage.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorImage.Name = "calculatorImage";
            this.calculatorImage.Size = new System.Drawing.Size(315, 433);
            this.calculatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculatorImage.TabIndex = 5;
            this.calculatorImage.TabStop = false;
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.subtitle.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.White;
            this.subtitle.Location = new System.Drawing.Point(34, 160);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(319, 30);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "Calculate your due fees here";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.Location = new System.Drawing.Point(47, 43);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(99, 24);
            this.labelDueDate.TabIndex = 3;
            this.labelDueDate.Text = "&Due Date ";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(46, 292);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(254, 24);
            this.labelCurrentDate.TabIndex = 11;
            this.labelCurrentDate.Text = "Current Date (mm/dd/yyyy)";
            // 
            // numberOfDaysLate
            // 
            this.numberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDaysLate.Location = new System.Drawing.Point(50, 389);
            this.numberOfDaysLate.Name = "numberOfDaysLate";
            this.numberOfDaysLate.ReadOnly = true;
            this.numberOfDaysLate.Size = new System.Drawing.Size(311, 26);
            this.numberOfDaysLate.TabIndex = 14;
            this.numberOfDaysLate.TabStop = false;
            // 
            // labelNumberOfDaysLate
            // 
            this.labelNumberOfDaysLate.AutoSize = true;
            this.labelNumberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfDaysLate.Location = new System.Drawing.Point(45, 362);
            this.labelNumberOfDaysLate.Name = "labelNumberOfDaysLate";
            this.labelNumberOfDaysLate.Size = new System.Drawing.Size(201, 24);
            this.labelNumberOfDaysLate.TabIndex = 13;
            this.labelNumberOfDaysLate.Text = "Number Of Days Late";
            // 
            // labelLateFee
            // 
            this.labelLateFee.AutoSize = true;
            this.labelLateFee.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLateFee.Location = new System.Drawing.Point(45, 432);
            this.labelLateFee.Name = "labelLateFee";
            this.labelLateFee.Size = new System.Drawing.Size(86, 24);
            this.labelLateFee.TabIndex = 15;
            this.labelLateFee.Text = "Late Fee";
            // 
            // lateFee
            // 
            this.lateFee.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateFee.Location = new System.Drawing.Point(49, 459);
            this.lateFee.Name = "lateFee";
            this.lateFee.ReadOnly = true;
            this.lateFee.Size = new System.Drawing.Size(311, 26);
            this.lateFee.TabIndex = 16;
            this.lateFee.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCalculate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(51, 581);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 42);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelNumberOfMovies
            // 
            this.labelNumberOfMovies.AutoSize = true;
            this.labelNumberOfMovies.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfMovies.Location = new System.Drawing.Point(47, 111);
            this.labelNumberOfMovies.Name = "labelNumberOfMovies";
            this.labelNumberOfMovies.Size = new System.Drawing.Size(177, 24);
            this.labelNumberOfMovies.TabIndex = 5;
            this.labelNumberOfMovies.Text = "&Number Of Movies";
            // 
            // numberOfMovies
            // 
            this.numberOfMovies.Location = new System.Drawing.Point(50, 138);
            this.numberOfMovies.Name = "numberOfMovies";
            this.numberOfMovies.ReadOnly = true;
            this.numberOfMovies.Size = new System.Drawing.Size(312, 22);
            this.numberOfMovies.TabIndex = 6;
            this.numberOfMovies.TabStop = false;
            this.numberOfMovies.TextChanged += new System.EventHandler(this.numberOfMovies_TextChanged);
            // 
            // labelCustomerType
            // 
            this.labelCustomerType.AutoSize = true;
            this.labelCustomerType.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerType.Location = new System.Drawing.Point(46, 226);
            this.labelCustomerType.Name = "labelCustomerType";
            this.labelCustomerType.Size = new System.Drawing.Size(145, 24);
            this.labelCustomerType.TabIndex = 9;
            this.labelCustomerType.Text = "Customer &Type";
            // 
            // labelErrorNumberOfMovies
            // 
            this.labelErrorNumberOfMovies.AutoSize = true;
            this.labelErrorNumberOfMovies.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNumberOfMovies.Location = new System.Drawing.Point(49, 163);
            this.labelErrorNumberOfMovies.Name = "labelErrorNumberOfMovies";
            this.labelErrorNumberOfMovies.Size = new System.Drawing.Size(189, 16);
            this.labelErrorNumberOfMovies.TabIndex = 7;
            this.labelErrorNumberOfMovies.Text = "Invalid Number of Movies Input";
            this.labelErrorNumberOfMovies.Visible = false;
            // 
            // labelNumberOfMoviesCalculated
            // 
            this.labelNumberOfMoviesCalculated.AutoSize = true;
            this.labelNumberOfMoviesCalculated.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfMoviesCalculated.Location = new System.Drawing.Point(45, 504);
            this.labelNumberOfMoviesCalculated.Name = "labelNumberOfMoviesCalculated";
            this.labelNumberOfMoviesCalculated.Size = new System.Drawing.Size(273, 24);
            this.labelNumberOfMoviesCalculated.TabIndex = 17;
            this.labelNumberOfMoviesCalculated.Text = "Number of Movies Calculated";
            // 
            // numberOfMoviesCalculated
            // 
            this.numberOfMoviesCalculated.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMoviesCalculated.Location = new System.Drawing.Point(48, 531);
            this.numberOfMoviesCalculated.Name = "numberOfMoviesCalculated";
            this.numberOfMoviesCalculated.ReadOnly = true;
            this.numberOfMoviesCalculated.Size = new System.Drawing.Size(311, 26);
            this.numberOfMoviesCalculated.TabIndex = 18;
            this.numberOfMoviesCalculated.TabStop = false;
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.btnAddMovies);
            this.btnContainer.Controls.Add(this.currentDate);
            this.btnContainer.Controls.Add(this.customerType);
            this.btnContainer.Controls.Add(this.dueDate);
            this.btnContainer.Controls.Add(this.btnReturn);
            this.btnContainer.Controls.Add(this.numberOfMoviesCalculated);
            this.btnContainer.Controls.Add(this.labelNumberOfMoviesCalculated);
            this.btnContainer.Controls.Add(this.labelErrorNumberOfMovies);
            this.btnContainer.Controls.Add(this.labelCustomerType);
            this.btnContainer.Controls.Add(this.numberOfMovies);
            this.btnContainer.Controls.Add(this.labelNumberOfMovies);
            this.btnContainer.Controls.Add(this.btnCalculate);
            this.btnContainer.Controls.Add(this.lateFee);
            this.btnContainer.Controls.Add(this.labelLateFee);
            this.btnContainer.Controls.Add(this.labelNumberOfDaysLate);
            this.btnContainer.Controls.Add(this.numberOfDaysLate);
            this.btnContainer.Controls.Add(this.labelCurrentDate);
            this.btnContainer.Controls.Add(this.labelDueDate);
            this.btnContainer.Location = new System.Drawing.Point(516, 54);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(408, 675);
            this.btnContainer.TabIndex = 2;
            // 
            // btnAddMovies
            // 
            this.btnAddMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnAddMovies.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMovies.ForeColor = System.Drawing.Color.White;
            this.btnAddMovies.Location = new System.Drawing.Point(48, 182);
            this.btnAddMovies.Name = "btnAddMovies";
            this.btnAddMovies.Size = new System.Drawing.Size(315, 32);
            this.btnAddMovies.TabIndex = 8;
            this.btnAddMovies.Text = "&Add Movies";
            this.btnAddMovies.UseVisualStyleBackColor = false;
            this.btnAddMovies.Click += new System.EventHandler(this.btnAddMovies_Click);
            // 
            // currentDate
            // 
            this.currentDate.Enabled = false;
            this.currentDate.Location = new System.Drawing.Point(52, 320);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(307, 22);
            this.currentDate.TabIndex = 12;
            this.currentDate.TabStop = false;
            // 
            // customerType
            // 
            this.customerType.FormattingEnabled = true;
            this.customerType.Items.AddRange(new object[] {
            "New",
            "Junior",
            "Loyal"});
            this.customerType.Location = new System.Drawing.Point(51, 254);
            this.customerType.Name = "customerType";
            this.customerType.Size = new System.Drawing.Size(308, 24);
            this.customerType.TabIndex = 10;
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(51, 70);
            this.dueDate.MaxDate = new System.DateTime(2022, 2, 15, 0, 0, 0, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(311, 22);
            this.dueDate.TabIndex = 4;
            this.dueDate.Value = new System.DateTime(2022, 2, 15, 0, 0, 0, 0);
            this.dueDate.ValueChanged += new System.EventHandler(this.dueDate_ValueChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(217, 581);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 42);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CalculateFee
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(964, 773);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.calculatorImage);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateFee";
            this.Text = "New Release";
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).EndInit();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox calculatorImage;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.TextBox numberOfDaysLate;
        private System.Windows.Forms.Label labelNumberOfDaysLate;
        private System.Windows.Forms.Label labelLateFee;
        private System.Windows.Forms.TextBox lateFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelNumberOfMovies;
        private System.Windows.Forms.TextBox numberOfMovies;
        private System.Windows.Forms.Label labelCustomerType;
        private System.Windows.Forms.Label labelErrorNumberOfMovies;
        private System.Windows.Forms.Label labelNumberOfMoviesCalculated;
        private System.Windows.Forms.TextBox numberOfMoviesCalculated;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.ComboBox customerType;
        private System.Windows.Forms.DateTimePicker currentDate;
        private System.Windows.Forms.Button btnAddMovies;

        // btn handlers

    }
}