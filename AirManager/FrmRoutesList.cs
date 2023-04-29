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
using DAL.DTO;

namespace AirManager {
    public partial class FrmRoutesList : Form {
        List<DAL.DTO.RouteDTO> routes = new List<DAL.DTO.RouteDTO>();
        List<DAL.DTO.AirportDTO> airports1 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.AirportDTO> airports2 = new List<DAL.DTO.AirportDTO>();

        bool isUpdate = false;
        RouteDTO detail = new RouteDTO();
        public FrmRoutesList() {
            InitializeComponent();
        }

        private void FrmRoutesList_Load(object sender, EventArgs e) {
            airports1 = BLL.AirportsBLL.GetAirports();
            airports2 = BLL.AirportsBLL.GetAirports();

            cmbOrigin.DataSource = airports1;
            cmbOrigin.DisplayMember = "Name";
            cmbOrigin.ValueMember = "AirportID";
            cmbOrigin.SelectedIndex = 0;

            cmbDestination.DataSource = airports2;
            cmbDestination.DisplayMember = "Name";
            cmbDestination.ValueMember = "AirportID";
            cmbDestination.SelectedIndex = 0;

            refreshDataGrid();

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].HeaderText = "Origin Airport";
            dataGridView.Columns[3].HeaderText = "Origin City";
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Origin Country";
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].HeaderText = "Destination Airport";
            dataGridView.Columns[8].HeaderText = "Destination City";
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[10].HeaderText = "Destination Country";
            dataGridView.Columns[11].Visible = false;
        }
        private void refreshDataGrid() {
            routes = BLL.RoutesBLL.GetRoutes();
            dataGridView.DataSource = routes;

            int originID;
            int destinationID;

            if (cmbOrigin.SelectedValue == null) {
                originID = 0;
            } else {
                try {
                    originID = (int)cmbOrigin.SelectedValue;
                }
                catch (Exception) {
                    originID = 0;
                }
            }
            if (cmbDestination.SelectedValue == null) {
                destinationID = 0;
            } else {
                try {
                    destinationID = (int)cmbDestination.SelectedValue;
                }
                catch (Exception) {
                    destinationID = 0;
                }
            }

            dataGridView.DataSource = routes.Where(x => x.OriginAirportID == originID && x.DestinationAirportID == destinationID).ToList();

            if (dataGridView.Rows.Count > 0) {
                detail = routes.Find(x => x.RouteID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Rows.Count > 0) {
                detail = routes.Find(x => x.RouteID == Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmRoutes frmRoutes = new FrmRoutes();
            frmRoutes.Text = "AirManager - Add Route";
            this.Hide();
            if (frmRoutes.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a route to update!", "Update Route", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmRoutes frmRoutes = new FrmRoutes();
            frmRoutes.isUpdate = true;
            frmRoutes.detail = detail;
            frmRoutes.Text = "AirManager - Update Route";
            this.Hide();
            if (frmRoutes.ShowDialog() == DialogResult.OK) {
                refreshDataGrid();
            }
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this route?", "Delete Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                MessageBox.Show("Route deleted successfully!", "Delete Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
