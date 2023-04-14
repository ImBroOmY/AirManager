namespace AirManager {
    partial class FrmAirlines {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAirlines));
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtICAO = new System.Windows.Forms.TextBox();
            this.txtIATA = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblICAO = new System.Windows.Forms.Label();
            this.lblIATA = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(314, 75);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(224, 21);
            this.cmbCountry.TabIndex = 25;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(314, 45);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 24;
            this.lblCountry.Text = "Country";
            // 
            // txtICAO
            // 
            this.txtICAO.Location = new System.Drawing.Point(314, 155);
            this.txtICAO.Margin = new System.Windows.Forms.Padding(0);
            this.txtICAO.Name = "txtICAO";
            this.txtICAO.Size = new System.Drawing.Size(224, 20);
            this.txtICAO.TabIndex = 21;
            // 
            // txtIATA
            // 
            this.txtIATA.Location = new System.Drawing.Point(45, 155);
            this.txtIATA.Margin = new System.Windows.Forms.Padding(0);
            this.txtIATA.MaxLength = 3;
            this.txtIATA.Name = "txtIATA";
            this.txtIATA.Size = new System.Drawing.Size(224, 20);
            this.txtIATA.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 17;
            // 
            // lblICAO
            // 
            this.lblICAO.AutoSize = true;
            this.lblICAO.Location = new System.Drawing.Point(314, 125);
            this.lblICAO.Margin = new System.Windows.Forms.Padding(0);
            this.lblICAO.Name = "lblICAO";
            this.lblICAO.Size = new System.Drawing.Size(32, 13);
            this.lblICAO.TabIndex = 20;
            this.lblICAO.Text = "ICAO";
            // 
            // lblIATA
            // 
            this.lblIATA.AutoSize = true;
            this.lblIATA.Location = new System.Drawing.Point(45, 125);
            this.lblIATA.Margin = new System.Windows.Forms.Padding(0);
            this.lblIATA.Name = "lblIATA";
            this.lblIATA.Size = new System.Drawing.Size(31, 13);
            this.lblIATA.TabIndex = 18;
            this.lblIATA.Text = "IATA";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
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
            this.btnCancel.TabIndex = 31;
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
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtICAO);
            this.Controls.Add(this.txtIATA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblICAO);
            this.Controls.Add(this.lblIATA);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAirlines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AirManager - Airlines";
            this.Load += new System.EventHandler(this.FrmAirlines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtICAO;
        private System.Windows.Forms.TextBox txtIATA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblICAO;
        private System.Windows.Forms.Label lblIATA;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}