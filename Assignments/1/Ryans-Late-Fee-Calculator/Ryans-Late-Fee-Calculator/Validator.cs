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
        // method for validating null input
        public static bool IsPresent(string input)
        {
            if (string.IsNullOrEmpty(input))  // checking if the field is empty
            {
                return false;
            }
            return true;
        }

        // method for validating an integer input
        public static bool IsInt32(string input, out int parsedInt)
        {
            bool isParsed = int.TryParse(input, out parsedInt);
            if(isParsed && parsedInt <= Int32.MaxValue && parsedInt >= Int32.MinValue)
            {
                return isParsed;
            }
            return false;
        }

        // method for checking greater than zero value
        public static bool IsGreaterThanZero(int input)
        {
            if (input > 0)  // checking if the field is empty
            {
                return true;
            }
            return false;
        }

        // method for checking number of movies input
        public static bool IsNumberOfMoviesValid(string input, out int parsedInt, string textField, out string errorMsg)
        {
            errorMsg = null;
            parsedInt = -1;
            if (IsPresent(input))
            {
                if(IsInt32(input, out parsedInt))
                {
                    if (IsGreaterThanZero(parsedInt))
                    {
                        return true;
                    }
                    else
                    {
                        //assigning error message
                        errorMsg = textField + " should be greater than zero";
                        return false;
                    }
                }
                else
                {
                    //assigning error message
                    errorMsg = "Invalid input for " + textField + "!";
                    return false;
                }
            }
            else
            {
                //assigning error message
                errorMsg = textField + " can't be empty";
                return false;
            }        
        }

        // method for checking customer type
        public static bool IsCustomerTypeValid(string customerType)
        {
            foreach (string type in Enum.GetNames(typeof(MainMenu.customerType)))
            {
                if(type == customerType)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
