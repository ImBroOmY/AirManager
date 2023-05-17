using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirManager {
    public partial class FrmAdmin : Form {
        public FrmAdmin() {
            InitializeComponent();
        }

        private void btnAirports_Click(object sender, EventArgs e) {
            FrmAirportsList form = new FrmAirportsList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnAirlines_Click(object sender, EventArgs e) {
            FrmAirlinesList form = new FrmAirlinesList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnRoutes_Click(object sender, EventArgs e) {
            FrmRoutesList form = new FrmRoutesList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnFlights_Click(object sender, EventArgs e) {
            FrmFlightsList form = new FrmFlightsList();
            this.Hide(); 
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnPassengers_Click(object sender, EventArgs e) {
            FrmPassengersList form = new FrmPassengersList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnReservations_Click(object sender, EventArgs e) {
            FrmReservationsList form = new FrmReservationsList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
