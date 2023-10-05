using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class SequenceWithUnderScore
    {
        public static void SequenceOfLowercaseWithUnderScore()
        {
            string pattern = "^[a-z]+_[a-z]+$";
            string[] input = {"kjhg_abd", "a_abd", "hgy_aBGh", "_abhgfty"};
            foreach (string inputItem in input)
            {
                if (Regex.IsMatch(inputItem, pattern))
                    Console.WriteLine("{0} is Valid", inputItem);

                else
                    Console.WriteLine("{0} is Invalid", inputItem);
            }
        }
    }
}
