namespace Ryans_Late_Fee_Calculator
{
    partial class NewMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMovie));
            this.formPanel = new System.Windows.Forms.Panel();
            this.labelErrorRating = new System.Windows.Forms.Label();
            this.labelErrorDescription = new System.Windows.Forms.Label();
            this.labelErrorMovieNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveMovie = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.movieNo = new System.Windows.Forms.TextBox();
            this.labelMovieNo = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelErrorMovieType = new System.Windows.Forms.Label();
            this.movieType = new System.Windows.Forms.ComboBox();
            this.labelMovieType = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formPanel.Controls.Add(this.labelErrorMovieType);
            this.formPanel.Controls.Add(this.movieType);
            this.formPanel.Controls.Add(this.labelMovieType);
            this.formPanel.Controls.Add(this.labelErrorRating);
            this.formPanel.Controls.Add(this.labelErrorDescription);
            this.formPanel.Controls.Add(this.labelErrorMovieNo);
            this.formPanel.Controls.Add(this.btnCancel);
            this.formPanel.Controls.Add(this.btnSaveMovie);
            this.formPanel.Controls.Add(this.description);
            this.formPanel.Controls.Add(this.labelDescription);
            this.formPanel.Controls.Add(this.movieNo);
            this.formPanel.Controls.Add(this.labelMovieNo);
            this.formPanel.Controls.Add(this.rating);
            this.formPanel.Controls.Add(this.labelRating);
            this.formPanel.Location = new System.Drawing.Point(102, 47);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(369, 444);
            this.formPanel.TabIndex = 0;
            // 
            // labelErrorRating
            // 
            this.labelErrorRating.AutoSize = true;
            this.labelErrorRating.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRating.Location = new System.Drawing.Point(26, 305);
            this.labelErrorRating.Name = "labelErrorRating";
            this.labelErrorRating.Size = new System.Drawing.Size(82, 16);
            this.labelErrorRating.TabIndex = 12;
            this.labelErrorRating.Text = "Invalid rating";
            this.labelErrorRating.Visible = false;
            // 
            // labelErrorDescription
            // 
            this.labelErrorDescription.AutoSize = true;
            this.labelErrorDescription.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDescription.Location = new System.Drawing.Point(28, 148);
            this.labelErrorDescription.Name = "labelErrorDescription";
            this.labelErrorDescription.Size = new System.Drawing.Size(163, 16);
            this.labelErrorDescription.TabIndex = 6;
            this.labelErrorDescription.Text = "Please enter a description";
            this.labelErrorDescription.Visible = false;
            // 
            // labelErrorMovieNo
            // 
            this.labelErrorMovieNo.AutoSize = true;
            this.labelErrorMovieNo.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMovieNo.Location = new System.Drawing.Point(30, 66);
            this.labelErrorMovieNo.Name = "labelErrorMovieNo";
            this.labelErrorMovieNo.Size = new System.Drawing.Size(104, 16);
            this.labelErrorMovieNo.TabIndex = 3;
            this.labelErrorMovieNo.Text = "Invalid movie no";
            this.labelErrorMovieNo.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(29, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(315, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveMovie
            // 
            this.btnSaveMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnSaveMovie.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveMovie.ForeColor = System.Drawing.Color.White;
            this.btnSaveMovie.Location = new System.Drawing.Point(29, 342);
            this.btnSaveMovie.Name = "btnSaveMovie";
            this.btnSaveMovie.Size = new System.Drawing.Size(315, 32);
            this.btnSaveMovie.TabIndex = 13;
            this.btnSaveMovie.Text = "&Save Movie";
            this.btnSaveMovie.UseVisualStyleBackColor = false;
            this.btnSaveMovie.Click += new System.EventHandler(this.btnSaveMovie_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(31, 123);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(312, 22);
            this.description.TabIndex = 5;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(28, 96);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(113, 24);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "&Description";
            // 
            // movieNo
            // 
            this.movieNo.Location = new System.Drawing.Point(32, 41);
            this.movieNo.Name = "movieNo";
            this.movieNo.Size = new System.Drawing.Size(312, 22);
            this.movieNo.TabIndex = 2;
            this.movieNo.TextChanged += new System.EventHandler(this.movieNo_TextChanged);
            // 
            // labelMovieNo
            // 
            this.labelMovieNo.AutoSize = true;
            this.labelMovieNo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieNo.Location = new System.Drawing.Point(29, 14);
            this.labelMovieNo.Name = "labelMovieNo";
            this.labelMovieNo.Size = new System.Drawing.Size(93, 24);
            this.labelMovieNo.TabIndex = 1;
            this.labelMovieNo.Text = "&Movie No";
            // 
            // rating
            // 
            this.rating.FormattingEnabled = true;
            this.rating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.rating.Location = new System.Drawing.Point(28, 277);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(308, 24);
            this.rating.TabIndex = 11;
            this.rating.SelectedValueChanged += new System.EventHandler(this.rating_SelectedValueChanged);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(27, 250);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(69, 24);
            this.labelRating.TabIndex = 10;
            this.labelRating.Text = "&Rating";
            // 
            // labelErrorMovieType
            // 
            this.labelErrorMovieType.AutoSize = true;
            this.labelErrorMovieType.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMovieType.Location = new System.Drawing.Point(27, 230);
            this.labelErrorMovieType.Name = "labelErrorMovieType";
            this.labelErrorMovieType.Size = new System.Drawing.Size(115, 16);
            this.labelErrorMovieType.TabIndex = 9;
            this.labelErrorMovieType.Text = "Invalid movie type";
            this.labelErrorMovieType.Visible = false;
            // 
            // movieType
            // 
            this.movieType.FormattingEnabled = true;
            this.movieType.Items.AddRange(new object[] {
            "New Release",
            "Library Movies",
            "Kid\'s Movies"});
            this.movieType.Location = new System.Drawing.Point(29, 202);
            this.movieType.Name = "movieType";
            this.movieType.Size = new System.Drawing.Size(308, 24);
            this.movieType.TabIndex = 8;
            this.movieType.SelectedIndexChanged += new System.EventHandler(this.movieType_SelectedIndexChanged);
            // 
            // labelMovieType
            // 
            this.labelMovieType.AutoSize = true;
            this.labelMovieType.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieType.Location = new System.Drawing.Point(28, 175);
            this.labelMovieType.Name = "labelMovieType";
            this.labelMovieType.Size = new System.Drawing.Size(111, 24);
            this.labelMovieType.TabIndex = 7;
            this.labelMovieType.Text = "&Movie Type";
            // 
            // NewMovie
            // 
            this.AcceptButton = this.btnSaveMovie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(567, 539);
            this.Controls.Add(this.formPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMovie";
            this.Text = "New Movie";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.ComboBox rating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox movieNo;
        private System.Windows.Forms.Label labelMovieNo;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveMovie;
        private System.Windows.Forms.Label labelErrorRating;
        private System.Windows.Forms.Label labelErrorDescription;
        private System.Windows.Forms.Label labelErrorMovieNo;
        private System.Windows.Forms.Label labelErrorMovieType;
        private System.Windows.Forms.ComboBox movieType;
        private System.Windows.Forms.Label labelMovieType;
    }
}