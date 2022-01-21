using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class LibraryMovie : Form
    {
        private double lateFeeRate = 0.57;
        public LibraryMovie()
        {
            InitializeComponent();
            this.currentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");                    //getting today's date and changing the value of current day field
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
        }

        private DateTime getDueDate()
        {
            String dueDateValue = this.dueDate.Text;

            if (dueDateValue.IndexOf('/') > 0)
            {
                String[] s = dueDateValue.Split('/');
                if (s.Length == 3)
                {
                    int day, month, year;
                    bool isNumberValid = int.TryParse(s[1], out day);
                    if (isNumberValid && day >= 1 && day <= 31)                            // validating day of the date
                    {
                        isNumberValid = int.TryParse(s[0], out month);
                        if (isNumberValid && month >= 1 && month <= 12)                     // validating month of the date
                        {
                            isNumberValid = int.TryParse(s[2], out year);

                            if (isNumberValid && year <= DateTime.Now.Year)                // checking if the year is valid
                            {
                                DateTime resultDate;
                                String dateString = year + "/" + month + "/" + day;
                                if (DateTime.TryParse(dateString, out resultDate))
                                {
                                    if (DateTime.Now >= resultDate)                        // validating the whole date
                                    {
                                        return resultDate;                                 // returning a valid date
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Date");
                this.numberOfDaysLate.Text = "";                            // in case of an error making the fields empty
                this.lateFee.Text = "";                                     // in case of an error making the fields empty
            }
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1); // returning a larger date than the current date to mark it as invalid
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;                                 // getting the current date 

            String dueDateValue = this.dueDate.Text;

            if (dueDateValue == "")                                         // checking if the field is empty
            {
                MessageBox.Show("Current date can't be empty");
            }
            else
            {
                DateTime resultDate = getDueDate();
                if (resultDate > DateTime.Now)
                {
                    MessageBox.Show("Invalid Date");
                    this.numberOfDaysLate.Text = "";
                    this.lateFee.Text = "";
                }
                else
                {
                    int dayDifference = (int)(currentDate - resultDate).TotalDays;      // storing the difference in a variable
                    this.numberOfDaysLate.Text = dayDifference.ToString();              // changing the textbox value of number of days late
                    double totalFee = dayDifference * this.lateFeeRate;                  // calculating totalFee
                    this.lateFee.Text = "$" + totalFee.ToString();                      // changing the textbox value of late fee
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();                     // closing the current form
        }
    }
}
