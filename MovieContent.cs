using System;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace A4___Movie_Library_Assignment
{

    public class MovieContent
    {

            public void DisplayMoviesContent()

            {

                string file = "movies.csv";

                                using (var reader = new StreamReader(file))
                                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                                {
                                    var records = csv.GetRecords<MenuLib>().ToList();
                                    
                                    foreach(var i in records)
                                    {
                                    Console.WriteLine(i); // Prints items      
                                    }
                                }

            }
        

            
    }

    public class MenuLib
        {

            public string movieId {get; set;}
            
            public string title {get; set;}
            
            public string genres {get; set;}

            public override string ToString()
                {
                    return "MovieID: " + movieId + " Title:  " + title + " Genre(s): " + genres;
                }

        }
}