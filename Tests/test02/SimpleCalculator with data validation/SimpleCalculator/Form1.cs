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


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the value for the operator
                string operator1 = txtOperator.Text;

                // checking the validation of the inputs
                if (Validator.IsValidData(txtOperand1.Text, txtOperand2.Text, out decimal operand1, out decimal operand2, operator1))
                {
                    decimal result = Calculate(operand1, operator1, operand2);
                    //rounding the result up to t2o decimal places
                    result = Math.Round(result, 4);
                    //setting the result text field to the calculated result
                    this.txtResult.Text = result.ToString();
                    txtOperand1.Focus();
                }
            }
            // exception for invalid values
            catch (Exception ex)
            {
                // message box for showing error
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        // calculating result
        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            //checking the operator
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        // event handler for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // event handler for clearing the result text field
        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}