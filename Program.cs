using System;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace A4___Movie_Library_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Display();
        }
    }
}
