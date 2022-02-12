using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    internal class Validator
    {
        public static bool IsDueDateValid(string dueDateValue, out DateTime dueDate,out string errorMsg)
        {
            errorMsg = null;
            bool isParsed = DateTime.TryParse(dueDateValue, out dueDate); // trying to parse the date input and storing it to the variable
            if (!isParsed) 
            {
                if (string.IsNullOrEmpty(dueDateValue))  // checking if the field is empty
                {
                    errorMsg = "Current date can't be empty"; //assigning error message
                }
                else // error found
                {
                    errorMsg = "Invalid date input!"; //assigning error message
                }
                
            }
            if (dueDate > DateTime.Now) // checking if the parsed date is larger than the current date
            {
                errorMsg = "Due date cannot be greater than current date"; //assigning error message
                isParsed = false; 
            }
            return isParsed;
        }

        // method for validating an integer input
        public static bool IsInt(string input, out int parsedInt, string textField, out string errorMsg)
        {
            errorMsg = null;
            bool isParsed = int.TryParse(input, out parsedInt);
            if (!isParsed)
            {
                if (string.IsNullOrEmpty(input))  // checking if the field is empty
                {
                    //assigning error message
                    errorMsg = textField + " can't be empty";
                }
                else // error found
                {
                    //assigning error message
                    errorMsg = "Invalid input for " + textField + "!";
                }

            }
            else if (parsedInt <= 0)  // checking if the field is empty
            {
                //assigning error message
                errorMsg = textField + " should be greater than zero";
                isParsed = false;
            }
            return isParsed; 
        }

        // method for validating an customer type input
        public static bool IsCustomerTypeValid(String input, out string errorMsg)
        {
            errorMsg = null;
            if (string.IsNullOrEmpty(input))  // checking if the field is empty
            {
                //assigning error message and returning false
                errorMsg = "Customer type can't be empty";
                return false;
            }
            else if(input == "N" || input == "J" || input == "L")
            {
                // returning true for correct user input
                return true;
            }
            //assigning error message and returning false
            errorMsg = "Invalid input for customer type";
            return false;
        }
    }
}
