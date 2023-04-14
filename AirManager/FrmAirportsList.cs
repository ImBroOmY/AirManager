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
    public partial class FrmAirportsList : Form {
        List<DAL.DTO.AirportDTO> list = new List<DAL.DTO.AirportDTO>();
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
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            FrmAirports frmAirports = new FrmAirports();
            frmAirports.Text = "AirManager - Add Airport";
            this.Hide();
            frmAirports.ShowDialog();
            if (frmAirports.DialogResult == DialogResult.OK) {
                refresh();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            FrmAirports frmAirports = new FrmAirports();
            frmAirports.Text = "AirManager - Update Airport";
            this.Hide();
            frmAirports.ShowDialog();
            if (frmAirports.DialogResult == DialogResult.OK) {
                refresh();
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
    }
}
