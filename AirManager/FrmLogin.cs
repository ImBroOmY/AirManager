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
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string HashedPassword = txtPassword.Text.GetHashCode().ToString();
            if (txtUsername.Text != "admin" && txtPassword.Text != "admin") {
                FrmAdmin frmAdmin = new FrmAdmin();
                this.Hide();
                frmAdmin.ShowDialog();
                this.Close();
            } else {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
