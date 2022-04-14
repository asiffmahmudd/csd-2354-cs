/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 05
*/
using System;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class CalculateFee : Form
    {
        private double lateFeeRate; // variable for late fee of the form
        private string formType;
        public static double newMovieTotalFee { get; private set; }
        public static double libraryMovieTotalFee { get; private set; }
        public static double kidsMovieTotalFee { get; private set; }
        public static double totalCalculatedFee { get; private set; }

        Form addMovieForm;

        public CalculateFee(string formType, int moviesCount, double lateFee, string titleText)
        {
            InitializeComponent();
            currentDate.Value = DateTime.Today;  //getting today's date and changing the value of current day field
            numberOfMoviesCalculated.Text = moviesCount.ToString();
            dueDate.MaxDate = DateTime.Today.AddDays(-1);
            dueDate.Value = DateTime.Today.AddDays(-1);
            customerType.SelectedIndex = 0;
            this.formType = formType;
            lateFeeRate = lateFee;
            title.Text = titleText;
            addMovieForm = new FormLateFilms(formType);
            //btnReturn.DialogResult = DialogResult.OK;
        }

        //calculating the discount 
        private double GetDiscountRate(string customerType)
        {
            if(customerType == "Junior")
            {
                return 0.05;
            }
            else if(customerType == "Loyal")
            {
                return 0.10;
            }
            return 0;
        }

        private void SetNumberOfMoviesCalculated(int numberOfMovies)
        {
            int movieCount = 0;
            // checking form type and then assigning the value to the corresponding variable
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
            numberOfMoviesCalculated.Text = movieCount.ToString(); // setting the textbox of the form
        }

        private int GetNumberOfDaysLate(DateTime currentDate, DateTime dueDate)
        {
            int dayDifference = (int)(currentDate - dueDate).TotalDays;  // storing the difference in a variable
            return dayDifference;
        }

        private void SetTotalLateFee(double totalLateFee)
        {
            if (formType == MainMenu.typeNewRelease)
            {
                newMovieTotalFee = totalLateFee;
            }
            else if (formType == MainMenu.typeLibraryMovies)
            {
                libraryMovieTotalFee = totalLateFee;
            }
            else if (formType == MainMenu.typeKidsMovies)
            {
                kidsMovieTotalFee = totalLateFee;
            }
            totalCalculatedFee += totalLateFee;
        }

        // setting the textboxes with appropriate values
        private void SetTextBoxes(int numberOfDays, double totalLateFee, int numberOfMovies)
        {
            SetNumberOfMoviesCalculated(numberOfMovies); // setting the variable for total number of movies calculated
            numberOfDaysLate.Text = numberOfDays.ToString();  // changing the textbox value of number of days late
            lateFee.Text = totalLateFee.ToString("c");  // changing the textbox value of late fee
            SetTotalLateFee(totalLateFee);
        }

        // method for getting the input from the textboxes
        public void GetInputs(out DateTime currentDateValue, out DateTime dueDateValue, out string customerType, out string numberOfMovies)
        {
            currentDateValue = DateTime.Today;  // getting the current date 
            dueDateValue = dueDate.Value;
            customerType = this.customerType.Text; // getting user input
            numberOfMovies = this.numberOfMovies.Text;
        }

        //method for calculating fee 
        public void CalculateAndSetText(DateTime currentDateValue, DateTime dueDateValue, string customerType, int numberOfMovies)
        {
            int numberOfDaysLate = GetNumberOfDaysLate(currentDateValue, dueDateValue);
            double discountPercent = GetDiscountRate(customerType);
            double lateFee = this.lateFeeRate * numberOfDaysLate * numberOfMovies;
            if (discountPercent > 0)
            {
                lateFee -= lateFee * discountPercent;
            }
            SetTextBoxes(numberOfDaysLate, lateFee, numberOfMovies);
        }

        public bool IsDataValid(out DateTime currentDateValue, out DateTime dueDateValue, out string customerType,
                                out int numberOfMovies)
        {
            GetInputs(out currentDateValue, out dueDateValue, out customerType, out string numberOfMoviesValue);
            bool isNumberOfMoviesValid = Validator.IsNumberOfMoviesValid(numberOfMoviesValue, out numberOfMovies, "Number of Movies", out string errorMsgNumberOfMovies);
            bool isCustomerTypeValid = Validator.IsCustomerTypeValid(customerType);
            if (isNumberOfMoviesValid && isCustomerTypeValid){
                return true;
            }
            else
            {
                //setting error message for the particular fields
                SetErrorMsg(isNumberOfMoviesValid, labelErrorNumberOfMovies, errorMsgNumberOfMovies);
                //clearing the fields if an error is found
                ClearTextBoxes();
            }
            return false;
        }

        private void CalculateLateFee()
        {
            try
            {
                // data validation
                if (IsDataValid(out DateTime currentDateValue, out DateTime dueDateValue, out string customerType,
                                out int numberOfMovies))
                {
                    CalculateAndSetText(currentDateValue, dueDateValue, customerType, numberOfMovies);
                    btnReturn.Focus();
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        //method for clearing the text boxes
        private void ClearTextBoxes()
        {
            numberOfDaysLate.Text = "";
            lateFee.Text = "";
        }

        //method for clearing the input fields
        private void ResetUserInput()
        {
            dueDate.Value = DateTime.Today.AddDays(-1);
            numberOfMovies.Text = "";
            customerType.SelectedIndex = 0;
        }

        private void ClearErrorMessage()
        {
            labelErrorNumberOfMovies.Text = "";
        }

        //method for setting error message
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
            CalculateLateFee();
        }

        //event handler for return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(); // clearing the text boxes
            ResetUserInput(); // clearing the text boxes
            ClearErrorMessage(); // clearing error messages
            dueDate.Focus();
            Hide();  // closing the current form
        }

        
        // event handler for text change in number of movies
        private void numberOfMovies_TextChanged(object sender, EventArgs e)
        {
            labelErrorNumberOfMovies.Visible = false;
            lateFee.Text = "";
        }

        private void dueDate_ValueChanged(object sender, EventArgs e)
        {
            numberOfDaysLate.Text = "";
        }

        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            DialogResult selectedBtn = addMovieForm.ShowDialog();
            if(selectedBtn == DialogResult.OK)
            {
                numberOfMovies.Text = FormLateFilms.SavedData.ToString();
            }
        }

    }
}
