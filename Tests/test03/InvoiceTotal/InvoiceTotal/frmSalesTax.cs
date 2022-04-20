using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        internal static decimal NewTax; //variable for new tax
        public frmSalesTax()
        {
            InitializeComponent();
        }

        // method for clearing user input
        private void ClearData()
        {
            salesPct.Text = "";
        }

        private void ProcessData()
        {
            if (
                Validator.IsPresent(salesPct, "Sales tax percentage") 
                && Validator.IsDecimal(salesPct, "Sales tax percentage", out decimal taxPct)
                && Validator.IsWithinRange(salesPct, "Sales tax percentage", 0, 10)
            ) // validating the data
            {
                this.DialogResult = DialogResult.OK; // setting the DialogResult to 0
                ClearData(); // clearing data
                NewTax = taxPct; // updating the static variable to the valid data
                this.Close(); // closing the form
            }
        }

        // ok button event handler
        private void btnOk_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        //cancel button event handler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
