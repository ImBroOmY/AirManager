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
    public partial class FrmVerification : Form {
        string verificationCode;
        string email;
        string name;
        public FrmVerification() {
            InitializeComponent();
        }
        public FrmVerification(string email, string name) {
            InitializeComponent();
            this.email = email;
            this.name = name;
        }

        private void FrmVerification_Load(object sender, EventArgs e) {
            //for tesqting purposes
            //DialogResult = DialogResult.OK;
            //return;

            verificationCode = General.GenerateVerificationCode();
            EmailHelper.sendVerificationEmail(email, name, verificationCode);
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            if (txtCode.Text == verificationCode) {
                this.DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
