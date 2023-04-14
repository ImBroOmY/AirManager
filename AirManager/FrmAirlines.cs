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
using DAL;
using DAL.DTO;

namespace AirManager {
    public partial class FrmAirlines : Form {
        List<Country> countries = new List<Country>();
        public FrmAirlines() {
            InitializeComponent();
        }
        private void FrmAirlines_Load(object sender, EventArgs e) {
            countries = BLL.CountrysBLL.GetCountries();
            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyLengthTextBox(txtName, "name of the airline", 3, 50)) return;
            if (General.VerifyLengthTextBox(txtIATA, "IATA code of the airline", 2)) return;
            if (General.VerifyLengthTextBox(txtICAO, "ICAO code of the airline", 3)) return;
            if (General.VerifyEmptyComboBox(cmbCountry, "country of the airline")) return;

            Airline airline = new Airline();
            airline.Name = txtName.Text;
            airline.IATA = txtIATA.Text;
            airline.ICAO = txtICAO.Text;
            airline.CountryID = cmbCountry.SelectedValue.ToString();

            BLL.AirlinesBLL.Add(airline);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
