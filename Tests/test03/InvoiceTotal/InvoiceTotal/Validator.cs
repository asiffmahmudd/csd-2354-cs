using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    internal class Validator
    {
        //validation for checking null value
        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error"); // showing message box for error
                textBox.Focus();
                return false;
            }
            return true;
        }

        //validation for checking decimal value
        public static bool IsDecimal(TextBox textBox, string name, out decimal number)
        {
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error"); // showing message box for error
                textBox.Focus();
                return false;
            }
        }

        // validation for checking if the value is within range
        public static bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            Decimal.TryParse(textBox.Text, out decimal number);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error"); // showing message box for error
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
