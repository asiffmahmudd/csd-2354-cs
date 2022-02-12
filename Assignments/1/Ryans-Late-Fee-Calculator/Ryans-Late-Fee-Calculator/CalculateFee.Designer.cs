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
            this.btnContainer = new System.Windows.Forms.Panel();
            this.numberOfMoviesCalculated = new System.Windows.Forms.TextBox();
            this.labelNumberOfMoviesCalculated = new System.Windows.Forms.Label();
            this.labelErrorCustomerType = new System.Windows.Forms.Label();
            this.labelErrorNumberOfMovies = new System.Windows.Forms.Label();
            this.labelErrorDueDate = new System.Windows.Forms.Label();
            this.customerType = new System.Windows.Forms.TextBox();
            this.labelCustomerType = new System.Windows.Forms.Label();
            this.numberOfMovies = new System.Windows.Forms.TextBox();
            this.labelNumberOfMovies = new System.Windows.Forms.Label();
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
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.numberOfMoviesCalculated);
            this.btnContainer.Controls.Add(this.labelNumberOfMoviesCalculated);
            this.btnContainer.Controls.Add(this.labelErrorCustomerType);
            this.btnContainer.Controls.Add(this.labelErrorNumberOfMovies);
            this.btnContainer.Controls.Add(this.labelErrorDueDate);
            this.btnContainer.Controls.Add(this.customerType);
            this.btnContainer.Controls.Add(this.labelCustomerType);
            this.btnContainer.Controls.Add(this.numberOfMovies);
            this.btnContainer.Controls.Add(this.labelNumberOfMovies);
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
            this.btnContainer.Location = new System.Drawing.Point(516, 54);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(408, 675);
            this.btnContainer.TabIndex = 2;
            // 
            // numberOfMoviesCalculated
            // 
            this.numberOfMoviesCalculated.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMoviesCalculated.Location = new System.Drawing.Point(48, 532);
            this.numberOfMoviesCalculated.Name = "numberOfMoviesCalculated";
            this.numberOfMoviesCalculated.ReadOnly = true;
            this.numberOfMoviesCalculated.Size = new System.Drawing.Size(311, 26);
            this.numberOfMoviesCalculated.TabIndex = 19;
            this.numberOfMoviesCalculated.TabStop = false;
            // 
            // labelNumberOfMoviesCalculated
            // 
            this.labelNumberOfMoviesCalculated.AutoSize = true;
            this.labelNumberOfMoviesCalculated.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfMoviesCalculated.Location = new System.Drawing.Point(45, 505);
            this.labelNumberOfMoviesCalculated.Name = "labelNumberOfMoviesCalculated";
            this.labelNumberOfMoviesCalculated.Size = new System.Drawing.Size(273, 24);
            this.labelNumberOfMoviesCalculated.TabIndex = 18;
            this.labelNumberOfMoviesCalculated.Text = "Number of Movies Calculated";
            // 
            // labelErrorCustomerType
            // 
            this.labelErrorCustomerType.AutoSize = true;
            this.labelErrorCustomerType.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCustomerType.Location = new System.Drawing.Point(49, 250);
            this.labelErrorCustomerType.Name = "labelErrorCustomerType";
            this.labelErrorCustomerType.Size = new System.Drawing.Size(172, 16);
            this.labelErrorCustomerType.TabIndex = 11;
            this.labelErrorCustomerType.Text = "Invalid Customer Type Input";
            this.labelErrorCustomerType.Visible = false;
            // 
            // labelErrorNumberOfMovies
            // 
            this.labelErrorNumberOfMovies.AutoSize = true;
            this.labelErrorNumberOfMovies.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNumberOfMovies.Location = new System.Drawing.Point(49, 170);
            this.labelErrorNumberOfMovies.Name = "labelErrorNumberOfMovies";
            this.labelErrorNumberOfMovies.Size = new System.Drawing.Size(189, 16);
            this.labelErrorNumberOfMovies.TabIndex = 8;
            this.labelErrorNumberOfMovies.Text = "Invalid Number of Movies Input";
            this.labelErrorNumberOfMovies.Visible = false;
            // 
            // labelErrorDueDate
            // 
            this.labelErrorDueDate.AutoSize = true;
            this.labelErrorDueDate.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDueDate.Location = new System.Drawing.Point(48, 95);
            this.labelErrorDueDate.Name = "labelErrorDueDate";
            this.labelErrorDueDate.Size = new System.Drawing.Size(137, 16);
            this.labelErrorDueDate.TabIndex = 5;
            this.labelErrorDueDate.Text = "Invalid Due Date Input";
            this.labelErrorDueDate.Visible = false;
            // 
            // customerType
            // 
            this.customerType.Location = new System.Drawing.Point(49, 225);
            this.customerType.Name = "customerType";
            this.customerType.Size = new System.Drawing.Size(312, 22);
            this.customerType.TabIndex = 10;
            this.customerType.TextChanged += new System.EventHandler(this.customerType_TextChanged);
            // 
            // labelCustomerType
            // 
            this.labelCustomerType.AutoSize = true;
            this.labelCustomerType.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerType.Location = new System.Drawing.Point(46, 198);
            this.labelCustomerType.Name = "labelCustomerType";
            this.labelCustomerType.Size = new System.Drawing.Size(209, 24);
            this.labelCustomerType.TabIndex = 9;
            this.labelCustomerType.Text = "Customer &Type (N/J/L)";
            // 
            // numberOfMovies
            // 
            this.numberOfMovies.Location = new System.Drawing.Point(50, 145);
            this.numberOfMovies.Name = "numberOfMovies";
            this.numberOfMovies.Size = new System.Drawing.Size(312, 22);
            this.numberOfMovies.TabIndex = 7;
            this.numberOfMovies.TextChanged += new System.EventHandler(this.numberOfMovies_TextChanged);
            // 
            // labelNumberOfMovies
            // 
            this.labelNumberOfMovies.AutoSize = true;
            this.labelNumberOfMovies.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfMovies.Location = new System.Drawing.Point(47, 118);
            this.labelNumberOfMovies.Name = "labelNumberOfMovies";
            this.labelNumberOfMovies.Size = new System.Drawing.Size(177, 24);
            this.labelNumberOfMovies.TabIndex = 6;
            this.labelNumberOfMovies.Text = "&Number Of Movies";
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(50, 70);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(312, 22);
            this.dueDate.TabIndex = 4;
            this.dueDate.TextChanged += new System.EventHandler(this.dueDate_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(220, 582);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 42);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCalculate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(48, 582);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 42);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lateFee
            // 
            this.lateFee.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateFee.Location = new System.Drawing.Point(49, 460);
            this.lateFee.Name = "lateFee";
            this.lateFee.ReadOnly = true;
            this.lateFee.Size = new System.Drawing.Size(311, 26);
            this.lateFee.TabIndex = 17;
            this.lateFee.TabStop = false;
            // 
            // labelLateFee
            // 
            this.labelLateFee.AutoSize = true;
            this.labelLateFee.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLateFee.Location = new System.Drawing.Point(45, 433);
            this.labelLateFee.Name = "labelLateFee";
            this.labelLateFee.Size = new System.Drawing.Size(86, 24);
            this.labelLateFee.TabIndex = 16;
            this.labelLateFee.Text = "Late Fee";
            // 
            // currentDate
            // 
            this.currentDate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(49, 320);
            this.currentDate.Name = "currentDate";
            this.currentDate.ReadOnly = true;
            this.currentDate.Size = new System.Drawing.Size(311, 26);
            this.currentDate.TabIndex = 13;
            this.currentDate.TabStop = false;
            this.currentDate.Text = "\r\n\r\n\r\n";
            // 
            // labelNumberOfDaysLate
            // 
            this.labelNumberOfDaysLate.AutoSize = true;
            this.labelNumberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfDaysLate.Location = new System.Drawing.Point(45, 363);
            this.labelNumberOfDaysLate.Name = "labelNumberOfDaysLate";
            this.labelNumberOfDaysLate.Size = new System.Drawing.Size(201, 24);
            this.labelNumberOfDaysLate.TabIndex = 14;
            this.labelNumberOfDaysLate.Text = "Number Of Days Late";
            // 
            // numberOfDaysLate
            // 
            this.numberOfDaysLate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDaysLate.Location = new System.Drawing.Point(50, 390);
            this.numberOfDaysLate.Name = "numberOfDaysLate";
            this.numberOfDaysLate.ReadOnly = true;
            this.numberOfDaysLate.Size = new System.Drawing.Size(311, 26);
            this.numberOfDaysLate.TabIndex = 15;
            this.numberOfDaysLate.TabStop = false;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(46, 293);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(254, 24);
            this.labelCurrentDate.TabIndex = 12;
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
            this.labelDueDate.Text = "&Due Date (mm/dd/yyyy)";
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
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox lateFee;
        private System.Windows.Forms.Label labelLateFee;
        private System.Windows.Forms.TextBox currentDate;
        private System.Windows.Forms.Label labelNumberOfDaysLate;
        private System.Windows.Forms.TextBox numberOfDaysLate;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox dueDate;
        private System.Windows.Forms.TextBox customerType;
        private System.Windows.Forms.Label labelCustomerType;
        private System.Windows.Forms.TextBox numberOfMovies;
        private System.Windows.Forms.Label labelNumberOfMovies;
        private System.Windows.Forms.Label labelErrorDueDate;
        private System.Windows.Forms.Label labelErrorNumberOfMovies;
        private System.Windows.Forms.Label labelErrorCustomerType;
        private System.Windows.Forms.TextBox numberOfMoviesCalculated;
        private System.Windows.Forms.Label labelNumberOfMoviesCalculated;

        // btn handlers

    }
}