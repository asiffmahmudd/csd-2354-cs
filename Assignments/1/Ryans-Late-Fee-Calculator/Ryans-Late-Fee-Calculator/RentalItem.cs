using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryans_Late_Fee_Calculator
{
    public class RentalItem
    {
        private int MovieNo;
        private string Description;
        private string MovieType;
        private string Rating;

        public RentalItem()
        {

        }

        //constructor with paramteres
        public RentalItem(int movieNo, string description, string movieType, string rating)
        {
            MovieNo = movieNo;
            Description = description;
            Rating = rating;
            MovieType = movieType;
        }

        //formatting the text
        public string GetDisplayText()
        {
            return MovieNo + "    " + Description + " " + Rating; 
        }

        //getters for the class variables
        public int GetMovieNo()
        {
            return MovieNo;
        }

        public string GetDescription()
        {
            return Description;
        }

        public string GetRating()
        {
            return Rating;
        }

        public string GetMovieType()
        {
            return MovieType;
        }

        //setters for the class variables

        public void SetMovieNo(int movieNo)
        {
            MovieNo = movieNo;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetRating(string rating)
        {
            Rating = rating;
        }

        public void SetMovieType(string movieType)
        {
            MovieType = movieType;
        }
    }
}
