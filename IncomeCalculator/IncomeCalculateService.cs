using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCalculator
{
   public class IncomeCalculateService
    {
        public int HoursWorkedPerDay = 8;

        public int NumberOfDaysWorked = 261;

        public decimal IncomeAfterCommisionPaid(decimal ratePerHour)
        {
            decimal _annualIncome = 0;
            //Get the income per year without taxes
            _annualIncome = ratePerHour * HoursWorkedPerDay * NumberOfDaysWorked;

            _annualIncome = ((_annualIncome * Rates.ConsultantRate)/100);

            return _annualIncome;

        }
    }
}
