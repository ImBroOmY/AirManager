using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AirManager {
    public partial class FrmAirports : Form {
        List<Country> countries = new List<Country>();

        public FrmAirports() {
            InitializeComponent();
        }

        private void FrmAirports_Load(object sender, EventArgs e) {
            countries = BLL.CountrysBLL.GetCountries();
            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyLengthTextBox(txtName, "name of the airport", 3, 50)) return;
            if (General.VerifyLengthTextBox(txtIATA, "IATA code of the airport", 3)) return;
            if (General.VerifyLengthTextBox(txtICAO, "ICAO code of the airport", 4)) return;
            if (General.VerifyLengthTextBox(txtCity, "city of the airport", 3, 50)) return;
            if (General.VerifyEmptyComboBox(cmbCountry, "country of the airport")) return;
            if (General.VerifyLengthTextBox(txtLatitude, "latitude of the airport", 3, 50)) return;
            if (General.IsNumber(txtLatitude, "latitude of the airport")) return;
            if (General.VerifyLengthTextBox(txtLongitude, "longitude of the airport", 3, 50)) return;
            if (General.IsNumber(txtLongitude, "longitude of the airport")) return;

            List<DAL.DTO.AirportDTO> airports = BLL.AirportsBLL.GetAirports();
            if (airports.Exists(a => a.IATA == txtIATA.Text)) {
                MessageBox.Show("The IATA code of the airport already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIATA.Focus();
                return;
            }
            if (airports.Exists(a => a.ICAO == txtICAO.Text)) {
                MessageBox.Show("The ICAO code of the airport already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICAO.Focus();
                return;
            }
            if (airports.Exists(a => a.Name == txtName.Text)) {
                MessageBox.Show("The name of the airport already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (airports.Exists(a => a.Latitude == double.Parse(txtLatitude.Text))) {
                MessageBox.Show("The latitude of the airport already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLatitude.Focus();
                return;
            }
            if (airports.Exists(a => a.Longitude == double.Parse(txtLongitude.Text))) {
                MessageBox.Show("The longitude of the airport already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLongitude.Focus();
                return;
            }

            Airport airport = new Airport();
            airport.Name = txtName.Text;
            airport.IATA = txtIATA.Text;
            airport.ICAO = txtICAO.Text;
            airport.City = txtCity.Text;
            airport.CountryID = cmbCountry.SelectedValue.ToString();
            airport.Latitude = double.Parse(txtLatitude.Text);
            airport.Longitude = double.Parse(txtLongitude.Text);

            BLL.AirportsBLL.Add(airport);

            MessageBox.Show("Airport added successfully!", "" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
