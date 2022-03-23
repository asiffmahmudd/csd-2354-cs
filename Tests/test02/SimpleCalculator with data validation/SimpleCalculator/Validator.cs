using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Asif Mahmud
 * ID: C0837117
*/


namespace SimpleCalculator
{
    internal class Validator
    {
        // method for checking null values
        public static bool IsPresent(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("Please enter a value");
                return false;
            }
            return true;
        }

        // method for checking decimal values
        public static bool IsDecimal(string input, out decimal value)
        {
            bool isValid = Decimal.TryParse(input, out value);
            if (!isValid)
            {
                // throwing exception for invalid value
                throw new Exception(input+ " is not a valid value for operand");
            }
            return isValid;
        }

        // method for checking if the value is within range
        public static bool IsWithinRange(decimal input)
        {
            if(input >= 0 && input < 1000000)
            {
                return true;
            }
            else
            {
                // throwing exception for invalid value
                throw new Exception(input + " is not a value between 0 and 1,000,000 (non-inclusive)");
                return false;
            }
        }

        // method for checking the operator
        public static bool IsOperator(string input)
        {
            if(input == "+" || input == "-" || input == "*" || input == "/")
            {
                return true;
            }
            else
            {
                // throwing exception for invalid value
                throw new Exception(input + " is not a valid operator!");
                return false;
            }
        }

        // method for checking valid data
        public static bool IsValidData(string operand1Text, string operand2Text, out decimal operand1, 
            out decimal operand2, string operatorValue)
        {
            operand1 = 0;
            operand2 = 0;
            if (IsPresent(operand1Text) && IsDecimal(operand1Text, out operand1) && IsWithinRange(operand1)
                && IsPresent(operand2Text) && IsDecimal(operand2Text, out operand2) && IsWithinRange(operand2)
                && IsOperator(operatorValue))
            {
                return true;
            }
            return false;
        }
    }
}
