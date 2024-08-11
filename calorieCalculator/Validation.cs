using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calorieCalculator
{
    internal class Validation
    {
        internal bool isNumber(string num) {
            try
            {
                bool isNumber = double.TryParse(num, out double number);
                return isNumber;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        
    }
}
