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

        public decimal OverallPopulation { get; set; }
        public int NumOfCountries { get; set; }

        public decimal minYesPercent { get; set; }
        
        public decimal minYesPop { get; set; }


        public EUVotingCalculator()
        {
            
            OverallPopulation = 447470672;
            NumOfCountries = 27;
            using (var reader = new StreamReader("..\\Country Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Country record = new Country("Placeholder", 0, false, true, 0);

                var records = csv.EnumerateRecords(record);

                foreach (Country r in records)
                {
                    Country newCountry = new Country(r.Name, r.Population, r.EurozoneStatus, r.IsEnabled, (r.Population / OverallPopulation) * 100);
                    countryList.Add(newCountry);

                }


                InitializeComponent();
                countryBox.DisplayMember = "Name";
                countryBox.ValueMember = "Name";
                countryBox.DataSource = countryList;
                votingRule.SelectedIndex = (0);
            }

        }
        public void RefreshList()
        {


            countryBox.DataSource = null;
            countryBox.Items.Clear();
            countryBox.DisplayMember = "Name";
            countryBox.ValueMember = "Name";
            countryBox.DataSource = countryList;
        
                
        }

        

        public void EvaluateResult()
        {

            // Changing the UI based on whether the overall percentage is above or the same as the percentage needed for the vote to be passed.
            if ((Convert.ToDecimal(msPercentYes.Text) > minYesPercent) && (Convert.ToDecimal(popPercentYes.Text) > minYesPop))
            {
                finalResultVarLbl.Text = "Approved";
                votingResultImg.ImageLocation = (@"..\\icons\up-arrow.png");
            }
            else
            {
                finalResultVarLbl.Text = "Rejected";
                votingResultImg.ImageLocation = (@"..\\icons\down-arrow.png");
            }
        }

        public void RecalcVotes()
        {
            RecalcPop();
            // Redefining overall population to get correct values for the percent calculations.
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

                    // Removing the disabled countries vote from the overall percentages.
                    switch (c.GetVote())
                        {
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
            // Here goes code to change calculations and images as well as the minimum percentages required for a vote to be passed
            // based on the voting rule selected.

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
            msMinYes.Text = minYesPercent.ToString();
            popMinYes.Text = minYesPop.ToString();

        }

        private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var c = (Country)countryBox.SelectedItem;

                countryEnabledCB.Checked = c.IsEnabled;
                countryFlagImg.ImageLocation = (@"..\\flags\" + c.Name.Replace(" [Disabled]", "") + ".png");
                c.PopPercent = ((c.Population / OverallPopulation) * 100);
                totalPopVar.Text = c.Population.ToString();
                totalPopPercentVar.Text = ((Math.Round(c.PopPercent, 2).ToString()) + "%");

                noRadioBtn.Checked = false;
                yesRadioBtn.Checked = false;
                abstainRadioBtn.Checked = false;

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
            
            // This particular example is essentially the same as the above in principle - this time enabling all previously disabled countries.
            foreach (Country c in countryList)
            {
                if (c.IsEnabled == false) 
                {
                    NumOfCountries += 1;
                    c.IsEnabled = true;
                }

                
            }

            totalEnabledStates.Text = NumOfCountries.ToString();
            RecalcVotes();
            RefreshList();

        }

        public void RecalcPop()
        {

            // Caclulating the overall population of the enabled countries.
            OverallPopulation = 0;
            foreach(Country c in countryList)
            {
                if(c.IsEnabled)
                {
                    OverallPopulation +=  c.Population;
                }
            }
        }

        public void RecalcPercents()
        {

            // Calculating the overall population percentages once a vote has been cast.
            foreach (Country c in countryList)
            {
                c.PopPercent = decimal.Divide(c.Population, OverallPopulation) * 100;
            }
        }

        private void comboBoxFormat(object sender, ListControlConvertEventArgs e)
        {

            // Adding a disabled indicator to show which countries have been disabled.
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

            // The changes that result from enabling and disabling countries.
            var c = (Country)countryBox.SelectedItem; 
            c.IsEnabled = countryEnabledCB.Checked;
            if (c.IsEnabled == false)
            {
                OverallPopulation -= c.Population;
                NumOfCountries -= 1;
                totalEnabledStates.Text = NumOfCountries.ToString();
                totalPopPercentLbl.ForeColor = SystemColors.AppWorkspace;
                totalPopPercentVar.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                OverallPopulation += c.Population;
                NumOfCountries += 1;
                totalEnabledStates.Text = NumOfCountries.ToString();
                totalPopPercentLbl.ForeColor = SystemColors.ControlText;
                totalPopPercentVar.ForeColor = SystemColors.ControlText;
            }

            // Performing calculations based on the enabled and disabled countries.
            RecalcVotes();
            RefreshList();
        }

        private void abstainRadioBtn_Click(object sender, EventArgs e)
        {

            // The effect abstaining has on the overall percentages.
            if (abstainRadioBtn.Checked)
            {
                var c = (Country)countryBox.SelectedItem;
                c.ChangeVote(null);
                RecalcVotes();
            }
        }

        private void noRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

            // The effect voting no has on the overall percentages.
            if (noRadioBtn.Checked)
            {
                var c = (Country)countryBox.SelectedItem;
                c.ChangeVote(false);
                RecalcVotes();
            }
        }


        // The effect voting yes has on the overall percentages.
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
