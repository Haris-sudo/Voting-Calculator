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
        public decimal OverallPopulation { get; set; }
        public EUVotingCalculator()
        {
            OverallPopulation = 447470672;
            using (var reader = new StreamReader("..\\Country Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Country record = new Country("Placeholder", 0, false, true);

                var records = csv.EnumerateRecords(record);

                foreach (Country r in records)
                {
                    Country newCountry = new Country(r.Name, r.Population, r.EurozoneStatus, r.IsEnabled);
                    countryList.Add(newCountry);

                }

                InitializeComponent();
                countryBox.DisplayMember = "Name";
                countryBox.ValueMember = "Name";
                countryBox.DataSource = countryList;
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

        private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var c = (Country)countryBox.SelectedItem;

                countryEnabledCB.Checked = c.IsEnabled;
                countryFlagImg.ImageLocation = (@"..\\flags\" + c.Name.Replace(" [Disabled]", "") + ".png");
                decimal pop = ((c.Population / OverallPopulation) * 100);
                totalPopVar.Text = c.Population.ToString();
                totalPopPercentVar.Text = ((Math.Round(pop, 2).ToString()) + "%");
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
                OverallPopulation = -c.Population;
            }
            else
            {
                OverallPopulation = +c.Population;
            }
            string countryName = (c.Name);
            RefreshList();
        }
    }
}
