using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;


namespace WinForms_VotingCalculator
{
    public partial class EUVotingCalculator : Form
    {
        public List<Country> countryList = new List<Country>();

        public List<Country> yesCountries = new List<Country>();
        public List<Country> noCountries = new List<Country>();
        public List<Country> abstainCountries = new List<Country>();

        public decimal OverallPopulation { get; set; }


        public EUVotingCalculator()
        {
            
            OverallPopulation = 447470672;
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

            msPercentYes.Text = ("0");
            foreach (Country c in countryList)
            {
                if (c.IsEnabled) {
                    
                    switch (c.GetVote()) {
                        case true:
                            var temp = Decimal.Parse(msPercentYes.Text);
                            msPercentYes.Text = ((temp + c.PopPercent).ToString());
                            break;

                        case false:
                            noCountries.Add(c);
                            break;

                        case null:
                            abstainCountries.Add(c);
                            break;
                    }
                }
            }

            
                
        }

        private void votingRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            // here goes code to change calculations and images based on
            // the voting rule selected.
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
            }
            catch (System.NullReferenceException)
            {

            }


        }
        private void comboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
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
            var c = (Country)countryBox.SelectedItem; 
            c.IsEnabled = countryEnabledCB.Checked;
            if (c.IsEnabled == false)
            {
                OverallPopulation -= c.Population;
                MessageBox.Show(OverallPopulation.ToString());
                totalPopPercentLbl.ForeColor = SystemColors.AppWorkspace;
                totalPopPercentVar.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                OverallPopulation += c.Population;
                totalPopPercentLbl.ForeColor = SystemColors.ControlText;
                totalPopPercentVar.ForeColor = SystemColors.ControlText;
            }
            
            RefreshList();
        }
    }
}
