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
    public partial class FrmFlights : Form {
        List<DAL.DTO.RouteDTO> routes = new List<DAL.DTO.RouteDTO> ();
        List<DAL.DTO.AirlineDTO> airlines = new List<DAL.DTO.AirlineDTO> ();

        public bool isUpdate = false;
        public DAL.DTO.FlightDTO detail = new DAL.DTO.FlightDTO ();

        public FrmFlights() {
            InitializeComponent();
        }

        private void FrmFlights_Load(object sender, EventArgs e) {
            routes = BLL.RoutesBLL.GetRoutes();

            cmbRoute.DataSource = routes;
            cmbRoute.DisplayMember ="toString";
            cmbRoute.ValueMember = "RouteID";
            cmbRoute.SelectedIndex = -1;

            airlines = BLL.AirlinesBLL.GetAirlines();

            cmbAirline.DataSource = airlines;

            cmbAirline.DisplayMember = "Name";
            cmbAirline.ValueMember = "AirlineID";
            cmbAirline.SelectedIndex = -1;

            if (isUpdate) {
                cmbRoute.SelectedValue = detail.RouteID;
                cmbAirline.SelectedValue = detail.AirlineID;
                dtpDate.Value = detail.DepartureTime;
                dtpTime.Value = detail.DepartureTime;
                dtpDuration.Value = new DateTime(2023, 1, 1, detail.Duration.Hours, detail.Duration.Minutes, detail.Duration.Seconds);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyEmptyComboBox(cmbRoute, "route of the flight")) return;
            if (General.VerifyEmptyComboBox(cmbAirline, "airline of the flight")) return;

            string AirlineName = String.Empty;
            foreach (DAL.DTO.AirlineDTO airline in airlines) {
                if (airline.AirlineID == int.Parse(cmbAirline.SelectedValue.ToString())) {
                    AirlineName = airline.IATA;
                    break;
                }
            }
            AirlineName += new Random().Next(1000, 9999).ToString();

            Flight flight = new Flight();
            if (isUpdate) flight.FlightID = detail.FlightID;
            flight.FlightNumber = AirlineName;
            flight.RouteID = int.Parse(cmbRoute.SelectedValue.ToString());
            flight.AirlineID = int.Parse(cmbAirline.SelectedValue.ToString());
            flight.DepartureTime = dtpDate.Value + dtpTime.Value.TimeOfDay;
            flight.Duration = dtpDuration.Value.TimeOfDay;
            flight.Seats = new Random().Next(50, 200);

            if (!isUpdate) {
                BLL.FlightsBLL.Add(flight);
                MessageBox.Show("The flight was added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLL.FlightsBLL.Update(flight);
                MessageBox.Show("The flight was updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
