namespace African_Adventures.Views.UserControls.UC_Booking
{
    partial class UCTripDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOBContent = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtPDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumberOfPasserngers = new System.Windows.Forms.ComboBox();
            this.cmbTypeOfTrip = new System.Windows.Forms.ComboBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cbxTypeOfBooking = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lsBallonsAvailable = new System.Windows.Forms.ListView();
            this.CN_BallonNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lsvPilotsAvailable = new System.Windows.Forms.ListView();
            this.CH_PilotName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_PilotAvailablityStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlOBContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOBContent
            // 
            this.pnlOBContent.BackColor = System.Drawing.Color.White;
            this.pnlOBContent.Controls.Add(this.groupBox1);
            this.pnlOBContent.Controls.Add(this.cmbNumberOfPasserngers);
            this.pnlOBContent.Controls.Add(this.cmbTypeOfTrip);
            this.pnlOBContent.Controls.Add(this.cbxTypeOfBooking);
            this.pnlOBContent.Controls.Add(this.label5);
            this.pnlOBContent.Controls.Add(this.label4);
            this.pnlOBContent.Controls.Add(this.label3);
            this.pnlOBContent.Controls.Add(this.button5);
            this.pnlOBContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOBContent.Location = new System.Drawing.Point(0, 0);
            this.pnlOBContent.Name = "pnlOBContent";
            this.pnlOBContent.Size = new System.Drawing.Size(693, 580);
            this.pnlOBContent.TabIndex = 2;
            this.pnlOBContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOBContent_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Check ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtPDate
            // 
            this.dtPDate.CustomFormat = "MM/dd/yyyy";
            this.dtPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPDate.Location = new System.Drawing.Point(42, 42);
            this.dtPDate.Name = "dtPDate";
            this.dtPDate.Size = new System.Drawing.Size(153, 31);
            this.dtPDate.TabIndex = 13;
            this.dtPDate.ValueChanged += new System.EventHandler(this.dtPDate_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date:";
            // 
            // cmbNumberOfPasserngers
            // 
            this.cmbNumberOfPasserngers.FormattingEnabled = true;
            this.cmbNumberOfPasserngers.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cmbNumberOfPasserngers.Location = new System.Drawing.Point(259, 374);
            this.cmbNumberOfPasserngers.Name = "cmbNumberOfPasserngers";
            this.cmbNumberOfPasserngers.Size = new System.Drawing.Size(364, 30);
            this.cmbNumberOfPasserngers.TabIndex = 11;
            // 
            // cmbTypeOfTrip
            // 
            this.cmbTypeOfTrip.FormattingEnabled = true;
            this.cmbTypeOfTrip.Items.AddRange(new object[] {
            "Two-Hour",
            "Four-Hour",
            "Whole-Day"});
            this.cmbTypeOfTrip.Location = new System.Drawing.Point(259, 337);
            this.cmbTypeOfTrip.Name = "cmbTypeOfTrip";
            this.cmbTypeOfTrip.Size = new System.Drawing.Size(364, 30);
            this.cmbTypeOfTrip.TabIndex = 10;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "hh:mm:ss";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(230, 42);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(97, 31);
            this.dtTime.TabIndex = 8;
            this.dtTime.ValueChanged += new System.EventHandler(this.dtPDate_ValueChanged);
            // 
            // cbxTypeOfBooking
            // 
            this.cbxTypeOfBooking.FormattingEnabled = true;
            this.cbxTypeOfBooking.Items.AddRange(new object[] {
            "Individual",
            "Corporate"});
            this.cbxTypeOfBooking.Location = new System.Drawing.Point(259, 298);
            this.cbxTypeOfBooking.Name = "cbxTypeOfBooking";
            this.cbxTypeOfBooking.Size = new System.Drawing.Size(364, 30);
            this.cbxTypeOfBooking.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Passengers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of Trip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Booking:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(259, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(364, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Next Step";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lsvPilotsAvailable);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 580);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lsBallonsAvailable);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 290);
            this.panel5.TabIndex = 1;
            // 
            // lsBallonsAvailable
            // 
            this.lsBallonsAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CN_BallonNumber,
            this.Status});
            this.lsBallonsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsBallonsAvailable.GridLines = true;
            this.lsBallonsAvailable.Location = new System.Drawing.Point(0, 40);
            this.lsBallonsAvailable.Name = "lsBallonsAvailable";
            this.lsBallonsAvailable.Size = new System.Drawing.Size(200, 250);
            this.lsBallonsAvailable.TabIndex = 3;
            this.lsBallonsAvailable.UseCompatibleStateImageBehavior = false;
            this.lsBallonsAvailable.View = System.Windows.Forms.View.Details;
            // 
            // CN_BallonNumber
            // 
            this.CN_BallonNumber.Text = "B Name";
            this.CN_BallonNumber.Width = 97;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 99;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 40);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ballon Availability";
            // 
            // lsvPilotsAvailable
            // 
            this.lsvPilotsAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_PilotName,
            this.CH_PilotAvailablityStatus});
            this.lsvPilotsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPilotsAvailable.GridLines = true;
            this.lsvPilotsAvailable.Location = new System.Drawing.Point(0, 40);
            this.lsvPilotsAvailable.Name = "lsvPilotsAvailable";
            this.lsvPilotsAvailable.Size = new System.Drawing.Size(200, 540);
            this.lsvPilotsAvailable.TabIndex = 2;
            this.lsvPilotsAvailable.UseCompatibleStateImageBehavior = false;
            this.lsvPilotsAvailable.View = System.Windows.Forms.View.Details;
            // 
            // CH_PilotName
            // 
            this.CH_PilotName.Text = "P Name";
            this.CH_PilotName.Width = 97;
            // 
            // CH_PilotAvailablityStatus
            // 
            this.CH_PilotAvailablityStatus.Text = "Status";
            this.CH_PilotAvailablityStatus.Width = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pilot Availability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPDate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(259, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 147);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Availability";
            // 
            // UCTripDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOBContent);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UCTripDetails";
            this.Size = new System.Drawing.Size(893, 580);
            this.pnlOBContent.ResumeLayout(false);
            this.pnlOBContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOBContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvPilotsAvailable;
        private System.Windows.Forms.ColumnHeader CH_PilotName;
        private System.Windows.Forms.ColumnHeader CH_PilotAvailablityStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lsBallonsAvailable;
        private System.Windows.Forms.ColumnHeader CN_BallonNumber;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNumberOfPasserngers;
        private System.Windows.Forms.ComboBox cmbTypeOfTrip;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cbxTypeOfBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
