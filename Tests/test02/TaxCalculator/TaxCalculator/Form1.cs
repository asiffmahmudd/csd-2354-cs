using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Asif Mahmud
 * ID: C0837117
*/

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // event handler for close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event handler for calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // checking for a valid value
                if (Validator.IsIncomeValid(txtIncome.Text, out decimal income))
                {
                    //calling the the CalculateTax method to get the calculated tax
                    decimal tax = CalculateTax(income);

                    // setting the text field with the calculated tax
                    txtTax.Text = tax.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method for calculating tax
        private decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;
            if (income <= 9225)
                tax = (int)(income * .10m);
            else if (income > 9225 && income <= 37450)
                tax = 922.50m + (int)((income - 9225) * .15m);
            else if (income > 37450 && income <= 90750)
                tax = 5156.25m + (int)((income - 37450) * .25m);
            else if (income > 90750 && income <= 189300)
                tax = 18481.25m + (int)((income - 90750) * .28m);
            else if (income > 189300 && income <= 411500)
                tax = 46075.25m + (int)((income - 189300) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = 119996.25m + (int)((income - 413200) * .396m);
            return tax;
        }

        // event handler for text change in the income text field
        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            txtTax.Text = "";
        }
    }
}
