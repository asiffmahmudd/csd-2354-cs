/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 01
*/
using System;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class CalculateFee : Form
    {
        private double lateFeeRate; // variable for late fee of the form
        private string formType;
        public CalculateFee(string formType, int moviesCount, double lateFee, string titleText)
        {
            InitializeComponent();
            this.currentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");  //getting today's date and changing the value of current day field
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.numberOfMoviesCalculated.Text = moviesCount.ToString();
            this.formType = formType;
            this.lateFeeRate = lateFee;
            title.Text = titleText;
        }


        private double CalculateDiscount(string customerType, double totalFee)
        {
            if(customerType == "J")
            {
                totalFee -=  totalFee * 0.05;
            }
            else if(customerType == "L")
            {
                totalFee -= totalFee * 0.10;
            }
            return totalFee;
        }

        private void setNumberOfMoviesCalculated(int numberOfMovies)
        {
            int movieCount = 0;
            if(formType == MainMenu.typeNewRelease)
            {
                MainMenu.newReleasedMoviesCount += numberOfMovies;
                movieCount = MainMenu.newReleasedMoviesCount;
            }
            else if (formType == MainMenu.typeLibraryMovies)
            {
                MainMenu.libraryMoviesCount += numberOfMovies;
                movieCount = MainMenu.libraryMoviesCount;
            }
            else if (formType == MainMenu.typeKidsMovies)
            {
                MainMenu.kidsMoviesCount += numberOfMovies;
                movieCount = MainMenu.kidsMoviesCount;
            }
            this.numberOfMoviesCalculated.Text = movieCount.ToString();
        }

        private void setLateFee(int dayDifference, int numberOfMovies, string customerType)
        {
            double totalFee = dayDifference * numberOfMovies * this.lateFeeRate;  // calculating totalFee
            totalFee = CalculateDiscount(customerType, totalFee);
            this.lateFee.Text = totalFee.ToString("c");  // changing the textbox value of late fee
        }

        private int setAndGetNumberOfDaysLate(DateTime currentDate, DateTime dueDate)
        {
            int dayDifference = (int)(currentDate - dueDate).TotalDays;  // storing the difference in a variable
            this.numberOfDaysLate.Text = dayDifference.ToString();  // changing the textbox value of number of days late
            return dayDifference;
        }

        private void CalculateAndSetTextBox(DateTime dueDate, DateTime currentDate, int numberOfMovies, string customerType)
        {
            DateTime resultDate; // variable for storing the input

            int dayDifference = setAndGetNumberOfDaysLate(currentDate, dueDate);
            setLateFee(dayDifference, numberOfMovies, customerType);

            setNumberOfMoviesCalculated(numberOfMovies);
        }

        //method for clearing the text boxes
        private void ClearTextBoxes()
        {
            this.numberOfDaysLate.Text = "";
            this.lateFee.Text = "";
        }

        private void ClearUserInput()
        {
            this.dueDate.Text = "";
            this.numberOfMovies.Text = "";
            this.customerType.Text = "";
        }

        private void SetErrorMsg(bool valid, Label obj, string errorMsg)
        {
            if (!valid) // checking validity
            {
                obj.Text = errorMsg; // setting error message
                obj.Visible = true; // showing error message
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;  // getting the current date 
            
            string dueDateValue = this.dueDate.Text; // getting user input
            bool isDueDateValid = Validator.IsDueDateValid(dueDateValue, out DateTime dueDate, out string errorMsgDueDate); // checking validity

            string numberOfMoviesValue = this.numberOfMovies.Text; // getting user input
            bool isNumberOfMoviesValid = Validator.IsInt(numberOfMoviesValue, 
                out int numberOfMovies, "Number of Movies", out string errorMsgNumberOfMovies); // checking validity

            string customerType = this.customerType.Text; // getting user input
            bool isCustomerTypeValid = Validator.IsCustomerTypeValid(customerType, out string errorMsgCustomerType); // checking validity

            if (isDueDateValid && isNumberOfMoviesValid && isCustomerTypeValid)  //validating the date input using Validator class                             
            {
                CalculateAndSetTextBox(dueDate, currentDate, numberOfMovies, customerType);
                
                this.btnReturn.Focus();
            }
            else 
            {
                //setting error message for the particular fields
                SetErrorMsg(isDueDateValid, this.labelErrorDueDate, errorMsgDueDate);
                SetErrorMsg(isNumberOfMoviesValid, this.labelErrorNumberOfMovies, errorMsgNumberOfMovies);
                SetErrorMsg(isCustomerTypeValid, this.labelErrorCustomerType, errorMsgCustomerType);
                //clearing the fields if an error is found
                ClearTextBoxes();
            }
        }

        //event handler for return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(); // clearing the text boxes
            ClearUserInput(); // clearing the text boxes
            this.Hide();  // closing the current form
        }

        // event handler for text change in due date
        private void dueDate_TextChanged(object sender, EventArgs e)
        {
            this.labelErrorDueDate.Visible = false;
        }
        // event handler for text change in number of movies
        private void numberOfMovies_TextChanged(object sender, EventArgs e)
        {
            this.labelErrorNumberOfMovies.Visible = false;
        }
        // event handler for text change in customer type
        private void customerType_TextChanged(object sender, EventArgs e)
        {
            this.labelErrorCustomerType.Visible = false;
        }

    }
}
