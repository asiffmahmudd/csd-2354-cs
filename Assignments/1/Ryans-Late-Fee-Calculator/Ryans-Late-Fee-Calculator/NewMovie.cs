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
    public partial class NewMovie : Form
    {
        RentalItem newItem = null;
        public NewMovie()
        {
            InitializeComponent();
            rating.SelectedIndex = 0;
            movieType.SelectedIndex = 0;
        }

        // method for showing the form
        public RentalItem GetNewRental()
        {
            ShowDialog();
            return newItem;
        }

        //method for showing the error messages
        private void SetErrorMsg(bool valid, Label obj, string errorMsg)
        {
            if (!valid) // checking validity
            {
                obj.Text = errorMsg; // setting error message
                obj.Visible = true; // showing error message
            }
        }

        //method for clearing the error messages
        private void ClearErrorMessage()
        {
            labelErrorMovieNo.Text = "";
            labelErrorDescription.Text = "";
            labelErrorRating.Text = "";
        }

        // data validation
        public bool IsDataValid()
        {
            string movieNoText = this.movieNo.Text;
            string description = this.description.Text;
            string rating = this.rating.Text;
            string movieType = this.movieType.Text;

            bool isMovieNoValid = Validator.IsMovieNoValid(movieNoText, out int movieNo, out string errorMsgMovieNo);
            bool isDescriptionValid = Validator.IsPresent(description);
            bool isMovieTypeValid = Validator.IsMovieTypeValid(movieType);
            bool isRatingValid = Validator.IsRatingValid(rating);
            if (isMovieNoValid && isDescriptionValid && isMovieTypeValid && isRatingValid) // checking if all the fields are valid
            {
                newItem = new RentalItem(movieNo, description, movieType, rating);
                return true;
            }
            else
            {
                //setting error messages to the corresponding field
                SetErrorMsg(isMovieNoValid, labelErrorMovieNo, errorMsgMovieNo);
                SetErrorMsg(isDescriptionValid, labelErrorDescription, "Please enter a description");
                SetErrorMsg(isMovieTypeValid, labelErrorMovieType, "Please enter a valid movie type");
                SetErrorMsg(isRatingValid, labelErrorRating, "Please enter a valid rating");
                return false;
            }
        }

        //event handler for save button
        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                ClearErrorMessage();
                Close();
            }
        }

        //event handler for change in movie no field
        private void movieNo_TextChanged(object sender, EventArgs e)
        {
            // clearing out the error message
            labelErrorMovieNo.Text = "";
        }

        //event handler for change in description field
        private void description_TextChanged(object sender, EventArgs e)
        {
            // clearing out the error message
            labelErrorDescription.Text = "";
        }

        //event handler for change in rating field
        private void rating_SelectedValueChanged(object sender, EventArgs e)
        {
            // clearing out the error message
            labelErrorRating.Text = "";
        }

        private void movieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clearing out the error message
            labelErrorMovieType.Text = "";
        }
    }
}
