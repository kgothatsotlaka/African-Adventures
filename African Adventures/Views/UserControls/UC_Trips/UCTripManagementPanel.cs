using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Views.UserControls.UC_Trips
{
    public partial class UCTripManagementPanel : UserControl
    {
        public UCTripManagementPanel()
        {
            InitializeComponent();
        }

        //helper methods
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlTripManagementContent.Controls.Clear();
            pnlTripManagementContent.Controls.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pnlTripManagementContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Trips.UCCheckIn CheckInPanel = new Views.UserControls.UC_Trips.UCCheckIn();
            addControlsToPanel(CheckInPanel);
        }

        private void btnCancelTrip_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Trips.UCCancelTrip CancelTrippanel = new Views.UserControls.UC_Trips.UCCancelTrip();
            addControlsToPanel(CancelTrippanel);
        }

        private void btnPrepareTrips_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Trips.UCPrepareTrips PreparePanel = new Views.UserControls.UC_Trips.UCPrepareTrips();
            addControlsToPanel(PreparePanel);
        }
    }
}
