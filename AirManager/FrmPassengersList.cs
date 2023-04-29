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
    public partial class FrmPassengersList : Form {
        List<DAL.DTO.PassengerDTO> passengers = new List<DAL.DTO.PassengerDTO>();

        bool isUpdate = false;
        DAL.DTO.PassengerDTO detail = new DAL.DTO.PassengerDTO();

        public FrmPassengersList() {
            InitializeComponent();
        }

        private void FrmPassengersList_Load(object sender, EventArgs e) {
            refreshDataGrid();

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "First Name";
            dataGridView.Columns[2].HeaderText = "Last Name";
            dataGridView.Columns[3].HeaderText = "Date of Birth";
            dataGridView.Columns[4].HeaderText = "Email";
            dataGridView.Columns[5].HeaderText = "Phone";
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
        }
        private void refreshDataGrid() {
            passengers = BLL.PassengersBLL.GetPassengers();
            dataGridView.DataSource = passengers;

            string search = txtSearch.Text.ToLower();
            dataGridView.DataSource = passengers.Where(p => p.FirstName.ToLower().Contains(search) 
                                                    || p.LastName.ToLower().Contains(search) 
                                                    || p.DateOfBirth.ToString().ToLower().Contains(search)
                                                    || p.Email.ToLower().Contains(search) 
                                                    || p.PhoneNumber.ToLower().Contains(search)).ToList();

            if (dataGridView.Rows.Count > 0) {
                detail = passengers.Find(p => p.PassengerID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Rows.Count > 0) {
                detail = passengers.Find(p => p.PassengerID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmPassengers frmPassengers = new FrmPassengers();
            frmPassengers.Text = "AirManager - Add Passenger";
            this.Hide();
            if (frmPassengers.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a passenger to update!", "Update Passenger", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmPassengers frmPassengers = new FrmPassengers();
            frmPassengers.isUpdate = true;
            frmPassengers.detail = detail;
            frmPassengers.Text = "AirManager - Update Passenger";
            this.Hide();
            if (frmPassengers.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this passenger?", "Delete Passenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                MessageBox.Show("Passenger deleted successfully!", "Delete Passenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
