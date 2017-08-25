using MovieMenuBLL;
using MovieMenuEntity;
using System;
using System.Collections.Generic;

namespace MovieMenuUI
{
    public class Program
    {
        static BLLFacade BllFacade = new BLLFacade();
        static void Main(string[] args)
        {


            var movie1 = new Movie
            {
                Title = "Shark night",
                Auther = "John John",
                Genre = "Horror",
                Length = "1.5 Hours"
            };
            BllFacade.MovieService.Create(movie1);

            BllFacade.MovieService.Create(new Movie()
            {
                Title = "A World Outside",
                Auther = "Frank Darabont",
                Genre = "Drama",
                Length = "142 Min"
            });


            string[] menuItems =
                {
                "List All Movies",
                "Add Movie",
                "Delete Movie",
                "Edit Movie",
                "Search",
                "Exit"
            };

            var selection = showMenu(menuItems);

            while (selection != 6)
            {
                switch (selection)
                {
                    case 1:
                        listMovies();
                        break;

                    case 2:
                        AddMovies();
                        break;

                    case 3:
                        DeleteMovie();
                        break;

                    case 4:
                        EditMovie();
                        break;

                    case 5:
                        SearchMovie();
                        break;

                    default:
                        break;
                }
                selection = showMenu(menuItems);
            }
            Console.WriteLine("Bye Bye");

            Console.ReadLine();
        }

        private static Movie FindingMovieById()
        {

            listMovies();
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please Insert A Number");
            }
            return BllFacade.MovieService.get(id);
        }

        private static void EditMovie()
        {
            Console.WriteLine("Please Select The Id Of The Movie You Want To Edit: ");
            var movie = FindingMovieById();

            if (movie != null)
            {
                Console.WriteLine();
                Console.WriteLine("Title: ");
                movie.Title = Console.ReadLine();

                Console.WriteLine("Author: ");
                movie.Auther = Console.ReadLine();

                Console.WriteLine("Genre: ");
                movie.Genre = Console.ReadLine();

                Console.WriteLine("Length: ");
                movie.Length = Console.ReadLine();

                BllFacade.MovieService.Update(movie);
            }
            else
            {
                Console.WriteLine("Please Use A Valid Id \n");
            }
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("Insert The Id Of The Movie You Want To Delete: ");
            var movieFound = FindingMovieById();

            if(movieFound != null)
            {
                BllFacade.MovieService.Delete(movieFound.Id);
            }
            
            var response = movieFound == null ? "Please Use A Valid Id \n" : "The Movie Was Deleted \n";
            Console.WriteLine(response);


        }

        private static void AddMovies()
        {
            Console.WriteLine("Title: ");
            var Title = Console.ReadLine();

            Console.WriteLine("Auther: ");
            var Auther = Console.ReadLine();

            Console.WriteLine("Genre: ");
            var Genre = Console.ReadLine();

            Console.WriteLine("Length: ");
            var Length = Console.ReadLine();

            BllFacade.MovieService.Create(new Movie()
            {
                Title = Title,
                Auther = Auther,
                Genre = Genre,
                Length = Length
            });
        }

        private static void listMovies()
        {
            Console.WriteLine("\nList Of Movies \n");
            foreach (var Movie in BllFacade.MovieService.getAll())
            {
                Console.WriteLine($"Id: {Movie.Id} Name: {Movie.Title} Auther: {Movie.Auther} Genre: {Movie.Genre} Length: {Movie.Length}");
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        private static int showMenu(string[] menuItems)
        {
            Console.WriteLine("Select what you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 6)
            {
                Console.WriteLine("You need to choose a number between 1-6");
            }


            return selection;
        }
        private static void SearchMovie()
        {
            Console.WriteLine("Enter video name: \n");
            var searchQuery = Console.ReadLine();
            Console.WriteLine("");

            BllFacade.MovieService.Search(searchQuery);
        }

    }
}
