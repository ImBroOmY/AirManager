using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            foreach (Admin admin in admins) {
                if (admin.Username == txtUsername.Text && General.VerifyPassword(txtPassword.Text, admin.Password)) {
                    FrmVerification frmVerification = new FrmVerification(admin.Email, admin.FirstName + " " + admin.LastName);
                    if (frmVerification.ShowDialog() != DialogResult.OK) {
                        return;
                    }

                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.lblHello.Text = "Hello, " + admin.FirstName + " " + admin.LastName + "!";
                    this.Hide();
                    if (frmAdmin.ShowDialog() == DialogResult.OK) {
                        this.Show();
                    }
                    else {
                        this.Close();
                    }
                    return;
                }
            }
            
            List<DAL.DTO.PassengerDTO> passengers = PassengersBLL.GetPassengers();

            foreach (DAL.DTO.PassengerDTO passenger in passengers) {
                if (passenger.Username == txtUsername.Text && General.VerifyPassword(txtPassword.Text, passenger.Password)) {
                    FrmVerification frmVerification = new FrmVerification(passenger.Email, passenger.FirstName + " " + passenger.LastName);
                    if (frmVerification.ShowDialog() != DialogResult.OK) {
                        return;
                    }
                    FrmHome frmHome = new FrmHome();
                    frmHome.passenger = passenger;
                    this.Hide();
                    if (frmHome.ShowDialog() == DialogResult.OK) {
                        this.Show();
                    }
                    else {
                        this.Close();
                    }
                    return;
                }
            }

            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            FrmSignUp frmSignUp = new FrmSignUp();
            this.Hide();
            frmSignUp.ShowDialog();
            this.Visible = true;
        }
    }
}
