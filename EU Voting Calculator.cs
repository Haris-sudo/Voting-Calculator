using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace WinForms_VotingCalculator
{
    public partial class EUVotingCalculator : Form
    {

       
        public List<Country> countryList = new List<Country>();
        public List<Country> yesCountries = new List<Country>();
        public List<Country> noCountries = new List<Country>();
        public List<Country> abstainCountries = new List<Country>();

        // Overall population of the EU board. Calculated dynamically.
        public decimal OverallPopulation { get; set; }

        // Total number of participating states.
        public int NumOfCountries { get; set; }

        // Minimum yes percentage to proceed with the vote. i.e: 55 for qualified majority
        public decimal minYesPercent { get; set; }
        
        // Minimum population percent to proceed with vote. i.e: 65 for qualified majority
        public decimal minYesPop { get; set; }


        public EUVotingCalculator()
        {
            // Initialises variables as constant values for less memory usage.
            OverallPopulation = 447470672;
            NumOfCountries = 27;

            // Utilises a CSV reader and iterates over a CSV file containing all country data
            using (var reader = new StreamReader("..\\Country Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Creates a placeholder country to act as a template for the EnumerateRecords method
                Country record = new Country("Placeholder", 0, false, true, 0);

                // Enumerable for iteration
                var records = csv.EnumerateRecords(record);

                foreach (Country r in records)
                {
                    // Each country is added to the country list with the data in the CSV file.
                    Country newCountry = new Country(r.Name, r.Population, r.EurozoneStatus, r.IsEnabled, (r.Population / OverallPopulation) * 100);
                    countryList.Add(newCountry);

                }

                // Form is initialised
                InitializeComponent();

                // Set the countrybox to display the array content based on the name of the country.
                countryBox.DisplayMember = "Name";
                countryBox.ValueMember = "Name";
                countryBox.DataSource = countryList;
                votingRule.SelectedIndex = (0);
            }

        }
        public void RefreshList()
        {
            /* Updates list for formatting purposes (e.g: [Disabled] and so on) - 
               requires datasource reset */
            countryBox.DataSource = null;
            countryBox.Items.Clear();
            countryBox.DisplayMember = "Name";
            countryBox.ValueMember = "Name";
            countryBox.DataSource = countryList;
        
                
        }

        public decimal PopCalc()
        {
            // Dynamic calculation of the overall population depending on enabled countries. 
            OverallPopulation = 0;
            foreach (Country c in countryList)
            {
                if (c.IsEnabled)
                {
                    OverallPopulation += c.Population;
                }
            }
            return OverallPopulation;
        }

        

        public void EvaluateResult()
        {
            /* Changing the UI based on whether the overall percentage is above or the same
            as the percentage needed for the vote to be passed. */
            if ((Convert.ToDecimal(msPercentYes.Text) >= minYesPercent) && (Convert.ToDecimal(popPercentYes.Text) >= minYesPop))
            {
                finalResultVarLbl.Text = "Approved";
                votingResultImg.ImageLocation = (@"..\\icons\up-arrow.png");
            }
            else
            {
                finalResultVarLbl.Text = "Rejected";
                votingResultImg.ImageLocation = (@"..\\icons\down-arrow.png");
            }

            // No draw condition, but this is highly unlikely and outside of the scope of the program
        }

        public void RecalcVotes()
        {
            // Redefining overall population to get correct values for the percent calculations 
            PopCalc();
            RecalcPercents();

            decimal msYesVal = 0;
            decimal msNoVal = 0;
            decimal msAbstainVal = 0;

            decimal popYesVal = 0;
            decimal popNoVal = 0;
            decimal popAbstainVal = 0;


            foreach (Country c in countryList)
            { 
                if (c.IsEnabled)
                {
                    // Avoids all countries that aren't enabled
                    switch (c.GetVote())
                        {
                        // Adds each country's popPercent to the respective value.
                            case true:
                                popYesVal += c.PopPercent;
                                msYesVal += Decimal.Divide(1, NumOfCountries) * 100;
                                break;

                            case false:
                                popNoVal += c.PopPercent;
                                msNoVal += Decimal.Divide(1,NumOfCountries) * 100;
                                break;

                            case null:
                                popAbstainVal += c.PopPercent;
                                msAbstainVal  += Decimal.Divide(1, NumOfCountries) * 100;
                                break;
                        }
                }
                
            }


            // Painfully sub-optimal - someone find out another way to approach this?
            // Six local vars can't be the only solution.

            msPercentYes.Text = decimal.Round(msYesVal,2).ToString();
            popPercentYes.Text = decimal.Round(popYesVal,2).ToString();

            msPercentNo.Text = decimal.Round(msNoVal, 2).ToString();
            popPercentNo.Text = decimal.Round(popNoVal, 2).ToString();

            msPercentAbstain.Text = decimal.Round(msAbstainVal, 2).ToString();
            popPercentAbstain.Text = decimal.Round(popAbstainVal, 2).ToString();

            EvaluateResult();

        }

        private void votingRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Depending on the voting rule selected, the minimum percents
               are set to different values
            */

            switch (votingRule.Text)
            {
                
                case "Qualified majority":
                    minYesPercent = 55;
                    minYesPop = 65;
                    break;

                case "Reinforced qualified majority":
                    minYesPercent = 72;
                    minYesPop = 65;
                    break;

                case "Simple majority":
                    minYesPercent = 50;
                    minYesPop = 0;
                    break;

                case "Unanimity":
                    minYesPercent = 100;
                    minYesPop = 0;
                    break;

            }

            // Altering     the UI labels to represent the minimum result needed.
            msMinYes.Text = minYesPercent.ToString();
            popMinYes.Text = minYesPop.ToString();

            // Re-evaluates the end result based on new voting rules.
            EvaluateResult();

        }

        private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Every time you select a new country from the dropdown menu...
            try
            {
                // Converts it to a Country object so we can operate on it.
                var c = (Country)countryBox.SelectedItem;

                // Sets the enabled checkbox to whatever the country's enabled bool is set to.
                countryEnabledCB.Checked = c.IsEnabled;
                // Finds the file for the flag by using the current name.
                countryFlagImg.ImageLocation = (@"..\\flags\" + c.Name.Replace(" [Disabled]", "") + ".png");
                // Recalculates the population percentage.
                c.PopPercent = ((c.Population / OverallPopulation) * 100);
                totalPopVar.Text = c.Population.ToString();
                // Rounds the percentage to 2 decimal places and updates the UI accordingly.
                totalPopPercentVar.Text = ((Math.Round(c.PopPercent, 2).ToString()) + "%");

                // Sets all radio buttons to be deselected for clean UI and next steps.
                noRadioBtn.Checked = false;
                yesRadioBtn.Checked = false;
                abstainRadioBtn.Checked = false;


                // Depending on the current vote, the correct radio button is selected.
                switch (c.GetVote())
                {
                    case true:
                        yesRadioBtn.Checked = true;
                        break;

                    case false:
                        noRadioBtn.Checked = true;
                        break;

                    case null:
                        abstainRadioBtn.Checked = true;
                        break;
                }
            }
            catch (System.NullReferenceException)
            {
                // Passes on any null reference exceptions that may be thrown.
            }


        }


        private void eurozoneOnlyBtn_Click(object sender, EventArgs e)
        {

            // An example of abstraction; The loop performed here goes over every country individually and modifies its properties
            // based on a certain conition. For the user, this is instantaneous and hidden - once the button is clicked the effect is applied out of view.

            // In this particular example, the button disables several countries, but the user does not see this, they shall simply find these countries disabled should
            // they select them from the dropdown menu.
            foreach(Country c in countryList)
            {
                if (c.IsEnabled & !c.EurozoneStatus)
                {
                    c.IsEnabled = false;
                    NumOfCountries -= 1;
                }


            }
            totalEnabledStates.Text = NumOfCountries.ToString();
            RefreshList();
            RecalcVotes();
        }

        private void resetEnabledBtn_Click(object sender, EventArgs e)
        {
            // This particular example is essentially the same as the above in principle - this time enabling all previously disabled countries
            foreach (Country c in countryList)
            {
                if (c.IsEnabled == false) {
                    NumOfCountries += 1;
                    c.IsEnabled = true;
                }

                
            }

            totalEnabledStates.Text = NumOfCountries.ToString();
            RecalcVotes();
            RefreshList();

        }

        public void RecalcPercents()
        {
            // Recalculates the percentages for every country.
            foreach (Country c in countryList)
            {
                c.PopPercent = decimal.Divide(c.Population, OverallPopulation) * 100;
            }
        }
        private void comboBoxFormat(object sender, ListControlConvertEventArgs e)
        {

            // Formats the names of the countries to reflect their enabled status for better HCI
            bool c = ((Country)e.ListItem).IsEnabled == false;
            string countryName = ((Country)e.ListItem).Name;
            if (c)
            {
                e.Value = (countryName + " [Disabled]");

            }
            else
            {
                e.Value = (countryName.Replace(" [Disabled]", ""));
            }
        }

        private void countryEnabledCB_Click(object sender, EventArgs e)
        {
            // If a country is enabled or disabled...

            var c = (Country)countryBox.SelectedItem; 
            c.IsEnabled = countryEnabledCB.Checked;
            if (c.IsEnabled == false)
            {
                // Reduces appropriate public variables.
                OverallPopulation -= c.Population;
                NumOfCountries -= 1;
                totalEnabledStates.Text = NumOfCountries.ToString();

                // Greys the text relating to the country out for better HCI.
                totalPopPercentLbl.ForeColor = SystemColors.AppWorkspace;
                totalPopPercentVar.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                // Increases appropriate public variables.
                OverallPopulation += c.Population;
                NumOfCountries += 1;
                totalEnabledStates.Text = NumOfCountries.ToString();

                // Undoes the previous colour changes to reflect its enabled nature.
                totalPopPercentLbl.ForeColor = SystemColors.ControlText;
                totalPopPercentVar.ForeColor = SystemColors.ControlText;
            }

            RecalcVotes();
            RefreshList();
        }


        // Next three methods change the votes for the country objects.

        //radio button to give the user the option to use the abstain feature
        private void abstainRadioBtn_Click(object sender, EventArgs e)
        {
            if (abstainRadioBtn.Checked)
            {
                var c = (Country)countryBox.SelectedItem;
                c.ChangeVote(null);
                EvaluateResult();
                RecalcVotes();
            }
        }

        // "no" radio button presented as an option to the user so they can vote the country out 
        private void noRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (noRadioBtn.Checked)
            {
                var c = (Country)countryBox.SelectedItem;
                c.ChangeVote(false);
                RecalcVotes();
            }
        }

        // "yes" radio button presented as an option to the user so they can vote the country in
        private void yesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioBtn.Checked)
            {
                var c = (Country)countryBox.SelectedItem;
                c.ChangeVote(true);
                RecalcVotes();
            }
        }
    }
}
