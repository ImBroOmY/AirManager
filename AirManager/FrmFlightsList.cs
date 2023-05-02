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
    public partial class FrmFlightsList : Form {
        List<DAL.DTO.FlightDTO> flights = new List<DAL.DTO.FlightDTO>();
        List<DAL.DTO.AirportDTO> airports1 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.AirportDTO> airports2 = new List<DAL.DTO.AirportDTO>();

        DAL.DTO.FlightDTO detail = new DAL.DTO.FlightDTO();
        public FrmFlightsList() {
            InitializeComponent();
        }
        private void FrmFlightsList_Load(object sender, EventArgs e) {
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
            dataGridView.Columns[15].HeaderText = "Departure Date";
            dataGridView.Columns[16].HeaderText = "Duration";
            dataGridView.Columns[17].HeaderText = "Seats Available";
            dataGridView.Columns[18].Visible = false;
        }
        private void refreshDataGrid() {
            flights = BLL.FlightsBLL.GetFlights();

            if (cmbOrigin.SelectedIndex >= 0 && cmbOrigin.SelectedValue is int originID) {
                flights = flights.Where(x => x.OriginAirportID == (int)cmbOrigin.SelectedValue).ToList();
            }
            if (cmbDestination.SelectedIndex >= 0 && cmbDestination.SelectedValue is int destID) {
                flights = flights.Where(x => x.DestinationAirportID == (int)cmbDestination.SelectedValue).ToList();
            }
            if (datePicker.Value != null) {
                flights = flights.Where(x => x.DepartureTime.Date == datePicker.Value.Date).ToList();
            }

            dataGridView.DataSource = flights;

            if (dataGridView.Rows.Count > 0) {
                detail = flights.Find(x => x.FlightID == Convert.ToInt32(dataGridView.Rows[0].Cells[0].Value));
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Rows.Count > 0) {
                detail = flights.Find(x => x.FlightID == Convert.ToInt32(dataGridView.Rows[0].Cells[0].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmFlights frmFlights = new FrmFlights();
            frmFlights.Text = "AirManager - Add Flight";
            this.Hide();
            if (frmFlights.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a flight to update!", "Update Flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmFlights frmFlights = new FrmFlights();
            frmFlights.isUpdate = true;
            frmFlights.detail = detail;
            frmFlights.Text = "AirManager - Update Flight";
            this.Hide();
            if (frmFlights.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a flight to delete!", "Delete Flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this flight?", "Delete Flight", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                FlightsBLL.Delete(detail.FlightID);
                MessageBox.Show("Flight deleted successfully!", "Delete Flight", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void datePicker_ValueChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }


    }
}
