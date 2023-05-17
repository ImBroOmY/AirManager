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
    public partial class FrmSignUp : Form {
        public FrmSignUp() {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            if (General.VerifyLengthTextBox(txtFirstName, "first name", 3, 50)) return;
            if (General.VerifyLengthTextBox(txtLastName, "last name", 3, 50)) return;
            if (!General.isEmail(txtEmail, "email")) return;
            if (!General.isPhone(txtPhone, "phone")) return;
            if (General.VerifyLengthTextBox(txtUsername, "username", 4, 50)) return;
            if (General.VerifyLengthTextBox(txtPassword, "password", 8, 50)) return;

            Passenger passenger = new Passenger();
            passenger.FirstName = txtFirstName.Text;
            passenger.LastName = txtLastName.Text;
            passenger.DateOfBirth = dtpDateOfBirth.Value;
            passenger.Email = txtEmail.Text;
            passenger.PhoneNumber = txtPhone.Text;
            passenger.Username = txtUsername.Text;
            passenger.Password = General.HashPassword(txtPassword.Text);

            int result = PassengersBLL.CheckAccount(passenger);
            if (result == 1) {
                MessageBox.Show("Username already exists!\nPlease choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result == 2) {
                MessageBox.Show("You already have an account!\nIf you forgot your password, please contact the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmVerification frmVerification = new FrmVerification(txtEmail.Text, txtFirstName.Text + " " + txtLastName.Text);
            if (frmVerification.ShowDialog() == DialogResult.Cancel) {
                MessageBox.Show("Verification failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PassengersBLL.CreateAccount(passenger);
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmailHelper.sendWelcomeEmail(passenger.Email, passenger.FirstName + " " + passenger.LastName);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
