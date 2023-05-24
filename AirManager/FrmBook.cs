using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;

namespace AirManager {
    public partial class FrmBook : Form {
        List<DAL.DTO.AirportDTO> airports1 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.AirportDTO> airports2 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.FlightDTO> flights = new List<DAL.DTO.FlightDTO>();
        public PassengerDTO passenger;

        public FrmBook() {
            InitializeComponent();
        }

        private void FrmBook_Load(object sender, EventArgs e) {
            airports1 = AirportsBLL.GetAirports().Where(a => a.City != "").GroupBy(a => a.City).Select(a => a.First()).ToList();
            airports2 = AirportsBLL.GetAirports().Where(a => a.City != "").GroupBy(a => a.City).Select(a => a.First()).ToList();

            cmbOrigin.DataSource = airports1;
            cmbOrigin.DisplayMember = "City";
            cmbOrigin.SelectedIndex = -1;

            cmbDestination.DataSource = airports2;
            cmbDestination.DisplayMember = "City";
            cmbDestination.SelectedIndex = -1;

            refrashDataGrid();
        }

        private void refrashDataGrid() {
            flights = FlightsBLL.GetFlights().Where(f => f.OriginAirportCity == cmbOrigin.Text && f.DestinationAirportCity == cmbDestination.Text && f.DepartureTime.Date == dtpDate.Value.Date).ToList();
            flights.Sort((f1, f2) => f1.DepartureTime.CompareTo(f2.DepartureTime));



            dataGridView.DataSource = flights;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Flight Number";
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].HeaderText = "Origin Airport";
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].HeaderText = "Destination Airport";
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            dataGridView.Columns[14].HeaderText = "Airline";
            dataGridView.Columns[15].HeaderText = "Departure Time";
            dataGridView.Columns[16].HeaderText = "Duration";
            dataGridView.Columns[18].Visible = false;

            dataGridView.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a flight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int flightID = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            double price = 0;
            int seatNumber = 0;
            foreach (DAL.DTO.FlightDTO flight in flights) {
                if (flight.FlightID == flightID) {
                    price = flight.Duration.TotalMinutes * 0.8;
                    price = Math.Round(price, 2);
                    seatNumber = new Random().Next(0, flight.Seats);
                    break;
                }
            }

            if (DialogResult.Yes != MessageBox.Show("The price is $" + price + ". Do you want to book this flight?", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                return;
            }

            Reservation reservation = new Reservation();
            reservation.FlightID = flightID;
            reservation.PassengerID = passenger.PassengerID;
            reservation.SeatNumber = seatNumber;
            reservation.Price = price;
            reservation.BookingStatus = 1;

            ReservationsBLL.Add(reservation);

            MessageBox.Show("The flight has been booked", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e) {
            refrashDataGrid();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e) {
            refrashDataGrid();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e) {
            refrashDataGrid();
        }
    }
}
