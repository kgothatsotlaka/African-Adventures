using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Views.UserControls.UC_Booking
{
    public partial class UCTripDetails : UserControl
    {
        public UCTripDetails()
        {
            InitializeComponent();
            dtPDate.Format = DateTimePickerFormat.Custom;
            dtPDate.CustomFormat = "MM/dd/yyyy";

        }

        private void dtPDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtPDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlOBContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
