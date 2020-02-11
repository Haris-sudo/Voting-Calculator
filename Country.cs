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
        // Utilises a nullable bool for the vote, meaning we have three potential statuses of the bool.
        private bool? _vote;
        // This is perfect for the yes, no and abstain states of the vote.


        public Country(string Name, int Population, bool EurozoneStatus, bool IsEnabled)
        {
            this.Name = Name;
            this.Population = Population;
            this.EurozoneStatus = EurozoneStatus;
            this.IsEnabled = IsEnabled;
            this.ChangeVote(null);

        }


        public void ChangeVote(bool? newVote)
        {
            _vote = newVote;
        }

        public bool? GetVote()
        {
            return _vote;
        }

    }
}
