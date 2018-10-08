using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string RatePerHourString = this.RateTextBox.Text;

            // need a validation that it is only number

            int RatePerHour = Int32.Parse(RatePerHourString);

            // To-Do: move this to new class and new method that takes hours and rate

            // make user able to pass the hours worked
            int WeeklyIncome = RatePerHour * 40;

            // multiply rate per hour with 40 hours and 4 weeks. 
            // Cannot be accurate as months can have 3 weeks and some days
            // try to find a way to get from calender
            int MonthlyIncome = RatePerHour * 40 * 4;

            int BiWeeklyIncome = RatePerHour * 80;

            int ConsultancyGets = (BiWeeklyIncome * Rates.ConsultancyRate) / 100;

            int ConsultantGets = (BiWeeklyIncome * Rates.ConsultantRate) / 100;

            this.DisplayValue.Text = $"The Consultant Gets {ConsultantGets}";
        }
    }
}
