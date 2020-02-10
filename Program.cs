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

        static bool YesNo(string text) // Use this whenever you need a straight y/n answer from the user.
        {
            // Takes a single console key variable
            ConsoleKey choice;
            do {
                // Output the text specified when the function is called, then ask for a console input.
                Console.Write(text);
                
                // Console.Readkey essentially takes the unicode value, and is useful for validating without the hassle
                // string validation can quickly become. the false argument is simply whether or not to intercept the input
                // - stopping it from being displayed entirely.
                choice = Console.ReadKey(false).Key;
                
                // This simply adds a line every time a false input is entered.
                if(choice != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }

            } while(choice != ConsoleKey.Y && choice != ConsoleKey.N);
            // Could easily make alternate versions of this that work of of inputs other than y/n if needed.

            // Probably a simpler way to handle this last part, if any have any ideas feel free.
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
            
            // Commented this until we can fix the .csv file issue.
            //Setup();
            


            bool votingComplete = false;

            do { 
                bool isEurozone = YesNo("Are all countries participating, or soley the eurozone members?(Y/N)");
                
                // Ok, so 


                Console.WriteLine("{0} {1}", isEurozone.ToString(), funnyLolTest.ToString());

                //votingComplete = true;



            } while(!votingComplete);
            Console.WriteLine("All done :)");

            
        }
    }
}
