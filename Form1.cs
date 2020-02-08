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

namespace WinForms_VotingCalc
{

    
    public partial class Form1 : Form
    {
        public List<Country> countryList = new List<Country>();
        public int overallPopulation { get; set; } 
        public Form1()
        {
            overallPopulation = 447470672;
            using (var reader = new StreamReader("..\\Country Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Country record = new Country("Placeholder", 0, false, true);

                var records = csv.EnumerateRecords(record);

                foreach (Country r in records)
                {
                    Country newCountry = new Country(r.name, r.population, r.eurozoneStatus, r.isEnabled);
                    countryList.Add(newCountry);

                }
                
            }
            
            InitializeComponent();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
            comboBox1.DataSource = countryList;

        }

        public class Country
        {
            // Conventions are as follows:
            // camelCase for regular variables, uppercase initial letter only on methods and functions
            // Add an _ for private variables
            public string name { get; set; }
            public int population { get; set; }
            public bool eurozoneStatus { get; set; }
            public bool isEnabled { get; set; }
            // Utilises a nullable bool for the vote, meaning we have three potential statuses of the bool.
            private bool? _vote;
            // This is perfect for the yes, no and abstain states of the vote.
            

            public Country(string name, int population, bool eurozoneStatus, bool isEnabled)
            {
                this.name = name;
                this.population = population;
                this.eurozoneStatus = eurozoneStatus;
                this.isEnabled = isEnabled;
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

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public void refreshList()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
            comboBox1.DataSource = countryList;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var c = (Country)comboBox1.SelectedItem;
                checkBox1.Checked = c.isEnabled;
                pictureBox1.ImageLocation = (@"..\\flags\" + c.name.Replace(" [Disabled]", "") + ".png");
                MessageBox.Show(c.population.ToString());
                MessageBox.Show(overallPopulation.ToString());
                float pop = ((c.population / overallPopulation) * 100);
                MessageBox.Show(pop.ToString()); 
                //label5.Text = label5.Text.Replace("xx.xx", Math.Round(newPop,2).ToString());
            }
            catch (System.NullReferenceException)
            {

            }
            
        }

        

        private void comboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            bool c = ((Country)e.ListItem).isEnabled == false;
            string countryName = ((Country)e.ListItem).name;
            if (c)
            {
                e.Value = (countryName + " [Disabled]");
                
            }
            else
            {
                e.Value = (countryName.Replace(" [Disabled]",""));
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            var c = (Country)comboBox1.SelectedItem;
            c.isEnabled = checkBox1.Checked;
            if (c.isEnabled == false)
            {
                overallPopulation =- c.population;
            }
            else
            {
                overallPopulation = +c.population;
            }
            string countryName = (c.name);
            refreshList();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
