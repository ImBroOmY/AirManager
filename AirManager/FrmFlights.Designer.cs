namespace AirManager {
    partial class FrmFlights {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlights));
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.lblAirline = new System.Windows.Forms.Label();
            this.cmbAirline = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(45, 205);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(314, 125);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(45, 125);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(45, 45);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(38, 13);
            this.lblRoute.TabIndex = 0;
            this.lblRoute.Text = "Route";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(84)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(389, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(45, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbRoute
            // 
            this.cmbRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoute.BackColor = System.Drawing.Color.White;
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(45, 75);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(0);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(493, 21);
            this.cmbRoute.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(45, 155);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 22);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(314, 155);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(224, 22);
            this.dtpTime.TabIndex = 5;
            this.dtpTime.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDuration
            // 
            this.dtpDuration.CustomFormat = "HH:mm";
            this.dtpDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuration.Location = new System.Drawing.Point(45, 235);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(224, 22);
            this.dtpDuration.TabIndex = 7;
            this.dtpDuration.Value = new System.DateTime(2023, 1, 1, 1, 0, 0, 0);
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Location = new System.Drawing.Point(314, 205);
            this.lblAirline.Margin = new System.Windows.Forms.Padding(0);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(40, 13);
            this.lblAirline.TabIndex = 8;
            this.lblAirline.Text = "Airline";
            // 
            // cmbAirline
            // 
            this.cmbAirline.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAirline.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAirline.FormattingEnabled = true;
            this.cmbAirline.Location = new System.Drawing.Point(314, 235);
            this.cmbAirline.Name = "cmbAirline";
            this.cmbAirline.Size = new System.Drawing.Size(224, 21);
            this.cmbAirline.TabIndex = 9;
            // 
            // FrmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cmbAirline);
            this.Controls.Add(this.dtpDuration);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.lblAirline);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AirManager - Flights";
            this.Load += new System.EventHandler(this.FrmFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDuration;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.ComboBox cmbAirline;
    }
}