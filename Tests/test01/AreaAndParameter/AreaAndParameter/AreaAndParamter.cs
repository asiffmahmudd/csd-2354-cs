using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Asif Mahmud
 * ID: C0837117
 * Test: 01
 * Answer: 01
*/

namespace AreaAndParameter
{
    public partial class areaAndParameter : Form
    {

        public areaAndParameter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) // method for exit button
        {
            this.Close(); // closing the form
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal diameter = 0; // variable for storing user input of diameter
            if(decimal.TryParse(textDiameter.Text, out diameter) && diameter >= 0) // checking if it's a valid input or not
            {
                decimal radius = diameter / 2.0m; // calculating radius
                decimal area = (decimal)Math.PI * radius * radius; // calculating area
                decimal perimeter = 2 * (decimal)Math.PI * radius; // calculating perimeter

                textArea.Text = area.ToString("0.00"); // setting area to the textbox
                textPerimeter.Text = perimeter.ToString("0.00"); // setting perimeter to the textbox
                textDiameter.Focus(); // focusing diameter textbox
            }
            else
            {
                MessageBox.Show("Invalid input!"); // message for invalid input
            }
        }

    }
}
