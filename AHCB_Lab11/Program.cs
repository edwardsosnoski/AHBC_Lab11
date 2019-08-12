using System;
using System.Collections.Generic;

namespace AHCB_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie();
            movie1.NewMovie("Howl's Moving Castle", "Animated");

            var movie2 = new Movie();
            movie2.NewMovie("Wolf Children", "Animated");

            var movie3 = new Movie();
            movie3.NewMovie("Atonment", "Drama");

            var movie4 = new Movie();
            movie4.NewMovie("The Notebook", "Drama");

            var movie5 = new Movie();
            movie5.NewMovie("Inception", "Sci-Fi");

            var movie6 = new Movie();
            movie6.NewMovie("The Hills Have Eyes", "Horror");

            var movie7 = new Movie();
            movie7.NewMovie("Cabin Fever", "Horror");

            var movie8 = new Movie();
            movie8.NewMovie("Star Wars Episode II", "Sci-Fi");

            var movie9 = new Movie();
            movie9.NewMovie("Summer Wars", "Animated");

            var movie10 = new Movie();
            movie10.NewMovie("Titanic", "Drama");

            var categories = new List<string>()
            {
                "Animated",
                "Drama",
                "Sci-Fi",
                "Horror"
            };

            var listOfMovies = new List<Movie>()
            {
                movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10
            };

            string userInput = movie1.GetCategory(
                "What category are you interested in? Select Drama, Sci-Fi, Animated, or Horror:",
                "That is not a valid entry.",
                categories);

            movie1.GetMoviesOfCategory(userInput, listOfMovies);
        }
    }
}