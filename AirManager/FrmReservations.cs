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
    public partial class FrmReservations : Form {
        private int OriginAirportID;
        private int DestinationAirportID;
        private DateTime DepartureDate;

        List<DAL.DTO.FlightDTO> flights = new List<DAL.DTO.FlightDTO>();
        List<DAL.DTO.PassengerDTO> passengers = new List<DAL.DTO.PassengerDTO>();
        List<DAL.BookingStatus> bookingStatuses = new List<DAL.BookingStatus>();

        public bool isUpdate = false;
        public DAL.DTO.ReservationDTO detail = new DAL.DTO.ReservationDTO();

        public FrmReservations() {
            InitializeComponent();
        }

        public FrmReservations(int OriginAirportID, int DestinationAirportID, DateTime DepartureDate) {
            InitializeComponent();
            this.OriginAirportID = OriginAirportID;
            this.DestinationAirportID = DestinationAirportID;
            this.DepartureDate = DepartureDate;
        }

        private void FrmReservations_Load(object sender, EventArgs e) {
            flights = BLL.FlightsBLL.GetFlights();
            flights = flights.FindAll(f => f.OriginAirportID == OriginAirportID && f.DestinationAirportID == DestinationAirportID && f.DepartureTime.Date == DepartureDate.Date);
            cmbFlight.DataSource = flights;
            cmbFlight.DisplayMember = "toString";
            cmbFlight.ValueMember = "FlightID";
            cmbFlight.SelectedIndex = -1;

            passengers = BLL.PassengersBLL.GetPassengers();
            cmbPassenger.DataSource = passengers;
            cmbPassenger.DisplayMember = "toString";
            cmbPassenger.ValueMember = "PassengerID";
            cmbPassenger.SelectedIndex = -1;

            bookingStatuses = BLL.BookingStatusesBLL.GetBookingStatuses();
            cmbStatus.DataSource = bookingStatuses;
            cmbStatus.DisplayMember = "Status";
            cmbStatus.ValueMember = "BookingStatusID";
            cmbStatus.SelectedIndex = 0;

            if (isUpdate) {
                cmbFlight.SelectedValue = detail.FlightID;
                cmbPassenger.SelectedValue = detail.PassengerID;
                cmbStatus.SelectedValue = detail.BookingStatus;
                txtPrice.Text = detail.Price.ToString("0.00");

                cmbFlight.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!isUpdate && General.VerifyEmptyComboBox(cmbFlight, "flight")) return;
            if (General.VerifyEmptyComboBox(cmbPassenger, "passenger")) return;
            if (General.VerifyEmptyComboBox(cmbStatus, "status")) return;

            Reservation reservation = new Reservation();
            if (isUpdate) reservation.ReservationID = detail.ReservationID;
            if (!isUpdate) reservation.FlightID = Convert.ToInt32(cmbFlight.SelectedValue);
            reservation.PassengerID = Convert.ToInt32(cmbPassenger.SelectedValue);
            reservation.BookingStatus = Convert.ToInt32(cmbStatus.SelectedValue);
            if (!isUpdate) reservation.Price = Convert.ToDouble(txtPrice.Text);
            if (!isUpdate) reservation.SeatNumber = new Random().Next(0, flights[cmbFlight.SelectedIndex].Seats);

            if (!isUpdate) {
                BLL.ReservationsBLL.Add(reservation);
                MessageBox.Show("Reservation added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLL.ReservationsBLL.Update(reservation);
                MessageBox.Show("Reservation updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbFlight_SelectedIndexChanged(object sender, EventArgs e) {
            double price = 0;
            try {
                price = flights[cmbFlight.SelectedIndex].Duration.TotalMinutes * 0.8;
            }
            catch (Exception) {
                
            }
            finally {
                txtPrice.Text = price.ToString("0.00");
            }
        }
    }
}
