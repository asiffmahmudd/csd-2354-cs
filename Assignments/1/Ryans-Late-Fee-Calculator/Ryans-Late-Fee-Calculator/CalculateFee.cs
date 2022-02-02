/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 01
*/
using System;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class calculateFee : Form
    {
        private double lateFeeRate;
        public calculateFee()
        {
            InitializeComponent();
            this.currentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");  //getting today's date and changing the value of current day field
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
        }

        public void setLateFee(double lateFee, String titleText) 
        {
            this.lateFeeRate = lateFee;
            title.Text = titleText;
        }

        private DateTime getDueDate()
        {
            String dueDateValue = this.dueDate.Text;
                
            if(dueDateValue.IndexOf('/') > 0)  //checking if the date contains slash, otherwise the format is wrong
            {
                String[] s = dueDateValue.Split('/'); // splitting the string with '/' delimeter to get month, day and year
                if(s.Length == 3)  // if the string's length is not 3 (mm/dd/yyyy) then it's a wrong date
                {
                    int day, month, year;
                    bool isNumberValid = int.TryParse(s[1], out day);
                    if (isNumberValid && day >= 1 && day <= 31)  // validating day of the date
                    {
                        isNumberValid = int.TryParse(s[0], out month);
                        if(isNumberValid && month >= 1 && month <= 12)  // validating month of the date
                        {
                            isNumberValid = int.TryParse(s[2], out year);

                            if (isNumberValid && year <= DateTime.Now.Year)  // checking if the year is valid
                            {
                                DateTime resultDate;
                                String dateString = year+ "/" + month + "/" + day;
                                if(DateTime.TryParse(dateString, out resultDate))
                                {
                                    if (DateTime.Now >= resultDate)  // validating the whole date
                                    {
                                        return resultDate;  // returning a valid date
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+1);  
            // returning a larger date than the current date to mark it as invalid
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;  // getting the current date 

            String dueDateValue = this.dueDate.Text;
            
            if (dueDateValue == "")     // checking if the field is empty
            {
                MessageBox.Show("Current date can't be empty");
            }
            else
            {
                DateTime resultDate = getDueDate();                         
                if(resultDate > DateTime.Now)                               
                {
                    MessageBox.Show("Invalid Date");
                    this.numberOfDaysLate.Text = "";
                    this.lateFee.Text = "";
                }
                else 
                {
                    int dayDifference = (int)(currentDate - resultDate).TotalDays;  // storing the difference in a variable
                    this.numberOfDaysLate.Text = dayDifference.ToString();  // changing the textbox value of number of days late
                    double totalFee = dayDifference * this.lateFeeRate;  // calculating totalFee
                    this.lateFee.Text = totalFee.ToString("c");  // changing the textbox value of late fee
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();  // closing the current form
        }

    }
}
