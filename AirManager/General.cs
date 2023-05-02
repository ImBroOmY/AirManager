using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Text.RegularExpressions;

namespace AirManager {
    public class General {
        public static bool IsNumber(TextBox textBox, string name) {
            double number;
            if (double.TryParse(textBox.Text, out number)) {
                return false;
            }
            MessageBox.Show("The " + name + " must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
            return true;
        }
        public static bool IsNumber(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                return true;
            }
            return false;
        }
        public static bool isEmail(TextBox textBox, string name) {
            if (Regex.IsMatch(textBox.Text, @"^[\w\.-]+@[\w\.-]+\.\w+$")) {
                return true;
            }
            MessageBox.Show("The " + name + " must be a valid email format!\nExample: airmanager@mihainiculai.ro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
            return false;
        }
        public static bool isPhone(TextBox textBox, string name) {
            if (Regex.IsMatch(textBox.Text, @"^\+\d{1,4}\d{7,10}$")) {
                return true;
            }
            MessageBox.Show("The " + name + " must be a valid phone format!\nExample: +40712345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
            return false;
        }
        public static bool VerifyEmptyTextBox(TextBox textBox, string name) {
            if (textBox.Text == String.Empty) {
                MessageBox.Show("Please enter the " + name + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return true;
            }
            return false;
        }
        public static bool VerifyEmptyComboBox(ComboBox comboBox, string name) {
            if (comboBox.Text == String.Empty) {
                MessageBox.Show("Please select the " + name + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return true;
            }
            return false;
        }
        public static bool VerifyLengthTextBox(TextBox textBox, string name, int lenght) {
            if (textBox.Text.Length != lenght) {
                MessageBox.Show("The " + name + " must be " + lenght + " characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return true;
            }
            return false;
        }
        public static bool VerifyLengthTextBox(TextBox textBox, string name, int minLenght, int maxLenght) {
            if (textBox.Text.Length < minLenght || textBox.Text.Length > maxLenght) {
                MessageBox.Show("The " + name + " must be between " + minLenght + " and " + maxLenght + " characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return true;
            }
            return false;
        }
        public static string HashPassword(string password) {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string password, string hash) {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
        public static string GenerateVerificationCode() {
            Random random = new Random();
            string verificationCode = String.Empty;
            for (int i = 0; i < 6; i++) {
                verificationCode += random.Next(0, 9);
            }
            return verificationCode;
        }
    }
}
