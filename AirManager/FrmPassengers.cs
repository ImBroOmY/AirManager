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
    public partial class FrmPassengers : Form {
        public bool isUpdate = false;
        public DAL.DTO.PassengerDTO detail = new DAL.DTO.PassengerDTO();
        public FrmPassengers() {
            InitializeComponent();
        }

        private void FrmPassengers_Load(object sender, EventArgs e) {
            if (isUpdate) {
                txtFirstName.Text = detail.FirstName;
                txtLastName.Text = detail.LastName;
                txtEmail.Text = detail.Email;
                txtPhone.Text = detail.PhoneNumber;
                dtpDateOfBirth.Value = detail.DateOfBirth;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (General.VerifyLengthTextBox(txtFirstName, "first name of the passenger", 3, 50)) return;
            if (General.VerifyLengthTextBox(txtLastName, "last name of the passenger", 3, 50)) return;
            if (!General.isEmail(txtEmail, "email of the passenger")) return;
            if (!General.isPhone(txtPhone, "phone of the passenger")) return;

            Passenger passenger = new Passenger();
            if (isUpdate) passenger.PassengerID = detail.PassengerID;
            passenger.FirstName = txtFirstName.Text;
            passenger.LastName = txtLastName.Text;
            passenger.Email = txtEmail.Text;
            passenger.PhoneNumber = txtPhone.Text;
            passenger.DateOfBirth = dtpDateOfBirth.Value;

            if (!isUpdate) {
                BLL.PassengersBLL.Add(passenger);
                MessageBox.Show("The passenger was added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLL.PassengersBLL.Update(passenger);
                MessageBox.Show("The passenger was updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
