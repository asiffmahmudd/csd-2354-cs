namespace Ryans_Late_Fee_Calculator
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.calculatorImage = new System.Windows.Forms.PictureBox();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.valueTotalFee = new System.Windows.Forms.Label();
            this.valueCurrentCalculatedFee = new System.Windows.Forms.Label();
            this.labelCurrentCalculatedFee = new System.Windows.Forms.Label();
            this.btnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.btnMaintenance);
            this.btnContainer.Controls.Add(this.btnExit);
            this.btnContainer.Controls.Add(this.btnKidsMovie);
            this.btnContainer.Controls.Add(this.btnLibraryMovie);
            this.btnContainer.Controls.Add(this.btnNewRelease);
            this.btnContainer.Location = new System.Drawing.Point(512, 59);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(408, 574);
            this.btnContainer.TabIndex = 6;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintenance.Image")));
            this.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Location = new System.Drawing.Point(72, 358);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMaintenance.Size = new System.Drawing.Size(269, 66);
            this.btnMaintenance.TabIndex = 10;
            this.btnMaintenance.Text = "&Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(72, 455);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(269, 66);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit The App";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnKidsMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKidsMovie.ForeColor = System.Drawing.Color.White;
            this.btnKidsMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnKidsMovie.Image")));
            this.btnKidsMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKidsMovie.Location = new System.Drawing.Point(72, 253);
            this.btnKidsMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKidsMovie.Size = new System.Drawing.Size(269, 68);
            this.btnKidsMovie.TabIndex = 9;
            this.btnKidsMovie.Text = "&Kid\'s Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = false;
            this.btnKidsMovie.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnLibraryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryMovie.ForeColor = System.Drawing.Color.White;
            this.btnLibraryMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryMovie.Image")));
            this.btnLibraryMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibraryMovie.Location = new System.Drawing.Point(72, 155);
            this.btnLibraryMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLibraryMovie.Size = new System.Drawing.Size(269, 67);
            this.btnLibraryMovie.TabIndex = 8;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = false;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnNewRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRelease.ForeColor = System.Drawing.Color.White;
            this.btnNewRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRelease.Image")));
            this.btnNewRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRelease.Location = new System.Drawing.Point(72, 55);
            this.btnNewRelease.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.btnNewRelease.Size = new System.Drawing.Size(269, 64);
            this.btnNewRelease.TabIndex = 7;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = false;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.title.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(29, 71);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(427, 41);
            this.title.TabIndex = 0;
            this.title.Text = "Ryan\'s Late Fee Calculator";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.subtitle.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.White;
            this.subtitle.Location = new System.Drawing.Point(32, 129);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(378, 30);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "Calculate your due fees in no time";
            // 
            // calculatorImage
            // 
            this.calculatorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.calculatorImage.Image = ((System.Drawing.Image)(resources.GetObject("calculatorImage.Image")));
            this.calculatorImage.Location = new System.Drawing.Point(36, 186);
            this.calculatorImage.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorImage.Name = "calculatorImage";
            this.calculatorImage.Size = new System.Drawing.Size(233, 297);
            this.calculatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculatorImage.TabIndex = 3;
            this.calculatorImage.TabStop = false;
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelTotalFee.ForeColor = System.Drawing.Color.White;
            this.labelTotalFee.Location = new System.Drawing.Point(32, 519);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(210, 26);
            this.labelTotalFee.TabIndex = 2;
            this.labelTotalFee.Text = "Total fee calculation:";
            // 
            // valueTotalFee
            // 
            this.valueTotalFee.AutoSize = true;
            this.valueTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.valueTotalFee.ForeColor = System.Drawing.Color.White;
            this.valueTotalFee.Location = new System.Drawing.Point(271, 519);
            this.valueTotalFee.Name = "valueTotalFee";
            this.valueTotalFee.Size = new System.Drawing.Size(66, 26);
            this.valueTotalFee.TabIndex = 3;
            this.valueTotalFee.Text = "$0.00";
            // 
            // valueCurrentCalculatedFee
            // 
            this.valueCurrentCalculatedFee.AutoSize = true;
            this.valueCurrentCalculatedFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.valueCurrentCalculatedFee.ForeColor = System.Drawing.Color.White;
            this.valueCurrentCalculatedFee.Location = new System.Drawing.Point(402, 554);
            this.valueCurrentCalculatedFee.Name = "valueCurrentCalculatedFee";
            this.valueCurrentCalculatedFee.Size = new System.Drawing.Size(66, 26);
            this.valueCurrentCalculatedFee.TabIndex = 5;
            this.valueCurrentCalculatedFee.Text = "$0.00";
            // 
            // labelCurrentCalculatedFee
            // 
            this.labelCurrentCalculatedFee.AutoSize = true;
            this.labelCurrentCalculatedFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelCurrentCalculatedFee.ForeColor = System.Drawing.Color.White;
            this.labelCurrentCalculatedFee.Location = new System.Drawing.Point(32, 554);
            this.labelCurrentCalculatedFee.Name = "labelCurrentCalculatedFee";
            this.labelCurrentCalculatedFee.Size = new System.Drawing.Size(339, 26);
            this.labelCurrentCalculatedFee.TabIndex = 4;
            this.labelCurrentCalculatedFee.Text = "Calculated fee for all movie types:";
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnNewRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(960, 700);
            this.Controls.Add(this.valueCurrentCalculatedFee);
            this.Controls.Add(this.labelCurrentCalculatedFee);
            this.Controls.Add(this.valueTotalFee);
            this.Controls.Add(this.labelTotalFee);
            this.Controls.Add(this.calculatorImage);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Ryan\'s Late Fee Calculator";
            this.btnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.PictureBox calculatorImage;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKidsMovie;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label valueTotalFee;
        private System.Windows.Forms.Label valueCurrentCalculatedFee;
        private System.Windows.Forms.Label labelCurrentCalculatedFee;
        private System.Windows.Forms.Button btnMaintenance;
    }
}

