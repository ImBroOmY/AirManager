namespace AirManager {
    partial class FrmAdmin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.lblHello = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnAirlines = new System.Windows.Forms.Button();
            this.btnAirports = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(117, 58);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(173, 29);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, {name}";
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(84)))));
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.Image = global::AirManager.Resources.Maps;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMap.Location = new System.Drawing.Point(472, 54);
            this.btnMap.Margin = new System.Windows.Forms.Padding(0);
            this.btnMap.Name = "btnMap";
            this.btnMap.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnMap.Size = new System.Drawing.Size(150, 40);
            this.btnMap.TabIndex = 7;
            this.btnMap.Text = "Maps";
            this.btnMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::AirManager.Resources.Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(639, 54);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(439, 350);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReservations.Size = new System.Drawing.Size(350, 75);
            this.btnReservations.TabIndex = 6;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnPassengers
            // 
            this.btnPassengers.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnPassengers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassengers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengers.ForeColor = System.Drawing.Color.White;
            this.btnPassengers.Location = new System.Drawing.Point(44, 350);
            this.btnPassengers.Margin = new System.Windows.Forms.Padding(0);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnPassengers.Size = new System.Drawing.Size(350, 75);
            this.btnPassengers.TabIndex = 5;
            this.btnPassengers.Text = "Passengers";
            this.btnPassengers.UseVisualStyleBackColor = true;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.White;
            this.btnFlights.Location = new System.Drawing.Point(439, 250);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(0);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnFlights.Size = new System.Drawing.Size(350, 75);
            this.btnFlights.TabIndex = 4;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = true;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnRoutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.White;
            this.btnRoutes.Location = new System.Drawing.Point(44, 250);
            this.btnRoutes.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnRoutes.Size = new System.Drawing.Size(350, 75);
            this.btnRoutes.TabIndex = 3;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnAirlines
            // 
            this.btnAirlines.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnAirlines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAirlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirlines.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirlines.ForeColor = System.Drawing.Color.White;
            this.btnAirlines.Location = new System.Drawing.Point(439, 150);
            this.btnAirlines.Margin = new System.Windows.Forms.Padding(0);
            this.btnAirlines.Name = "btnAirlines";
            this.btnAirlines.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAirlines.Size = new System.Drawing.Size(350, 75);
            this.btnAirlines.TabIndex = 2;
            this.btnAirlines.Text = "Airlines";
            this.btnAirlines.UseVisualStyleBackColor = true;
            this.btnAirlines.Click += new System.EventHandler(this.btnAirlines_Click);
            // 
            // btnAirports
            // 
            this.btnAirports.BackgroundImage = global::AirManager.Resources.Gradient45;
            this.btnAirports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirports.ForeColor = System.Drawing.Color.White;
            this.btnAirports.Location = new System.Drawing.Point(44, 150);
            this.btnAirports.Margin = new System.Windows.Forms.Padding(0);
            this.btnAirports.Name = "btnAirports";
            this.btnAirports.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAirports.Size = new System.Drawing.Size(350, 75);
            this.btnAirports.TabIndex = 1;
            this.btnAirports.Text = "Airports";
            this.btnAirports.UseVisualStyleBackColor = true;
            this.btnAirports.Click += new System.EventHandler(this.btnAirports_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::AirManager.Resources.LogoColor;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Location = new System.Drawing.Point(50, 50);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(45, 45);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnAirlines);
            this.Controls.Add(this.btnAirports);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirManager";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnAirports;
        private System.Windows.Forms.Button btnAirlines;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.Button btnReservations;
        public System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMap;
    }
}