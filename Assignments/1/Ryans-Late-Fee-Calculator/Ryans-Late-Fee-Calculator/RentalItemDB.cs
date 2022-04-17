using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryans_Late_Fee_Calculator
{
    public class RentalItemDB
    {
        private static List<RentalItem> movies; // variable for all movies
        private static SortedList<string, List<RentalItem>> CalculatedMovieList; // variable for selected movies for differnet form types

        public RentalItemDB()
        {
            movies = new List<RentalItem>();
            CalculatedMovieList = new SortedList<string, List<RentalItem>>();
        }

        //method for getting the  movie list
        public static List<RentalItem> GetMovies()
        {
            return movies;
        }

        //method for saving all movies
        public static void SaveMovies(List<RentalItem> movieList)
        {
            movies = movieList;
        }

        //method for saving the movies selected for different form types
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

        //method for getting the selected movie list
        public static List<RentalItem> GetCalculatedMovieList(string formType)
        {
            return CalculatedMovieList[formType];
        }

        public static List<RentalItem> GetMovieList(string formType)
        {
            List<RentalItem> movieList = new List<RentalItem>();
            for(int i = 0; i < movies.Count; i++)
            {
                if(movies[i].GetMovieType() == formType)
                {
                    movieList.Add(movies[i]);
                }
            }
            return movieList;
        }

        public static void ClearSelectedMovies()
        {
            CalculatedMovieList.Clear();
        }

    }
}
