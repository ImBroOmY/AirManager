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
using DAL.DTO;

namespace AirManager {
    public partial class FrmHome : Form {
        public PassengerDTO passenger;
        private List<ReservationDTO> reservations = new List<ReservationDTO>();
        public FrmHome() {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e) {
            lblHello.Text = "Hello, " + passenger.FirstName + " " + passenger.LastName + "!";
            refreshDataGrid();
        }
        private void refreshDataGrid() {
            reservations = ReservationsBLL.GetReservations();
            reservations = reservations.Where(x => x.PassengerID == passenger.PassengerID).ToList();
            //reservations = reservations.Where(x => x.DepartureTime > DateTime.Now).ToList();

            dataGridView.DataSource = reservations;

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].HeaderText = "Flight Number";
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Origin";
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[10].HeaderText = "Destination";
            dataGridView.Columns[11].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            dataGridView.Columns[14].Visible = false;
            dataGridView.Columns[15].HeaderText = "Airline";
            dataGridView.Columns[16].HeaderText = "Departure Time";
            dataGridView.Columns[17].HeaderText = "Duration";
            dataGridView.Columns[18].Visible = false;
            dataGridView.Columns[19].Visible = false;
            dataGridView.Columns[20].Visible = false;
            dataGridView.Columns[21].Visible = false;
            dataGridView.Columns[22].Visible = false;
            dataGridView.Columns[23].Visible = false;
            dataGridView.Columns[24].Visible = false;
            dataGridView.Columns[25].Visible = false;
            dataGridView.Columns[26].Visible = false;
            dataGridView.Columns[27].HeaderText = "Seat Number";
            dataGridView.Columns[28].HeaderText = "Price";
            dataGridView.Columns[29].Visible = false;
            dataGridView.Columns[30].HeaderText = "Status";
        }

        private void btnAirlines_Click(object sender, EventArgs e) {
            FrmBook frmBook = new FrmBook();
            frmBook.passenger = passenger;
            frmBook.ShowDialog();
            refreshDataGrid();
        }
    }
}
