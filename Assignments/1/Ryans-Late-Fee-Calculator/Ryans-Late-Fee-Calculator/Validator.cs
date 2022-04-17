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


        // method for checking rating
        public static bool IsRatingValid(string rating)
        {
            if(rating == "G" || rating == "PG" || rating == "PG-13" || rating == "R" || rating == "NC-17")
            {
                return true;
            }
            return false;
        }

        public static bool IsMovieNoDuplicate(int movieNo)
        {
            List<RentalItem> movieList = RentalItemDB.GetMovies();
            foreach(RentalItem movie in movieList)
            {
                if(movie.GetMovieNo() == movieNo)
                {
                    return true;
                }
            }
            return false;
        }

        //method for checking movie type
        public static bool IsMovieTypeValid(string movieType)
        {
            if (movieType == MainMenu.typeNewRelease || movieType == MainMenu.typeLibraryMovies || movieType == MainMenu.typeKidsMovies)
            {
                return true;
            }
            return false;
        }

        //method for checking movie no
        public static bool IsMovieNoValid(string movieNoText, out int movieNo, out string errorMsg)
        {
            errorMsg = null;
            movieNo = -1;
            if(IsPresent(movieNoText))
            {
                if(IsInt32(movieNoText, out movieNo))
                {
                    if (IsGreaterThanZero(movieNo))
                    {
                        if (IsMovieNoDuplicate(movieNo))
                        {
                            errorMsg = "This movie no already exists";
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        errorMsg = "Please enter a value greater than zero";
                        return false;
                    }
                }
                else
                {
                    errorMsg = "Please enter a valid movie no";
                    return false;
                }
            }
            else
            {
                errorMsg = "Please enter a movie no";
                return false;
            }
        }
    }
}
