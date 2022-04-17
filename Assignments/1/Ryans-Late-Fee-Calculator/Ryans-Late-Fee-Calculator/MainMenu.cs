/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 03
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

        //variable for maintenance form
        RentalMaintenanceForm rentalFormObj;
        public static RentalItemDB rentalDbObj;

        // varables for total number of movies calculated for each type
        public static int newReleasedMoviesCount = 0;
        public static int libraryMoviesCount = 0;
        public static int kidsMoviesCount = 0;

        public static string typeNewRelease = "New Release";
        public static string typeLibraryMovies = "Library Movies";
        public static string typeKidsMovies = "Kid's Movies";

        // variable for checking customer type
        public enum customerType
        {
            New,
            Junior,
            Loyal
        };

        // assigning late fee rate for the corresponding movie type
        private double newReleaseRate = 2.00;
        private double libraryMoviesRate = 0.57;
        private double kidMoviesRate = 0.15;
        public MainMenu()
        {
            // creating objects and assigning them to the variables
            newReleaseObj = new CalculateFee(typeNewRelease, newReleasedMoviesCount, newReleaseRate, typeNewRelease + " ($" + newReleaseRate + "/day)", this);
            libraryObj = new CalculateFee(typeLibraryMovies, libraryMoviesCount, libraryMoviesRate, typeLibraryMovies + " ($" + libraryMoviesRate + "/day)", this);
            kidsObj = new CalculateFee(typeKidsMovies, kidsMoviesCount, kidMoviesRate, typeKidsMovies + " ($" + kidMoviesRate + "/day)", this);

            rentalFormObj = new RentalMaintenanceForm(newReleaseObj, libraryObj, kidsObj);
            rentalDbObj = new RentalItemDB();

            //setting event handler for different type of form while closing
            newReleaseObj.VisibleChanged += new EventHandler(this.CalculateFee_SetText);
            libraryObj.VisibleChanged += new EventHandler(this.CalculateFee_SetText);
            kidsObj.VisibleChanged += new EventHandler(this.CalculateFee_SetText);

            newReleaseObj.FormClosing += new FormClosingEventHandler(this.CalculateFee_SetText);
            libraryObj.FormClosing += new FormClosingEventHandler(this.CalculateFee_SetText);
            kidsObj.FormClosing += new FormClosingEventHandler(this.CalculateFee_SetText);

            InitializeComponent();
        }

        //method for new release button click
        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            try
            {
                newReleaseObj.ShowDialog(); // showing the form 
            }
            catch(System.ObjectDisposedException) // exception if the object is disposed already 
            {
                newReleaseObj = new CalculateFee(typeNewRelease, newReleasedMoviesCount, newReleaseRate, typeNewRelease + " ($" + newReleaseRate + "/day)", this);
                newReleaseObj.ShowDialog();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                MessageBox.Show(msg);
            }
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            try
            {
                kidsObj.ShowDialog();  // showing the form
            }
            catch (System.ObjectDisposedException) // exception if the object is disposed already 
            {
                kidsObj = new CalculateFee(typeKidsMovies, kidsMoviesCount, kidMoviesRate, typeKidsMovies + " ($" + kidMoviesRate + "/day)", this);
                kidsObj.ShowDialog();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                MessageBox.Show(msg);
            }
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            try
            {
                libraryObj.ShowDialog();  // showing the form
            }
            catch (System.ObjectDisposedException) // exception if the object is disposed already 
            {
                libraryObj = new CalculateFee(typeLibraryMovies, libraryMoviesCount, libraryMoviesRate, typeLibraryMovies + " ($" + libraryMoviesRate + "/day)", this);
                libraryObj.ShowDialog();
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                MessageBox.Show(msg);
            }
        }

        //setting text of the labels in the main menu
        private void CalculateFee_SetText(object sender, EventArgs e)
        {
            double currentTotalFee = CalculateFee.newMovieTotalFee + CalculateFee.libraryMovieTotalFee + CalculateFee.kidsMovieTotalFee;
            valueCurrentCalculatedFee.Text = currentTotalFee.ToString("c");
            valueTotalFee.Text = CalculateFee.totalCalculatedFee.ToString("c");
        }


        // event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearData()
        {
            CalculateFee.newMovieTotalFee = 0;
            CalculateFee.libraryMovieTotalFee = 0;
            CalculateFee.kidsMovieTotalFee = 0;
            CalculateFee.totalCalculatedFee = 0;
            newReleasedMoviesCount = 0;
            libraryMoviesCount = 0;
            kidsMoviesCount = 0;
            valueTotalFee.Text = "0.00";
            valueCurrentCalculatedFee.Text = "0.00";
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                rentalFormObj.ShowDialog();  // showing the form
            }
            catch (Exception ex) // exception for other errors
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }
    }
}
