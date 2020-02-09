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

            using (var reader = new StreamReader("..\\Country Data.csv"))
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

        static void Main()
        {
            Setup();
        }
    }
}
