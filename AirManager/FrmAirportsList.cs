using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.DTO;

namespace AirManager {
    public partial class FrmAirportsList : Form {
        List<DAL.DTO.AirportDTO> list = new List<DAL.DTO.AirportDTO>();

        bool isUpdate = false;
        AirportDTO detail = new AirportDTO();
        public FrmAirportsList() {
            InitializeComponent();
        }
        private void FrmAirportsList_Load(object sender, EventArgs e) {
            refreshDataGrid();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Airport Name";
            dataGridView.Columns[2].HeaderText = "IATA Code";
            dataGridView.Columns[3].HeaderText = "ICAO Code";
            dataGridView.Columns[4].HeaderText = "City";
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].HeaderText = "Country";
            dataGridView.Columns[7].HeaderText = "Latitude";
            dataGridView.Columns[8].HeaderText = "Longitude";
        }

        private void refreshDataGrid() {
            list = BLL.AirportsBLL.GetAirports();
            dataGridView.DataSource = list;

            string search = txtSearch.Text.ToLower();
            dataGridView.DataSource = list.Where(x => x.AirportID.ToString().ToLower().Contains(search)
                                                || x.Name.ToLower().Contains(search) 
                                                || x.IATA.ToLower().Contains(search)
                                                || x.ICAO.ToLower().Contains(search) 
                                                || x.City.ToLower().Contains(search) 
                                                || x.CountryName.ToLower().Contains(search)
                                                || x.Latitude.ToString().ToLower().Contains(search)
                                                || x.Longitude.ToString().ToLower().Contains(search)
                                                ).ToList();

            if (dataGridView.Rows.Count > 0) {
                detail = list.Find(x => x.AirportID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Rows.Count > 0) {
                detail = list.Find(x => x.AirportID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmAirports frmAirports = new FrmAirports();
            frmAirports.Text = "AirManager - Add Airport";
            this.Hide();
            frmAirports.ShowDialog();
            if (frmAirports.DialogResult == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an airport to update!", "Update Airport", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAirports frmAirports = new FrmAirports();
            frmAirports.isUpdate = true;
            frmAirports.detail = detail;
            frmAirports.Text = "AirManager - Update Airport";
            this.Hide();
            frmAirports.ShowDialog();
            if (frmAirports.DialogResult == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this airport?", "Delete Airport", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                MessageBox.Show("Airport deleted successfully!", "Delete Airport", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            refreshDataGrid();
        }
    }
}
