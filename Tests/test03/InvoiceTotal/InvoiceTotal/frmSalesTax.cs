using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        //value for checking 
        internal static decimal NewTax;
        public frmSalesTax()
        {
            InitializeComponent();
        }

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
            )
            {
                this.DialogResult = DialogResult.OK;
                ClearData();
                NewTax = taxPct;
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
