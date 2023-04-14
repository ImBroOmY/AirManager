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
            FrmAirportsList list = new FrmAirportsList();
            this.Hide();
            list.ShowDialog();
            this.Visible = true;
        }

        private void btnAirlines_Click(object sender, EventArgs e) {
            FrmAirlinesList list = new FrmAirlinesList();
            this.Hide();
            list.ShowDialog();
            this.Visible = true;
        }
    }
}
