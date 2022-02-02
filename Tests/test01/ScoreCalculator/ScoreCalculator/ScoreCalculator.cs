using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Asif Mahmud
 * ID: C0837117
 * Test: 01
*/

namespace ScoreCalculator
{
    public partial class scoreCalculator : Form
    {
        int scoreTotal = 0, scoreCount = 0; // initialing variables
        double average = 0; // initialing variables
        public scoreCalculator()
        {
            InitializeComponent();
        }

        /*
         * - Knock knock 
         * - Who's there?
         * - I. O.
         * - I. O who?
         * - Me. You owe me 2 bonus marks for this joke.
         * ref - https://bestlifeonline.com/knock-knock-jokes/
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = 0; 
            if (Int32.TryParse(textScore.Text, out score) && score >= 0) // checking if it's a valid value
            {
                scoreTotal += score; // adding to total score
                scoreCount++; // increasing score count
                textScore.Text = ""; // if it's a valid value changing the textbox for score to empty
                average = scoreTotal * 1.00 / scoreCount ; // calculating average

                textScoreTotal.Text = scoreTotal.ToString(); // changing the textbox for total score
                textScoreCount.Text = scoreCount.ToString(); // changing the textbox for score count
                textAverage.Text = average.ToString("0.##"); // changing the score box for average
                textScore.Focus(); // focusing on the text score textbox for more user input
            }
            else
            {
                MessageBox.Show("Invalid input"); // showing a message if it's an invalid value
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e) // method for clearing scores
        {
            // assigning all the variable to zero 
            scoreTotal = 0;
            scoreCount = 0;
            average = 0;

            // making all the text box empty 
            textScoreTotal.Text = "";
            textScoreCount.Text = "";
            textAverage.Text = "";
            textScore.Text = "";

            // focusing on the text score textbox for more user input
            textScore.Focus(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closing the application
            this.Close();
        }
    }
}
