using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calorieCalculator
{
    internal class Validation
    {
        internal bool isNumber(string num) { 
            double number;
            bool isNumber = double.TryParse(num, out number);
            return isNumber;
        }
    }
}
