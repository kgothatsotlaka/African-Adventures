using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Views.UserControls.UC_Booking.UC_InOfficeBooking
{
    public partial class UCConfirmPayment : UserControl
    {
        public UCConfirmPayment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCConfirmPayment_Load(object sender, EventArgs e)
        {
            gbxConfrimBooking.Enabled = false;
        }
    }
}
