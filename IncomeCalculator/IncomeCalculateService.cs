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

        public double IncomeAfterCommisionPaid(double ratePerHour)
        {
            double _annualIncome = 0;
            //Get the income per year without taxes
            _annualIncome = ratePerHour * HoursWorkedPerDay * NumberOfDaysWorked;

            _annualIncome = ((_annualIncome * Rates.ConsultantRate)/100);

            return _annualIncome;

        }

        public double IncomeAfterFederalTax(double IncomeAfterCommission)
        {
            double _netIncomeAfterFederalTax = 0;

            if(IncomeAfterCommission < IncomeRange.FirstIncome)
            {
                _netIncomeAfterFederalTax = IncomeAfterCommission - (Rates.FirstRate * IncomeAfterCommission / 100);
            }

            else if ( IncomeAfterCommission < IncomeRange.SecondIncome)
            {
                double _firstLevel = Rates.FirstRate * IncomeRange.FirstIncome / 100;
                double _secondLevelTaxIncome = IncomeAfterCommission - _firstLevel;
                _netIncomeAfterFederalTax = _secondLevelTaxIncome * Rates.SecondRate / 100;
            }

            else if (IncomeAfterCommission < IncomeRange.ThirdIncome)
            {
                double _secondLevel = Rates.SecondRate * IncomeRange.SecondIncome / 100;
                double _thirdLevelTaxIncome = IncomeAfterCommission - _secondLevel;
                _netIncomeAfterFederalTax = _thirdLevelTaxIncome * Rates.ThirdRate / 100;
            }

            return _netIncomeAfterFederalTax;
        }
    }
}
