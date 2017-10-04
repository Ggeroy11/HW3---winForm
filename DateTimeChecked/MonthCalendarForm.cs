using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecked
{
    public partial class MyMonthCalendarForm : Form
    {
        public MyMonthCalendarForm()
        {
            InitializeComponent();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = e.End.DayOfWeek.ToString();
            switch (e.End.DayOfWeek) {
                case DayOfWeek.Monday:
                    textBox1.Text = "Понедельник";
                    break;
                case DayOfWeek.Tuesday:
                    textBox1.Text = "Вторник";
                    break;
                case DayOfWeek.Wednesday:
                    textBox1.Text = "Среда";
                    break;
                case DayOfWeek.Thursday:
                    textBox1.Text = "Четверг";
                    break;
                case DayOfWeek.Friday:
                    textBox1.Text = "Пятница";
                    break;
                case DayOfWeek.Saturday:
                    textBox1.Text = "Суббота";
                    break;
                case DayOfWeek.Sunday:
                    textBox1.Text = "Воскресенье";
                    break;
            }
        }
    }
}
