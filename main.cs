using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
public class Country
{
    // Conventions are as follows:
    // camelCase for regular variables, uppercase initial letter only on methods and functions
    // Add an _ for private variables
    public string name { get; set; } 
    public int population { get; set; }
    public bool eurozoneStatus { get; set; }
    
    // Utilises a nullable bool for the vote, meaning we have three potential statuses of the bool.
    private bool? _vote;
    // This is perfect for the yes, no and abstain states of the vote.
    
    public Country(string name, int population, bool eurozoneStatus)
    {

    }
    

    public void ChangeVote(bool newVote)
    {
        _vote = newVote;
    }

    public bool? GetVote()
    {
        return _vote;
    }
            
}


public class Setup
{
    static void Main()
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
        /* 

        for(int i = 0; i<countryList.Count; i++)
        {
            countryList[i] = new Country();
        }
        */
    }

}



    /* BASIC CODE STRUCTURE:
    Read from JSON file
        Instantiate class with variables from JSON.
        Add the new object to the the list.      
    */

    
