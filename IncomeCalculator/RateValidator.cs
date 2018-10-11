using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IncomeCalculator
{
   public class RateValidator
    {
        public bool ValidateRate(string input)
        {
            
            // Regex _regex = new Regex(@"/^\d+\.?\d*$/");
            decimal value;
            if(Decimal.TryParse(input, out value) && !string.IsNullOrEmpty(input)  && !string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }
    }
}
