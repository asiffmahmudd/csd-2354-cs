using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Asif Mahmud
 * ID: C0837117
*/

namespace TaxCalculator
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
                throw new Exception("Please enter a valid value");
            }
            return isValid;
        }

        // validator for checking positive value
        public static bool IsPositive(decimal input)
        {
            if(input >= 0)
            {
                return true;
            }
            return false;
        }

        // validator for income 
        public static bool IsIncomeValid(string input, out decimal income)
        {
            income = 0;
            if(IsPresent(input) && IsDecimal(input, out income))
            {
                if (IsPositive(income))
                {
                    return true;
                }
                else
                {
                    throw new Exception("Income can't be negative");
                    return false;
                }
            }
            return false;
        }
    }
}
