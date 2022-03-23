namespace Ryans_Late_Fee_Calculator
{
    partial class frmLateFilms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLateFilms));
            this.title = new System.Windows.Forms.Label();
            this.calculatorImage = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfMovies = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelErrorLateFilm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).BeginInit();
            this.btnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.title.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(40, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(177, 41);
            this.title.TabIndex = 1;
            this.title.Text = "Late Films";
            // 
            // calculatorImage
            // 
            this.calculatorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.calculatorImage.Image = ((System.Drawing.Image)(resources.GetObject("calculatorImage.Image")));
            this.calculatorImage.Location = new System.Drawing.Point(47, 161);
            this.calculatorImage.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorImage.Name = "calculatorImage";
            this.calculatorImage.Size = new System.Drawing.Size(152, 241);
            this.calculatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculatorImage.TabIndex = 6;
            this.calculatorImage.TabStop = false;
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.subtitle.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.White;
            this.subtitle.Location = new System.Drawing.Point(42, 104);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(118, 30);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "Add Films";
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.White;
            this.btnContainer.Controls.Add(this.labelErrorLateFilm);
            this.btnContainer.Controls.Add(this.btnCancel);
            this.btnContainer.Controls.Add(this.btnOk);
            this.btnContainer.Controls.Add(this.btnAdd);
            this.btnContainer.Controls.Add(this.numberOfMovies);
            this.btnContainer.Controls.Add(this.labelMovieName);
            this.btnContainer.Location = new System.Drawing.Point(326, 74);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(312, 328);
            this.btnContainer.TabIndex = 3;
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieName.Location = new System.Drawing.Point(27, 26);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(121, 24);
            this.labelMovieName.TabIndex = 4;
            this.labelMovieName.Text = "&Movie Name";
            // 
            // numberOfMovies
            // 
            this.numberOfMovies.Location = new System.Drawing.Point(31, 69);
            this.numberOfMovies.Name = "numberOfMovies";
            this.numberOfMovies.Size = new System.Drawing.Size(253, 22);
            this.numberOfMovies.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(31, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(31, 196);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(253, 44);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(217)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(31, 250);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(253, 44);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // labelErrorLateFilm
            // 
            this.labelErrorLateFilm.AutoSize = true;
            this.labelErrorLateFilm.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLateFilm.Location = new System.Drawing.Point(28, 104);
            this.labelErrorLateFilm.Name = "labelErrorLateFilm";
            this.labelErrorLateFilm.Size = new System.Drawing.Size(189, 16);
            this.labelErrorLateFilm.TabIndex = 6;
            this.labelErrorLateFilm.Text = "Invalid Number of Movies Input";
            this.labelErrorLateFilm.Visible = false;
            // 
            // frmLateFilms
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(672, 460);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.calculatorImage);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLateFilms";
            this.Text = "Late Films";
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImage)).EndInit();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox calculatorImage;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.TextBox numberOfMovies;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelErrorLateFilm;
    }
}