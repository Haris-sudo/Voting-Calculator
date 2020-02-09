using System;

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
