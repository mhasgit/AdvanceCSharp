using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesFormApp
{
    public partial class CountriesForm : Form
    {
        private CountryService countryService;

        public CountriesForm()
        {
            InitializeComponent();
            this.countryService = new CountryService();

            string[] locales = new string[] { "en", "ar", "de" };
            this.localesComboBox.DataSource = locales;

            this.localesComboBox.SelectedIndexChanged += LocalesComboBox_SelectedIndexChanged;
            this.countryListBox.SelectedIndexChanged += CountryListBox_SelectedIndexChanged;
        }

        private void LocalesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string locale = this.localesComboBox.SelectedItem as string;
            List<Country> countries = countryService.GetCountriesByLocale(locale);

            this.countryListBox.DataSource = countries;
            this.countryListBox.DisplayMember = "Name";
            this.countryListBox.ValueMember = "Alpha2";
        }

        private void CountryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = this.countryListBox.SelectedItem as Country;
            if(selectedCountry != null)
            {
                string alpha2Code = selectedCountry.Alpha2.ToLower();

                List<Subdivision> subdivisions = countryService.GetSubdivisions();
                List<Subdivision> selectedCountrySubdivisions = subdivisions
                    .Where(s => s.Country.ToLower() == alpha2Code).ToList();

                this.subdivisionListBox.DataSource = selectedCountrySubdivisions;
                this.subdivisionListBox.DisplayMember = "Name";
                this.subdivisionListBox.ValueMember = "Code";

                // Stream flagStream = countryService.GetCountryFlag(alpha2Code);
                // this.flagPictureBox.Image = Image.FromStream(flagStream);
                this.flagPictureBox.ImageLocation = countryService.GetCountryFlagPath(alpha2Code);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(countryService.FalgsDirectory))
            {
                Directory.CreateDirectory(countryService.FalgsDirectory);
            }
        }
    }
}
