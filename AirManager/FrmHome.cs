using BLL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

        private void btnPrintTicket_Click(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) {
                ReservationDTO selectedReservation = (ReservationDTO)dataGridView.SelectedRows[0].DataBoundItem;

                SaveFileDialog saveFileDialog = new SaveFileDialog {
                    Filter = "PDF Files|*.pdf",
                    FileName = $"Ticket_{selectedReservation.FlightNumber}_{selectedReservation.FirstName}_{selectedReservation.LastName}_{selectedReservation.SeatNumber}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    using (var doc = new PdfSharp.Pdf.PdfDocument()) {
                        var page = doc.AddPage();
                        var gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page);

                        var logoPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Resources\Logo - Color.png";
                        var logo = PdfSharp.Drawing.XImage.FromFile(logoPath);
                        gfx.DrawImage(logo, 40, 40, 50, 50);

                        var appNameFont = new PdfSharp.Drawing.XFont("Arial", 20, PdfSharp.Drawing.XFontStyle.Bold);
                        gfx.DrawString("AirManager", appNameFont, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(105, 70));

                        var titleFont = new PdfSharp.Drawing.XFont("Arial", 20, PdfSharp.Drawing.XFontStyle.Bold);
                        var headerFont = new PdfSharp.Drawing.XFont("Arial", 14, PdfSharp.Drawing.XFontStyle.Bold);
                        var textFont = new PdfSharp.Drawing.XFont("Arial", 12);
                        var customColor = PdfSharp.Drawing.XColor.FromArgb(67, 198, 172);
                        var customBrush = new PdfSharp.Drawing.XSolidBrush(customColor);
                        var customColor2 = PdfSharp.Drawing.XColor.FromArgb(25, 22, 84);
                        var customBrush2 = new PdfSharp.Drawing.XSolidBrush(customColor2);
                        var blackColor = PdfSharp.Drawing.XBrushes.Black;

                        gfx.DrawString("Flight Ticket", titleFont, customBrush, new PdfSharp.Drawing.XPoint(40, 160));

                        gfx.DrawLine(PdfSharp.Drawing.XPens.Black, 40, 180, page.Width - 40, 180);

                        int verticalSpacing = 30;

                        gfx.DrawString("Flight Number", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 180 + verticalSpacing));
                        gfx.DrawString(selectedReservation.FlightNumber, textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 180 + verticalSpacing));

                        gfx.DrawString("Origin", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 210 + verticalSpacing));
                        gfx.DrawString(selectedReservation.OriginAirportName, textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 210 + verticalSpacing));

                        gfx.DrawString("Destination", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 240 + verticalSpacing));
                        gfx.DrawString(selectedReservation.DestinationAirportName, textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 240 + verticalSpacing));

                        gfx.DrawString("Airline", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 270 + verticalSpacing));
                        gfx.DrawString(selectedReservation.AirlineName, textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 270 + verticalSpacing));

                        gfx.DrawString("Departure Time", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 300 + verticalSpacing));
                        gfx.DrawString(selectedReservation.DepartureTime.ToString(), textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 300 + verticalSpacing));

                        gfx.DrawString("Duration", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 330 + verticalSpacing));
                        gfx.DrawString(selectedReservation.Duration.ToString(), textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 330 + verticalSpacing));

                        gfx.DrawString("Seat Number", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 360 + verticalSpacing));
                        gfx.DrawString(selectedReservation.SeatNumber.ToString(), textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 360 + verticalSpacing));

                        gfx.DrawString("Price", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 390 + verticalSpacing));
                        gfx.DrawString(selectedReservation.Price.ToString("C"), textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 390 + verticalSpacing));

                        gfx.DrawString("Status", headerFont, customBrush2, new PdfSharp.Drawing.XPoint(40, 420 + verticalSpacing));
                        gfx.DrawString(selectedReservation.Status, textFont, blackColor, new PdfSharp.Drawing.XPoint(170, 420 + verticalSpacing));

                        gfx.DrawLine(PdfSharp.Drawing.XPens.Black, 40, 450 + verticalSpacing, page.Width - 40, 450 + verticalSpacing);

                        doc.Save(saveFileDialog.FileName);

                    }

                    MessageBox.Show("Ticket saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Please select a reservation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
