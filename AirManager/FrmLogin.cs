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
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            List<Admin> admins = new List<Admin>();
            admins = AdminsBLL.GetAdminList();

            //For testing purposes
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";

            if (admins.Count == 0) {
                MessageBox.Show("No admin account found. Please create one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Admin admin in admins) {
                if (admin.Username == txtUsername.Text && General.VerifyPassword(txtPassword.Text, admin.Password)) {

                    bool trimis = EmailHelper.SendEmail("nmbroomy@gmail.com", "AirManager", "Un utilizator s-a logat in aplicatie.");

                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.lblHello.Text = "Hello, " + admin.FirstName + " " + admin.LastName + "!";
                    this.Hide();
                    frmAdmin.Show();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSignUp_Click(object sender, EventArgs e) {

        }
    }
}
