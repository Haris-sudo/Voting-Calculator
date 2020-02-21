using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VotingCalculator
{
    public class Country
    {
        // Conventions are as follows:
        // camelCase for regular variables, uppercase initial letter only on methods and functions
        // Add an _ for private variables
        public string Name { get; set; }
        public int Population { get; set; }
        public bool EurozoneStatus { get; set; }
        public bool IsEnabled { get; set; }

        public decimal PopPercent { get; set; }
        // Utilises a nullable bool for the vote, meaning we have three potential statuses of the bool.
        private bool? _vote;
        // This is perfect for the yes, no and abstain states of the vote.
        // This variable is never directly modified in anyway - unless you go through the two methods given below - 
        // - used for changing and viewing the countries vote, you cannot access the _vote variable. This is a useful method of encapsulation, as it ensures
        // that the _vote variable is only modified internally, preventing errors related to a countries vote from ocvcuring outside the class.


        public Country(string Name, int Population, bool EurozoneStatus, bool IsEnabled, decimal PopPercent)
        {
            this.Name = Name;
            this.Population = Population;
            this.EurozoneStatus = EurozoneStatus;
            this.IsEnabled = IsEnabled;
            this.ChangeVote(true);
            this.PopPercent = PopPercent;

        }


        public void ChangeVote(bool? newVote)
        {
            // Takes a bool? and applies it to the private variable _vote
            // As you can see, the code for this change is done within the class, not outside of it.
            _vote = newVote;
        }

        public bool? GetVote()
        {
            // This allows external programs to grab the _vote variable if needed, but it does not let them modify/redefine the instance itself.
            return _vote;
        }

    }
}
