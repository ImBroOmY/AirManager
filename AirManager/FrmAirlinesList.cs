using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.DTO;

namespace AirManager {
    public partial class FrmAirlinesList : Form {
        List<DAL.DTO.AirlineDTO> airlines = new List<DAL.DTO.AirlineDTO>();

        bool isUpdate = false;
        AirlineDTO detail = new AirlineDTO();
        public FrmAirlinesList() {
            InitializeComponent();
        }

        private void FrmAirlinesList_Load(object sender, EventArgs e) {
            refreshDataGrid();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Airline Name";
            dataGridView.Columns[2].HeaderText = "IATA Code";
            dataGridView.Columns[3].HeaderText = "ICAO Code";
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Country";
        }

        private void refreshDataGrid() {
            airlines = BLL.AirlinesBLL.GetAirlines();
            dataGridView.DataSource = airlines;

            string search = txtSearch.Text.ToLower();
            dataGridView.DataSource = airlines.Where(x => x.AirlineID.ToString().ToLower().Contains(search)
                                                || x.Name.ToLower().Contains(search)
                                                || x.IATA.ToLower().Contains(search)
                                                || x.ICAO.ToLower().Contains(search)
                                                || x.CountryName.ToLower().Contains(search)
                                                ).ToList();

            detail = airlines.Find(x => x.AirlineID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            detail = airlines.Find(x => x.AirlineID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            FrmAirlines frmAirlines = new FrmAirlines();
            frmAirlines.Text = "AirManager - Add Airline";
            this.Hide();
            if (frmAirlines.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an airline to update!", "Update Airline", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAirlines frmAirlines = new FrmAirlines();
            frmAirlines.isUpdate = true;
            frmAirlines.detail = detail;
            frmAirlines.Text = "AirManager - Update Airline";
            this.Hide();
            if (frmAirlines.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this airline?", "Delete Airline", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                MessageBox.Show("Airline deleted successfully!", "Delete Airline", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
