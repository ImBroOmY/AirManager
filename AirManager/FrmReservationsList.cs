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
    public partial class FrmReservationsList : Form {
        List<DAL.DTO.ReservationDTO> reservations = new List<DAL.DTO.ReservationDTO>();
        List<DAL.DTO.AirportDTO> airports1 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.AirportDTO> airports2 = new List<DAL.DTO.AirportDTO>();

        DAL.DTO.ReservationDTO detail = new DAL.DTO.ReservationDTO();

        public FrmReservationsList() {
            InitializeComponent();
        }

        private void FrmReservationsList_Load(object sender, EventArgs e) {
            airports1 = BLL.AirportsBLL.GetAirports();
            airports2 = BLL.AirportsBLL.GetAirports();

            cmbOrigin.DataSource = airports1;
            cmbOrigin.DisplayMember = "Name";
            cmbOrigin.ValueMember = "AirportID";
            cmbOrigin.SelectedIndex = -1;

            cmbDestination.DataSource = airports2;
            cmbDestination.DisplayMember = "Name";
            cmbDestination.ValueMember = "AirportID";
            cmbDestination.SelectedIndex = -1;

            refreshDataGrid();

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].HeaderText = "Flight Number";
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            dataGridView.Columns[14].Visible = false;
            dataGridView.Columns[15].HeaderText = "Airline";
            dataGridView.Columns[16].HeaderText = "Departure Time";
            dataGridView.Columns[17].HeaderText = "Duration";
            dataGridView.Columns[18].Visible = false;
            dataGridView.Columns[19].Visible = false;
            dataGridView.Columns[20].HeaderText = "First Name";
            dataGridView.Columns[21].HeaderText = "Last Name";
            dataGridView.Columns[22].Visible = false;
            dataGridView.Columns[23].Visible = false;
            dataGridView.Columns[24].Visible = false;
            dataGridView.Columns[25].Visible = false;
            dataGridView.Columns[26].Visible = false;
            dataGridView.Columns[27].HeaderText = "Seat Number";
            dataGridView.Columns[28].HeaderText = "Price";
            dataGridView.Columns[29].Visible = false;
            dataGridView.Columns[30].HeaderText = "Status";
        }

        private void refreshDataGrid() {
            reservations = BLL.ReservationsBLL.GetReservations();

            

            string search = txtSearch.Text.ToLower();
            reservations = reservations.Where(x => x.FlightNumber.ToString().Contains(search)
                                                    || x.AirlineName.ToLower().Contains(search) 
                                                    || x.FirstName.ToLower().Contains(search) 
                                                    || x.LastName.ToLower().Contains(search) 
                                                    || x.DateOfBirth.ToString().Contains(search)
                                                    || x.Email.ToLower().Contains(search)
                                                    || x.PhoneNumber.ToLower().Contains(search)
                                                    || x.SeatNumber.ToString().Contains(search) 
                                                    || x.Price.ToString().Contains(search) 
                                                    || x.Status.ToLower().Contains(search)
                                                    ).ToList();

            if ( cmbOrigin.SelectedIndex > 0 && cmbOrigin.SelectedValue is int) {
                reservations = reservations.Where(x => x.OriginAirportID == Convert.ToInt32(cmbOrigin.SelectedValue)).ToList();
            }
            if ( cmbDestination.SelectedIndex >= 0 && cmbDestination.SelectedValue is int) {
                reservations = reservations.Where(x => x.DestinationAirportID == Convert.ToInt32(cmbDestination.SelectedValue)).ToList();
            }
            if ( dtpDate.Value != null ) {
                reservations = reservations.Where(x => x.DepartureTime.Date == dtpDate.Value.Date).ToList();
            }

            dataGridView.DataSource = reservations;

            if (dataGridView.Rows.Count > 0) {
                detail  = reservations.Find(x => x.ReservationID == Convert.ToInt32(dataGridView.Rows[0].Cells[0].Value));
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Rows.Count > 0) {
                detail = reservations.Find(x => x.ReservationID == Convert.ToInt32(dataGridView.Rows[0].Cells[0].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmReservations frmReservations = new FrmReservations(Convert.ToInt32(cmbOrigin.SelectedValue), Convert.ToInt32(cmbDestination.SelectedValue), dtpDate.Value);
            frmReservations.Text = "AirManager - Add Reservation";
            this.Hide();
            if (frmReservations.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.Rows.Count == 0) {
                MessageBox.Show("Please select a reservation to update!", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmReservations frmReservations = new FrmReservations(Convert.ToInt32(cmbOrigin.SelectedValue), Convert.ToInt32(cmbDestination.SelectedValue), dtpDate.Value);
            frmReservations.isUpdate = true;
            frmReservations.detail = detail;
            frmReservations.Text = "AirManager - Update Reservation";
            this.Hide();
            if (frmReservations.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedCells.Count == 0) {
                MessageBox.Show("Please select a reservation to delete!", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this reservation?", "Delete Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ReservationsBLL.Delete(detail.RouteID);
                MessageBox.Show("Reservation deleted successfully!", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshDataGrid();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }
    }
}
