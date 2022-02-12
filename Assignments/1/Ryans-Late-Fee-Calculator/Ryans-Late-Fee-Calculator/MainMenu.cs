/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 01
*/
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
    public partial class MainMenu : Form
    {
        // declaring variables for three forms
        CalculateFee newReleaseObj; 
        CalculateFee libraryObj;
        CalculateFee kidsObj;

        public static int newReleasedMoviesCount = 0;
        public static int libraryMoviesCount = 0;
        public static int kidsMoviesCount = 0;

        public static string typeNewRelease = "New Release";
        public static string typeLibraryMovies = "Library Movies";
        public static string typeKidsMovies = "Kid's Movies";

        private double newReleaseRate = 2.00;
        private double libraryMoviesRate = 0.57;
        private double kidMoviesRate = 0.15;
        public MainMenu()
        {
            // creating objects and assigning them to the variables
            newReleaseObj = new CalculateFee(typeNewRelease, newReleasedMoviesCount, newReleaseRate, typeNewRelease + " ($" + newReleaseRate + "/day)");
            libraryObj = new CalculateFee(typeLibraryMovies, libraryMoviesCount, libraryMoviesRate, typeLibraryMovies + " ($" + libraryMoviesRate + "/day)");
            kidsObj = new CalculateFee(typeKidsMovies, kidsMoviesCount, kidMoviesRate, typeKidsMovies + " ($" + kidMoviesRate + "/day)");
            InitializeComponent();
        }

        //method for new realeas button click
        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            try
            {
                newReleaseObj.Show(); // showing the form 
            }
            catch(System.ObjectDisposedException) // exception if the object is disposed already 
            {
                newReleaseObj = new CalculateFee(typeNewRelease, newReleasedMoviesCount, newReleaseRate, typeNewRelease + " ($" + newReleaseRate + "/day)");
                newReleaseObj.Show();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            try
            {
                kidsObj.Show();  // showing the form
            }
            catch (System.ObjectDisposedException) // exception if the object is disposed already 
            {
                kidsObj = new CalculateFee(typeKidsMovies, kidsMoviesCount, kidMoviesRate, typeKidsMovies + " ($" + kidMoviesRate + "/day)");
                kidsObj.Show();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            try
            {
                libraryObj.Show();  // showing the form
            }
            catch (System.ObjectDisposedException) // exception if the object is disposed already 
            {
                libraryObj = new CalculateFee(typeLibraryMovies, libraryMoviesCount, libraryMoviesRate, typeLibraryMovies + " ($" + libraryMoviesRate + "/day)");
                libraryObj.Show();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }
        // event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
