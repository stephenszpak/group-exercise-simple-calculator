using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        string testPattern = @"\b(?<FirstNum>\d+)\s*\b(?<Operator>[\+\/\-\+\%])\s*\b(?<SecondNum>\d+)";

        public void StringSplitter (string UserInput)
        {
            Regex Regex = new Regex(testPattern);


            if (true == Regex.IsMatch(UserInput))
            {

            }
            else
            {
                Console.WriteLine("input is invalid");
            }
        }

    }
}
