namespace CountrySubdivisions
{
    public partial class CountryInfoForm : Form
    {
        public CountryInfoForm()
        {
            string[] locales = new string[] { "en", "ar", "de" };
            InitializeComponent();
            this.localesComboBox.DataSource = locales;

            this.localesComboBox.SelectedValueChanged += LocalesComboBox_SelectedValueChanged;
        }

        private void LocalesComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            string locales = this.localesComboBox.SelectedItem as string;
            MessageBox.Show(locales);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}