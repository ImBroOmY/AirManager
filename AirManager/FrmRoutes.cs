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
    public partial class FrmRoutes : Form {
        List<DAL.DTO.AirportDTO> airports1 = new List<DAL.DTO.AirportDTO>();
        List<DAL.DTO.AirportDTO> airports2 = new List<DAL.DTO.AirportDTO>();

        public bool isUpdate = false;
        public DAL.DTO.RouteDTO detail = new DAL.DTO.RouteDTO();
        public FrmRoutes() {
            InitializeComponent();
        }

        private void FrmRoutes_Load(object sender, EventArgs e) {
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

            if (isUpdate) {
                cmbOrigin.SelectedValue = detail.OriginAirportID;
                cmbDestination.SelectedValue = detail.DestinationAirportID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyEmptyComboBox(cmbOrigin, "origin airport")) return;
            if (General.VerifyEmptyComboBox(cmbDestination, "destination airport")) return;

            if (cmbOrigin.SelectedIndex == cmbDestination.SelectedIndex) {
                MessageBox.Show("The origin and destination airports must be different!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isUpdate) {
                List<DAL.DTO.RouteDTO> routes = BLL.RoutesBLL.GetRoutes();
                if (routes.Exists(r => r.OriginAirportID == (int)cmbOrigin.SelectedValue && r.DestinationAirportID == (int)cmbDestination.SelectedValue)) {
                    MessageBox.Show("The route already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbOrigin.Focus();
                    return;
                }
            }

            Route route = new Route();
            if (isUpdate) route.RouteID = detail.RouteID;
            route.OriginAirportID = (int)cmbOrigin.SelectedValue;
            route.DestinationAirportID = (int)cmbDestination.SelectedValue;

            if (!isUpdate) {
                BLL.RoutesBLL.Add(route);
                MessageBox.Show("Route added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLL.RoutesBLL.Update(route);
                MessageBox.Show("Route updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e) {
            cmbOrigin.SelectedIndex = cmbDestination.SelectedIndex;
        }
    }
}
