using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Adventures.Views.UserControls
{
    public partial class UC_OfficeBooking : UserControl
    {
        public UC_OfficeBooking()
        {
            InitializeComponent();


            

           

        }

        private void pnlOBContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBookingSteps_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlOBContent.Controls.Clear();
            pnlOBContent.Controls.Add(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Booking.UCTripDetails TripDetailsPanel = new Views.UserControls.UC_Booking.UCTripDetails();
            addControlsToPanel(TripDetailsPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Booking.UC_InOfficeBooking.UCPassengerDetails PassengerDetailPanel = new Views.UserControls.UC_Booking.UC_InOfficeBooking.UCPassengerDetails();
            addControlsToPanel(PassengerDetailPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Views.UserControls.UC_Booking.UC_InOfficeBooking.UCPayment PassengerPaymentPanel = new Views.UserControls.UC_Booking.UC_InOfficeBooking.UCPayment();
            addControlsToPanel(PassengerPaymentPanel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Views.UserControls.UC_Booking.UC_InOfficeBooking.UCConfirmPayment PassengerConfirmBookingPanel = new Views.UserControls.UC_Booking.UC_InOfficeBooking.UCConfirmPayment();
            addControlsToPanel(PassengerConfirmBookingPanel);
        }
    }
}
