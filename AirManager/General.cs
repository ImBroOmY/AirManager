using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
