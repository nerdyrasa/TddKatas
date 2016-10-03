using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKatas
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string output = String.Empty;

            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (String.IsNullOrEmpty(output))
                output = input.ToString();

            return output;
        }
    }
}
