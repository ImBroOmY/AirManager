namespace AirManager {
    partial class FrmHome {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAirlines = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(118, 76);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(173, 29);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, {name}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upcoming flights";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(45, 215);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(749, 224);
            this.dataGridView.TabIndex = 3;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(84)))));
            this.btnPrintTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnPrintTicket.ForeColor = System.Drawing.Color.White;
            this.btnPrintTicket.Location = new System.Drawing.Point(674, 457);
            this.btnPrintTicket.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnPrintTicket.Size = new System.Drawing.Size(120, 25);
            this.btnPrintTicket.TabIndex = 1;
            this.btnPrintTicket.Text = "Print ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(430, 72);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAirlines
            // 
            this.btnAirlines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAirlines.BackgroundImage")));
            this.btnAirlines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAirlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirlines.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirlines.ForeColor = System.Drawing.Color.White;
            this.btnAirlines.Location = new System.Drawing.Point(590, 71);
            this.btnAirlines.Margin = new System.Windows.Forms.Padding(0);
            this.btnAirlines.Name = "btnAirlines";
            this.btnAirlines.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAirlines.Size = new System.Drawing.Size(200, 40);
            this.btnAirlines.TabIndex = 1;
            this.btnAirlines.Text = "Book a flight";
            this.btnAirlines.UseVisualStyleBackColor = true;
            this.btnAirlines.Click += new System.EventHandler(this.btnAirlines_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Location = new System.Drawing.Point(51, 68);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(45, 45);
            this.imgLogo.TabIndex = 8;
            this.imgLogo.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAirlines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirManager";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAirlines;
        public System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox imgLogo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.Button btnLogout;
    }
}