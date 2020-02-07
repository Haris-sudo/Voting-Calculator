using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Country
{
    // Conventions are as follows:
    // camelCase for regular variables, uppercase initial letter only on methods and functions
    // Add an _ for private variables

    public string name;
    public float popPercent;
    private bool eurozoneStatus;
    
    // Utilises a nullable bool for the vote, meaning we have three potential statuses of the bool.
    private bool? _vote;
    // This is perfect for the yes, no and abstain states of the vote.

    public void ChangeVote(bool newVote)
    {
        _vote = newVote;
    }

    public bool GetVote()
    {
        return _vote;
    }
            
}


public class Main
{
    public void Setup()
    {
        List<Country> countryList = new List<Country>();

        for(int i = 0; i<countryList.Count; i++)
        {
            countryList[i] = new Country();
        }

     }

    Console.Writeline("Sweaty balls");
}



    /* BASIC CODE STRUCTURE:
    Read from JSON file
        Instantiate class with variables from JSON.
        Add the new object to the the list.      
    */

    
