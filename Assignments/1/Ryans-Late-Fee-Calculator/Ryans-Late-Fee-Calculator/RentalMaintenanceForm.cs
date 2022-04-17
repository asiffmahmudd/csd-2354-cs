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
    public partial class RentalMaintenanceForm : Form
    {
        public List<RentalItem> MovieList = null; // variable for the movies

        private CalculateFee newReleaseObj;
        private CalculateFee libraryMovieObj;
        private CalculateFee kidsObj;
        public RentalMaintenanceForm(CalculateFee newRelease, CalculateFee library, CalculateFee kids)
        {
            InitializeComponent();
            MovieList = new List<RentalItem>();
            newReleaseObj = newRelease;
            libraryMovieObj = library;
            kidsObj = kids;
        }

        //event handler for the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event handler for the add button
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            NewMovie newMovieFormObj = new NewMovie();
            RentalItem newMovie = newMovieFormObj.GetNewRental();
            if(newMovie != null)
            {
                MovieList.Add(newMovie); // adding movie to the list
                RentalItemDB.SaveMovies(MovieList); // saving movie in the database
                FillMovieListBox(movieListBox, "all"); // filling the list box with the movie items
            }
        }

        //clear input fields for the calculate form
        public void ClearData()
        {
            newReleaseObj.ClearData();
            libraryMovieObj.ClearData();
            kidsObj.ClearData();
        }

        //event handler for the delete button
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if(movieListBox.SelectedIndex != -1) // checking if a movie is selected
            {
                MovieList.RemoveAt(movieListBox.SelectedIndex); // removing movie from the list
                movieListBox.Items.Remove(movieListBox.SelectedItem); // removing movie from the view
                RentalItemDB.SaveMovies(MovieList); // saving the updated list in the database
                RentalItemDB.ClearSelectedMovies();
                ClearData();
            }
            else
            {
                // showing error when a movie is not selected
                MessageBox.Show("Please select at least one movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //event handler when the form loads
        private void RentalMaintenanceForm_Load(object sender, EventArgs e)
        {
            //calling the method for filling out the list with movie names
            FillMovieListBox(movieListBox, "all");
        }

        //method for filling the movie list box
        public static void FillMovieListBox(ListBox listBox, string formType)
        {
            List<RentalItem> movieList = RentalItemDB.GetMovies(); // getting data from the database
            if (movieList != null) // checking if it's null
            {
                listBox.Items.Clear(); // clearing the current list
                if (formType == "all")
                {
                    for (int i = 0; i < movieList.Count; i++) // looping through all the movies 
                    {

                        listBox.Items.Add(new ListItem
                        {
                            Text = movieList[i].GetDisplayText(),
                            Value = movieList[i]
                        }); // adding to the list

                    }
                }
                else
                {
                    for (int i = 0; i < movieList.Count; i++) // looping through all the movies 
                    {
                        if (movieList[i].GetMovieType() == formType)
                        {
                            listBox.Items.Add(new ListItem
                            {
                                Text = movieList[i].GetDisplayText(),
                                Value = movieList[i]
                            }); // adding to the list
                        }
                    }
                }
            }
        }
    }
}
