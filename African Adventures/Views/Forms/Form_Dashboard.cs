using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Forms
{
    public partial class frmDashboard : Form
    {
        //glabal variables for nav panel and timer
        int panelWidth;
        bool isCollapsed;
        public frmDashboard()
        {
            InitializeComponent();
            Load += Form1_Shown;
            //get navpanel width
            panelWidth = pnlnavigation.Width;
            isCollapsed = false;

           

        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlnavigation.Width += 10;
                if(pnlnavigation.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlnavigation.Width = pnlnavigation.Width - 10;
                if(pnlnavigation.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void MovesideHighlight(Control btn)
        {
            btnHighlight.Top = btn.Top;
            btnHighlight.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlDisplayContent.Controls.Clear();
            pnlDisplayContent.Controls.Add(c);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {

            MovesideHighlight(btnHome);
            Views.UserControls.UC_Schedule schedule = new Views.UserControls.UC_Schedule();
            AddControlsToPanel(schedule);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MovesideHighlight(btnBooking);
            Views.UserControls.UC_OfficeBooking officebookingpanel = new Views.UserControls.UC_OfficeBooking();          
            AddControlsToPanel(officebookingpanel);
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            MovesideHighlight(btnTrips);
            Views.UserControls.UC_Trips.UCTripManagementPanel manageTrips = new Views.UserControls.UC_Trips.UCTripManagementPanel();
            AddControlsToPanel(manageTrips);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
          //  movesideHighlight(btnPayments);
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
           // movesideHighlight(btnclients);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MovesideHighlight(btnStaff);
            Views.UserControls.UC_Staff.UCStaffPanel manageStaff = new Views.UserControls.UC_Staff.UCStaffPanel();
            AddControlsToPanel(manageStaff);
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            MovesideHighlight(btnAssets);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            MovesideHighlight(btnManage);
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
