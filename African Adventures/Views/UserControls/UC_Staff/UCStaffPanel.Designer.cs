namespace African_Adventures.Views.UserControls.UC_Staff
{
    partial class UCStaffPanel
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
            this.pnlBookingSteps = new System.Windows.Forms.Panel();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnDeactivateUSer = new System.Windows.Forms.Button();
            this.pnlStaffContent = new System.Windows.Forms.Panel();
            this.pnlBookingSteps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBookingSteps
            // 
            this.pnlBookingSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlBookingSteps.Controls.Add(this.btnDeactivateUSer);
            this.pnlBookingSteps.Controls.Add(this.btnRemoveUser);
            this.pnlBookingSteps.Controls.Add(this.btnModifyUser);
            this.pnlBookingSteps.Controls.Add(this.panel1);
            this.pnlBookingSteps.Controls.Add(this.btnAuthorization);
            this.pnlBookingSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBookingSteps.Location = new System.Drawing.Point(0, 0);
            this.pnlBookingSteps.Name = "pnlBookingSteps";
            this.pnlBookingSteps.Size = new System.Drawing.Size(166, 580);
            this.pnlBookingSteps.TabIndex = 2;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModifyUser.FlatAppearance.BorderSize = 0;
            this.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.ForeColor = System.Drawing.Color.White;
            this.btnModifyUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyUser.Location = new System.Drawing.Point(0, 149);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(166, 40);
            this.btnModifyUser.TabIndex = 4;
            this.btnModifyUser.Text = "Modify User";
            this.btnModifyUser.UseVisualStyleBackColor = false;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 103);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Staff";
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAuthorization.FlatAppearance.BorderSize = 0;
            this.btnAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorization.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorization.ForeColor = System.Drawing.Color.White;
            this.btnAuthorization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthorization.Location = new System.Drawing.Point(0, 103);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(166, 40);
            this.btnAuthorization.TabIndex = 1;
            this.btnAuthorization.Text = "Authorization";
            this.btnAuthorization.UseVisualStyleBackColor = false;
            this.btnAuthorization.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(1, 252);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(166, 40);
            this.btnRemoveUser.TabIndex = 6;
            this.btnRemoveUser.Text = "RemoveUser";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnDeactivateUSer
            // 
            this.btnDeactivateUSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeactivateUSer.FlatAppearance.BorderSize = 0;
            this.btnDeactivateUSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivateUSer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUSer.ForeColor = System.Drawing.Color.White;
            this.btnDeactivateUSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeactivateUSer.Location = new System.Drawing.Point(0, 200);
            this.btnDeactivateUSer.Name = "btnDeactivateUSer";
            this.btnDeactivateUSer.Size = new System.Drawing.Size(166, 40);
            this.btnDeactivateUSer.TabIndex = 7;
            this.btnDeactivateUSer.Text = "Deactivate User";
            this.btnDeactivateUSer.UseVisualStyleBackColor = false;
            this.btnDeactivateUSer.Click += new System.EventHandler(this.btnDeactivateUSer_Click);
            // 
            // pnlStaffContent
            // 
            this.pnlStaffContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaffContent.Location = new System.Drawing.Point(166, 0);
            this.pnlStaffContent.Name = "pnlStaffContent";
            this.pnlStaffContent.Size = new System.Drawing.Size(827, 580);
            this.pnlStaffContent.TabIndex = 3;
            this.pnlStaffContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTripStaffContent_Paint);
            // 
            // UCStaffPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlStaffContent);
            this.Controls.Add(this.pnlBookingSteps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UCStaffPanel";
            this.Size = new System.Drawing.Size(993, 580);
            this.pnlBookingSteps.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookingSteps;
        private System.Windows.Forms.Button btnDeactivateUSer;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuthorization;
        private System.Windows.Forms.Panel pnlStaffContent;
    }
}
