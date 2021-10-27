using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        public Blockbuster()
        {
            List<string> scenes = new List<string>() { "First Scene", "Second Scene", "Third Scene", "Fourth Scene" };
            Movies.Add(new VHS("Fight Club", "Action", 139, scenes));
            Movies.Add(new VHS("Jacob's Ladder", "Horror", 113, scenes));
            Movies.Add(new VHS("Rush Hour", "Comedy", 98, scenes));
            Movies.Add(new DVD("Fury", "Drama", 135, scenes));
            Movies.Add(new DVD("The Great Gatsby", "Romance", 142, scenes));
            Movies.Add(new DVD("Saving Private Ryan", "Action", 169, scenes));
        }
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Movies[i].Title}");
            }
        }
        public void Selection()
        {
            Movie m = CheckOut();
            NewMovie(m);
            Console.WriteLine();
        }
        public Movie CheckOut()
        {
            Console.WriteLine("Welcome to GC Blockbuster!");
            PrintMovies();
            string response;
            int index;
            Movie m;
            

            while (true)
            {
                try
                {
                    response = UserInput("Please select a Movie from the list:");
                    index = int.Parse(response);
                    m = Movies[index - 1];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be an integer");
                    continue;
                }                
            }
            return m;
        }
        public void NewMovie(Movie m)
        {
            Console.WriteLine(m);
            bool movie = DifferentScene("Do you want to watch the movie? y/n");
            while (movie)
            {
                m.Play();
                movie = DifferentScene("Do you want to pick a different scene? y/n");
            }
        }

        public string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public bool DifferentScene(string prompt)
        {
            while (true)
            {
                string reply = UserInput(prompt);
                if (reply == "y")
                {
                    return true;
                }
                else if (reply == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Reply must be y or n");
                    continue;
                }
            }

        }
    }
}
