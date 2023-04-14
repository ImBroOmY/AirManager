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
    public partial class FrmAirlinesList : Form {
        List<DAL.DTO.AirlineDTO> airlines = new List<DAL.DTO.AirlineDTO>();
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
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmAirlines frmAirlines = new FrmAirlines();
            frmAirlines.Text = "AirManager - Add Airline";
            this.Hide();
            if (frmAirlines.ShowDialog() == DialogResult.OK) {
                refresh();
            }
            this.Validate();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            FrmAirlines frmAirlines = new FrmAirlines();
            frmAirlines.Text = "AirManager - Update Airline";
            this.Hide();
            if (frmAirlines.ShowDialog() == DialogResult.OK) {
                refresh();
            }
            this.Validate();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this airline?", "Delete Airline", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                MessageBox.Show("Airline deleted successfully!", "Delete Airline", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
