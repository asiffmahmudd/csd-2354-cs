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
        public List<RentalItem> MovieList = null;
        public RentalMaintenanceForm()
        {
            InitializeComponent();
            MovieList = new List<RentalItem>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            NewMovie newMovieFormObj = new NewMovie();
            RentalItem newMovie = newMovieFormObj.GetNewRental();
            if(newMovie != null)
            {
                MovieList.Add(newMovie);
                RentalItemDB.SaveMovies(MovieList);
                FillMovieListBox(movieListBox);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if(movieListBox.SelectedIndex != -1)
            {
                MovieList.RemoveAt(movieListBox.SelectedIndex);
                movieListBox.Items.Remove(movieListBox.SelectedItem);
                RentalItemDB.SaveMovies(MovieList);
            }
        }

        private void RentalMaintenanceForm_Load(object sender, EventArgs e)
        {
            FillMovieListBox(movieListBox);
        }

        public static void FillMovieListBox(ListBox listBox)
        {
            List<RentalItem> movieList = RentalItemDB.GetMovies();
            if (movieList != null)
            {
                listBox.Items.Clear();
                for (int i = 0; i < movieList.Count; i++)
                {
                    listBox.Items.Add(new ListItem { Text = movieList[i].GetDisplayText(), 
                                      Value = movieList[i]});
                }
            }
        }
    }
}
