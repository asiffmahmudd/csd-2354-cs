using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public static frmSalesTax frmTaxObj = null;
        public frmInvoiceTotal()
        {
            InitializeComponent();
            frmTaxObj = new frmSalesTax();
        }

        decimal SalesTaxPct = 7.75m;

        private decimal GetDiscountPercent(decimal productTotal)
        {
            decimal discountPercent = .0m;

            if (productTotal < 100)
                discountPercent = .0m;
            else if (productTotal >= 100 && productTotal < 250)
                discountPercent = .1m;
            else if (productTotal >= 250)
                discountPercent = .25m;

            return discountPercent;
        }

        private void SetTextBoxes(decimal discountAmount, decimal subtotal, decimal tax, decimal total)
        {
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = total.ToString("c");
        }

        private void CalculateData(decimal productTotal)
        {
            decimal discountPercent = GetDiscountPercent(productTotal);
            decimal discountAmount = productTotal * discountPercent;
            decimal subtotal = productTotal - discountAmount;
            decimal tax = subtotal * SalesTaxPct / 100;
            decimal total = subtotal + tax;

            SetTextBoxes(discountAmount, subtotal, tax, total);
        }

        private void ProcessData()
        {
            if (
                Validator.IsPresent(txtProductTotal, "Subtotal") &&
                Validator.IsDecimal(txtProductTotal, "Subtotal", out decimal productTotal) &&
                Validator.IsWithinRange(txtProductTotal, "Subtotal", 0, 1000000)
               )
            {
                CalculateData(productTotal);
                txtProductTotal.Focus();
            }
        }

        private void ChangeTax(decimal newTax)
        {
            SalesTaxPct = newTax;
            labelTax.Text = "Tax (" + SalesTaxPct.ToString("0.00") +"%):";
            ClearFields();
            txtProductTotal.Focus();
        }

        private void ClearFields()
        {
            txtDiscountAmount.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            DialogResult isOk = frmTaxObj.ShowDialog();
            if (DialogResult.OK == isOk)
            {
                decimal newTax = frmSalesTax.NewTax;
                ChangeTax(newTax);
            }
        }
    }
}