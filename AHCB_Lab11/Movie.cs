using System;
using System.Collections.Generic;

namespace AHCB_Lab11
{
    public class Movie
    {
        private string Title;
        private string Category;

        public void NewMovie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string GetCategory(string messageToUser, string errorMessage, List<string> categories)
        {
            var validInput = false;
            string category = "";

            do
            {
                Console.WriteLine(messageToUser);
                var userInput = Console.ReadLine();

                if (!categories.Contains(userInput))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    category = userInput;
                }
            } while (validInput);
            
            return category;
        }

        public void GetMoviesOfCategory(string category,List<Movie> moviesList)
        {
            bool continuePrompt = true;
            do
            {
                foreach (Movie movie in moviesList)
                {
                    if (category.Equals(movie.Category))
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                Console.WriteLine("Continue? y/n");
                string userInput = Console.ReadLine();

                if (userInput.Equals("n"))
                {
                    continuePrompt = false;
                }
            } while (continuePrompt); 
        }
    }
}
