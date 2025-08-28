using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_Practice
{
    public class StringCalculator
    {
        public const string DELIMETER = ",";
        public int Add(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                return 0;

            var numbers = number.Split(DELIMETER, StringSplitOptions.RemoveEmptyEntries);
            return numbers.Select(number => int.Parse(number)).Sum();
        }
    }
}
