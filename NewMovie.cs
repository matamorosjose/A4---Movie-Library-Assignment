using System;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;

namespace A4___Movie_Library_Assignment
{

    public class NewMovie
    {

        public void CreateNewMovieTitle()

            {
            // create file from data
            string file = "movies.csv";

            // prompt for questions
            Console.WriteLine("Enter movie title");
            string titleString = Console.ReadLine();

            Console.WriteLine("Enter movie genre(s)");
            string genreString = Console.ReadLine();

                                using (var reader = new StreamReader(file))
                                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                                {
                                    var count = csv.GetRecords<CsvRecords>().ToList();
                                    System.Console.WriteLine($"The total number of items are: {count.Count()}");
                                }


                                var records = new List<CsvRecords>
                                    {
                                        new CsvRecords { movieId = "1000" , title = titleString, genres = genreString },
                                    };


                                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                                {
                                    // Don't write the header again.
                                    HasHeaderRecord = false,
                                };


                                using (var stream = File.Open(file, FileMode.Append))
                                using (var writer = new StreamWriter(stream))
                                using (var csv = new CsvWriter(writer, config))
                                {
                                    csv.WriteRecords(records);
                                }

            }
                        
    }

        public class CsvRecords
    {
        [Index(0)]
        public string movieId { get; set; }

        [Index(1)]
        public string title { get; set; }

        [Index(2)]
        public string genres { get; set; }
    }

}