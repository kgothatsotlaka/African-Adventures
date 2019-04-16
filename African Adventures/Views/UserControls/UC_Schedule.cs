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
    public partial class UC_Schedule : UserControl
    {
        private List<FlowLayoutPanel> listDays = new List<FlowLayoutPanel>();
        private DateTime _currentDate = DateTime.Today;
        public UC_Schedule()
        {
            InitializeComponent();


            GenerateDayPanel(35);
            
            DisplayCurrentDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void GenerateDayPanel(int totalDays)
        {
           pnlCalenderbody.Controls.Clear();
          
            for (int i = 1; i <= totalDays; i++)
            {
                FlowLayoutPanel dayBlock = new FlowLayoutPanel();
                dayBlock.Name = $"flDay{i}";
                dayBlock.Size = new Size(134, 95);
                dayBlock.BackColor = Color.White;
                dayBlock.BorderStyle = BorderStyle.FixedSingle;
                pnlCalenderbody.Controls.Add(dayBlock);
                listDays.Add(dayBlock);

                

            }

        }
        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
           foreach (FlowLayoutPanel block in listDays)
           {
               block.Controls.Clear();
               block.Tag = 0;
               block.BackColor = Color.White;
           }
            
           for (int i = 1; i <= totalDaysInMonth; i++)
           {
               Label lbl = new Label();
               lbl.Name = $"lblDay{i}";
               lbl.AutoSize = false;
               lbl.TextAlign = ContentAlignment.MiddleRight;
               lbl.Size = new Size(134, 25);
               lbl.Text = i.ToString();
               lbl.ForeColor = panel1.BackColor;
               lbl.Font = new Font("Century Gothic",12);

               listDays[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
               listDays[(i - 1)+ (startDayAtFlNumber - 1)].Controls.Add(lbl);

               if (new DateTime(_currentDate.Year, _currentDate.Month, i) == DateTime.Today)
               {
                   listDays[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
               }
                     
                     
           }
        }
       private void DisplayCurrentDate()
        {
            lblCurrentDate.Text = _currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();
         
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            // AddAppointmentToFlDay(firstDayAtFlNumber);

        }
        private void PrevMonth()
        {
            _currentDate = _currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void NextMonth()
        {
            _currentDate = _currentDate.AddMonths(1);
            DisplayCurrentDate();
        }
        private void Today()
        {
            _currentDate = DateTime.Today;
            DisplayCurrentDate();
        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek);


        }

        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfCurrentDate = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day;

           
        }
        private void pnlCalenderbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Today();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void PnlWeekDays_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
