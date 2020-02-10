using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace Voting_Calculator_Assignment
{
    class Program
    {
        static void Setup()
        {
            
            List<Country> countryList = new List<Country>();

            using (var reader = new StreamReader("..\\Voting-Calculator-Assignment\\Data\\Country Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Country record = new Country("Placeholder", 0, false);

                var records = csv.EnumerateRecords(record);

                foreach (Country r in records)
                {
                    Country newCountry = new Country(r.name, r.population, r.eurozoneStatus);
                    countryList.Add(newCountry);
                }
            }
        }

        static bool YesNo(string text)
        {
            ConsoleKey choice;
            do {
            Console.Write(text);
            choice = Console.ReadKey(false).Key;
            if(choice != ConsoleKey.Enter)
            {
                Console.WriteLine();
            }

            } while(choice != ConsoleKey.Y && choice != ConsoleKey.N);

            if(choice == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.WriteLine("This is fine.");
            

            //Setup();
            

            
            bool votingComplete = false;

            do { 
                bool isEurozone = YesNo("Are all countries participating, or soley the eurozone members?(Y/N)");
                

                Console.WriteLine("{0} {1}", isEurozone.ToString(), funnyLolTest.ToString());

                //votingComplete = true;



            } while(!votingComplete);
            Console.WriteLine("All done :)");

            
        }
    }
}
