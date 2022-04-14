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
            this.rating.SelectedIndex = 0;
        }

        public RentalItem GetNewRental()
        {
            this.ShowDialog();
            return newItem;
        }

        private void SetErrorMsg(bool valid, Label obj, string errorMsg)
        {
            if (!valid) // checking validity
            {
                obj.Text = errorMsg; // setting error message
                obj.Visible = true; // showing error message
            }
        }

        private void ClearErrorMessage()
        {
            labelErrorMovieNo.Text = "";
            labelErrorDescription.Text = "";
            labelErrorRating.Text = "";
        }

        public bool IsDataValid()
        {
            string movieNoText = this.movieNo.Text;
            string description = this.description.Text;
            string rating = this.rating.Text;

            bool isMovieNoValid = Validator.IsMovieNoValid(movieNoText, out int movieNo, out string errorMsgMovieNo);
            bool isDescriptionValid = Validator.IsPresent(description);
            bool isRatingValid = Validator.IsRatingValid(rating);
            if (isMovieNoValid && isDescriptionValid && isRatingValid)
            {
                newItem = new RentalItem(movieNo, description, rating);
                return true;
            }
            else
            {
                SetErrorMsg(isMovieNoValid, labelErrorMovieNo, errorMsgMovieNo);
                SetErrorMsg(isDescriptionValid, labelErrorDescription, "Please enter a description");
                SetErrorMsg(isRatingValid, labelErrorRating, "Please enter a valid rating");
                return false;
            }
        }

        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                ClearErrorMessage();
                this.Close();
            }
        }

        private void movieNo_TextChanged(object sender, EventArgs e)
        {
            labelErrorMovieNo.Text = "";
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            labelErrorDescription.Text = "";
        }

        private void rating_SelectedValueChanged(object sender, EventArgs e)
        {
            labelErrorRating.Text = "";
        }
    }
}
