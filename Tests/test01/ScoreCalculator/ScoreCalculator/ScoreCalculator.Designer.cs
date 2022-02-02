namespace ScoreCalculator
{
    partial class scoreCalculator
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
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.TextBox();
            this.textScoreTotal = new System.Windows.Forms.TextBox();
            this.textScoreCount = new System.Windows.Forms.TextBox();
            this.textAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelScore.Location = new System.Drawing.Point(72, 23);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(58, 20);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "&Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(55, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average:";
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(146, 23);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(67, 22);
            this.textScore.TabIndex = 1;
            // 
            // textScoreTotal
            // 
            this.textScoreTotal.Location = new System.Drawing.Point(146, 61);
            this.textScoreTotal.Name = "textScoreTotal";
            this.textScoreTotal.ReadOnly = true;
            this.textScoreTotal.Size = new System.Drawing.Size(67, 22);
            this.textScoreTotal.TabIndex = 4;
            this.textScoreTotal.TabStop = false;
            // 
            // textScoreCount
            // 
            this.textScoreCount.Location = new System.Drawing.Point(146, 109);
            this.textScoreCount.Name = "textScoreCount";
            this.textScoreCount.ReadOnly = true;
            this.textScoreCount.Size = new System.Drawing.Size(67, 22);
            this.textScoreCount.TabIndex = 6;
            this.textScoreCount.TabStop = false;
            // 
            // textAverage
            // 
            this.textAverage.Location = new System.Drawing.Point(146, 151);
            this.textAverage.Name = "textAverage";
            this.textAverage.ReadOnly = true;
            this.textAverage.Size = new System.Drawing.Size(67, 22);
            this.textAverage.TabIndex = 8;
            this.textAverage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Location = new System.Drawing.Point(247, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnClearScores.Location = new System.Drawing.Point(113, 193);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(100, 35);
            this.btnClearScores.TabIndex = 9;
            this.btnClearScores.Text = "&Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.Location = new System.Drawing.Point(247, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // scoreCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(378, 249);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textAverage);
            this.Controls.Add(this.textScoreCount);
            this.Controls.Add(this.textScoreTotal);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Name = "scoreCalculator";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.TextBox textScoreTotal;
        private System.Windows.Forms.TextBox textScoreCount;
        private System.Windows.Forms.TextBox textAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
    }
}

