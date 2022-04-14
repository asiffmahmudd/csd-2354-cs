using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryans_Late_Fee_Calculator
{
    public class RentalItemDB
    {
        private static List<RentalItem> movies;
        public static SortedList<string, List<RentalItem>> CalculatedMovieList;

        public RentalItemDB()
        {
            movies = new List<RentalItem>();
            CalculatedMovieList = new SortedList<string, List<RentalItem>>();
        }
        public static List<RentalItem> GetMovies()
        {
            return movies;
        }

        public static void SaveMovies(List<RentalItem> movieList)
        {
            movies = movieList;
        }

        public static void SaveMovieTypeList(string formType, List<RentalItem> movieList)
        {
            if (CalculatedMovieList.ContainsKey(formType))
            {
                CalculatedMovieList[formType] = movieList;
            }
            else
            {
                CalculatedMovieList.Add(formType, movieList);
            }
        }
    }
}
