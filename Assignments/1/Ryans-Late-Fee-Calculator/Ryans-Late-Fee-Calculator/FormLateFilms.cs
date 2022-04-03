using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ryans_Late_Fee_Calculator
{
    public partial class FormLateFilms : Form
    {
        private SortedList lateMovies = new SortedList();
        private int count = 0;
        public static int SavedData { get; private set; }
        public FormLateFilms()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
        }

        // adding movie to the list view
        private void AddMovieToTheList(string movie)
        {
            labelErrorMovieName.Visible = false; // hiding any error message
            lateMovies.Add(count++, movie);
            movieName.Text = ""; // changing text to null after add
            movieList.Items.Add(movie); // adding to the list
            movieName.Focus(); // changing focus to the input box
        }

        //event handler for add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string movie = movieName.Text;
            if (Validator.IsPresent(movie)) // checking for valid value
            {
                AddMovieToTheList(movie);
            }
            else
            {
                labelErrorMovieName.Text = "Please enter a movie name"; // setting error message
                labelErrorMovieName.Visible = true; // showing the error message
            }
        }

        //event handler for ok button
        private void btnOk_Click(object sender, EventArgs e)
        {
            SavedData = lateMovies.Count;
        }
    }
}
