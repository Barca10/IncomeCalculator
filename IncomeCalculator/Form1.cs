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
        private RateValidator _validator;
        private IncomeCalculateService _incomeCalculateService;

        public Form1(
            RateValidator RateValidator,
            IncomeCalculateService IncomeCalculateService
            )
        {
            InitializeComponent();
            this._validator = RateValidator;
            this._incomeCalculateService = IncomeCalculateService;

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

            // validate the rate
           bool IsValid = this._validator.ValidateRate(RatePerHourString);

            if (IsValid)
            {
                double RatePerHour = double.Parse(RatePerHourString);



                // get the annual income after comission
                double _annulaIncome = this._incomeCalculateService.IncomeAfterCommisionPaid(RatePerHour);

                double _incomeAfterTax = this._incomeCalculateService.IncomeAfterFederalTax(_annulaIncome);

                this.IncomeBeforeTaxLabel.Text = $"I will get before Tax{_annulaIncome}";
                this.IncomeAfterTaxLabel.Text = $"I will get after Tax {_incomeAfterTax}";
            }
            else
            {
                this.IncomeBeforeTaxLabel.Text = $"Please enter numbers only";
            }
        }
    }
}
