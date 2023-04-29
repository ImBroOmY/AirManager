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

namespace AirManager {
    public partial class FrmAirlines : Form {
        List<Country> countries = new List<Country>();

        public bool isUpdate = false;
        public DAL.DTO.AirlineDTO detail = new DAL.DTO.AirlineDTO();

        public FrmAirlines() {
            InitializeComponent();
        }
        private void FrmAirlines_Load(object sender, EventArgs e) {
            countries = BLL.CountrysBLL.GetCountries();
            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.SelectedIndex = -1;

            if (isUpdate) {
                txtName.Text = detail.Name;
                txtIATA.Text = detail.IATA;
                txtICAO.Text = detail.ICAO;
                cmbCountry.SelectedValue = detail.CountryID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyLengthTextBox(txtName, "name of the airline", 3, 50)) return;
            if (General.VerifyLengthTextBox(txtIATA, "IATA code of the airline", 2)) return;
            if (General.VerifyLengthTextBox(txtICAO, "ICAO code of the airline", 3)) return;
            if (General.VerifyEmptyComboBox(cmbCountry, "country of the airline")) return;

            if (!isUpdate) {
                List<DAL.DTO.AirlineDTO> airlines = BLL.AirlinesBLL.GetAirlines();
                if (airlines.Exists(a => a.IATA == txtIATA.Text)) {
                    MessageBox.Show("The IATA code of the airline already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIATA.Focus();
                    return;
                }
                if (airlines.Exists(a => a.ICAO == txtICAO.Text)) {
                    MessageBox.Show("The ICAO code of the airline already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtICAO.Focus();
                    return;
                }
                if (airlines.Exists(a => a.Name == txtName.Text)) {
                    MessageBox.Show("The name of the airline already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
            }

            Airline airline = new Airline();
            if (isUpdate) airline.AirlineID = detail.AirlineID;
            airline.Name = txtName.Text;
            airline.IATA = txtIATA.Text;
            airline.ICAO = txtICAO.Text;
            airline.CountryID = cmbCountry.SelectedValue.ToString();

            if(!isUpdate) {
                BLL.AirlinesBLL.Add(airline);
                MessageBox.Show("Airline added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLL.AirlinesBLL.Update(airline);
                MessageBox.Show("Airline updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
