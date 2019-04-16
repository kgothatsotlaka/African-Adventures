using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Views.UserControls.UC_Staff
{
    public partial class UCStaffPanel : UserControl
    {
        public UCStaffPanel()
        {
            InitializeComponent();
        }

        private void pnlTripStaffContent_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //helper methods
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlStaffContent.Controls.Clear();
            pnlStaffContent.Controls.Add(c);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Staff.UCAuthorization authorizeUser = new Views.UserControls.UC_Staff.UCAuthorization();
            addControlsToPanel(authorizeUser);
        }

        private void btnCancelTrip_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Staff.UCModifyUser ModifyUser = new Views.UserControls.UC_Staff.UCModifyUser();
            addControlsToPanel(ModifyUser);
        }

        private void btnDeactivateUSer_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Staff.UCDiactivateUser UCDiactivateUser = new Views.UserControls.UC_Staff.UCDiactivateUser();
            addControlsToPanel(UCDiactivateUser);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Staff.UCDeleteUser UCDiactivateUser = new Views.UserControls.UC_Staff.UCDeleteUser();
            addControlsToPanel(UCDiactivateUser);
        }
    }
}
