using System;
using System.IO;

namespace A4___Movie_Library_Assignment
{

public class Menu
    {

public void Display()

        {

        string choice;
        //string repeat;
        string file = "movies.csv";
        

            do
            {
                    //ask user a question
                    Console.WriteLine("1) List movies.");
                    Console.WriteLine("2) Enter new movie.");
                    Console.WriteLine("Enter any other key to exit.");
                    // input response
                    choice = Console.ReadLine();

                    //choice = "1"; //--test

                    if (choice == "1")
                    {
                        if (!File.Exists(file))
                        {
                            Console.WriteLine("File does not exist");
                        }
                        else
                        {

                            // read data from file
                            MovieContent displayData = new MovieContent();
                            displayData.DisplayMoviesContent();

                        }
                    }
                    else if (choice == "2")
                    {
                        System.Console.WriteLine("You entered Choice 2");
                        NewMovie newmovie = new NewMovie();
                        newmovie.CreateNewMovieTitle();
                    } 
            } while (choice == "1" || choice == "2");

        }

    }

}