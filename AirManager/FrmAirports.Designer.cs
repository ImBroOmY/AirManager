namespace AirManager {
    partial class FrmAirports {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAirports));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIATA = new System.Windows.Forms.TextBox();
            this.txtICAO = new System.Windows.Forms.TextBox();
            this.lblIATA = new System.Windows.Forms.Label();
            this.lblICAO = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(45, 320);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(84)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(389, 320);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 50);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtIATA
            // 
            this.txtIATA.Location = new System.Drawing.Point(317, 80);
            this.txtIATA.Margin = new System.Windows.Forms.Padding(0);
            this.txtIATA.MaxLength = 3;
            this.txtIATA.Name = "txtIATA";
            this.txtIATA.Size = new System.Drawing.Size(100, 22);
            this.txtIATA.TabIndex = 3;
            // 
            // txtICAO
            // 
            this.txtICAO.Location = new System.Drawing.Point(439, 80);
            this.txtICAO.Margin = new System.Windows.Forms.Padding(0);
            this.txtICAO.Name = "txtICAO";
            this.txtICAO.Size = new System.Drawing.Size(100, 22);
            this.txtICAO.TabIndex = 5;
            // 
            // lblIATA
            // 
            this.lblIATA.AutoSize = true;
            this.lblIATA.Location = new System.Drawing.Point(317, 50);
            this.lblIATA.Margin = new System.Windows.Forms.Padding(0);
            this.lblIATA.Name = "lblIATA";
            this.lblIATA.Size = new System.Drawing.Size(28, 13);
            this.lblIATA.TabIndex = 2;
            this.lblIATA.Text = "IATA";
            // 
            // lblICAO
            // 
            this.lblICAO.AutoSize = true;
            this.lblICAO.Location = new System.Drawing.Point(439, 50);
            this.lblICAO.Margin = new System.Windows.Forms.Padding(0);
            this.lblICAO.Name = "lblICAO";
            this.lblICAO.Size = new System.Drawing.Size(33, 13);
            this.lblICAO.TabIndex = 4;
            this.lblICAO.Text = "ICAO";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(45, 160);
            this.txtCity.Margin = new System.Windows.Forms.Padding(0);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 22);
            this.txtCity.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(314, 130);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(48, 13);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(45, 130);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(314, 240);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(0);
            this.txtLongitude.MaxLength = 50;
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(224, 22);
            this.txtLongitude.TabIndex = 13;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(45, 240);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(0);
            this.txtLatitude.MaxLength = 50;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(224, 22);
            this.txtLatitude.TabIndex = 11;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(314, 210);
            this.lblLongitude.Margin = new System.Windows.Forms.Padding(0);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(60, 13);
            this.lblLongitude.TabIndex = 12;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(45, 210);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(49, 13);
            this.lblLatitude.TabIndex = 10;
            this.lblLatitude.Text = "Latitude";
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(314, 160);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(224, 21);
            this.cmbCountry.TabIndex = 9;
            // 
            // FrmAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtICAO);
            this.Controls.Add(this.txtIATA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblICAO);
            this.Controls.Add(this.lblIATA);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAirports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmAirports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIATA;
        private System.Windows.Forms.TextBox txtICAO;
        private System.Windows.Forms.Label lblIATA;
        private System.Windows.Forms.Label lblICAO;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}