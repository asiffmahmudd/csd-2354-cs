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
        public static int SavedData { get; private set; }
        private List<RentalItem> movieList;
        private string formType;
        public FormLateFilms(string formType)
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            movieList = new List<RentalItem>();
            this.formType = formType;
        }

        // adding movie to the list view
        private void AddMovieToTheList()
        {
            movieList.Clear();
            foreach (ListItem item in lateMoviesList.CheckedItems)
            {
                movieList.Add(item.Value);
            }
            RentalItemDB.SaveMovieTypeList(formType, movieList);
        }

        //event handler for ok button
        private void btnOk_Click(object sender, EventArgs e)
        {
            SavedData = lateMoviesList.CheckedItems.Count;
            if (SavedData > 0) // checking for valid value
            {
                AddMovieToTheList();
            }
        }

        //this method executes when the form loads and fill in the necesssary data
        private void FormLateFilms_Load(object sender, EventArgs e)
        {
            RentalMaintenanceForm.FillMovieListBox(lateMoviesList, formType); //filling in the list of movies
            List<RentalItem> checkedItems = null; // variable for already checked items
            List<RentalItem> moviesInTheList = RentalItemDB.GetMovieList(formType); // current movie list in the database
            try
            {
                checkedItems = RentalItemDB.GetCalculatedMovieList(formType); // getting the checked items from db
                int index = 0;
                foreach (RentalItem listItem in moviesInTheList) // looping through all items
                {
                    foreach (RentalItem checkedItem in checkedItems) // looping through the checked items
                    {
                        if (listItem.GetMovieNo() == checkedItem.GetMovieNo()) // checking if the item is checked
                        {
                            lateMoviesList.SetItemChecked(index, true); // checking the item
                        }
                    }
                    index++;
                }
            }
            catch(Exception KeyNotFoundException)
            {
                Console.WriteLine(KeyNotFoundException.Message);
            }
        }
    }
}
