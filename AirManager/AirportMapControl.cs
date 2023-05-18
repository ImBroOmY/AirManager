using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using BLL;
using System.Drawing;

namespace AirManager {
    internal class AirportMapControl : Control {
        private List<DAL.DTO.AirportDTO> airports;
        private List<int> numberOfFlights;
        private GMapControl gmap;

        public AirportMapControl() {
            this.airports = new List<DAL.DTO.AirportDTO>();

            this.gmap = new GMapControl();
            this.Controls.Add(gmap);

            this.gmap.Dock = DockStyle.Fill;
            this.gmap.MapProvider = GMapProviders.GoogleMap;
            this.gmap.Position = new PointLatLng(50.0, 10.0);
            this.gmap.MinZoom = 0;
            this.gmap.MaxZoom = 24;
            this.gmap.Zoom = 4;
        }

        public void SetAirports() {
            this.airports = AirportsBLL.GetAirports();

            List<DAL.DTO.FlightDTO> flights = FlightsBLL.GetFlights();
            numberOfFlights = new List<int>();

            for (int i = 0; i < this.airports.Count; i++) {
                int count = 0;
                foreach (DAL.DTO.FlightDTO flight in flights) {
                    if (flight.DestinationAirportID == this.airports[i].AirportID || flight.OriginAirportID == this.airports[i].AirportID) {
                        count++;
                    }
                }
                numberOfFlights.Add(count);
            }

            UpdateMap();
        }

        private GMarkerGoogleType GetMarkerType(int numberOfFlights) {
            if (numberOfFlights == 0) {
                return GMarkerGoogleType.gray_small;
            }
            else if (numberOfFlights <= 500) {
                return GMarkerGoogleType.red_small;
            }
            else if (numberOfFlights <= 1000) {
                return GMarkerGoogleType.green_dot;
            }
            else {
                return GMarkerGoogleType.orange_dot;
            }
        }

        private void UpdateMap() {
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            for (int i = 0; i < this.airports.Count; i++) {
                DAL.DTO.AirportDTO airport = this.airports[i];
                int flightCount = this.numberOfFlights[i];

                GMarkerGoogle marker = new GMarkerGoogle(
                    new PointLatLng(airport.Latitude, airport.Longitude),
                    GetMarkerType(flightCount)
                );

                marker.ToolTipText = $"\n{airport.Name}\nNumber of flights: {flightCount}";
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

                markersOverlay.Markers.Add(marker);
            }

            this.gmap.Overlays.Add(markersOverlay);
        }

    }
}
