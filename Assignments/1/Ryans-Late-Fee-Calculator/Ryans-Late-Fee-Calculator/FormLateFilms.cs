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

        private void FormLateFilms_Load(object sender, EventArgs e)
        {
            RentalMaintenanceForm.FillMovieListBox(lateMoviesList);
            List<RentalItem> checkedItems = null;
            List<RentalItem> moviesInTheList = RentalItemDB.GetMovies();
            try
            {
                checkedItems = RentalItemDB.GetCalculatedMovieList(formType); 
                int index = 0;
                foreach (RentalItem listItem in moviesInTheList)
                {
                    foreach (RentalItem checkedItem in checkedItems)
                    {
                        if (listItem.GetMovieNo() == checkedItem.GetMovieNo())
                        {
                            lateMoviesList.SetItemChecked(index, true);
                        }
                    }
                    index++;
                }
            }
            catch(Exception KeyNotFoundException)
            {

            }
        }
    }
}
