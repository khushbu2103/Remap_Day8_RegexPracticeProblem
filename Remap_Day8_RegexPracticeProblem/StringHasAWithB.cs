using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class StringHasAWithB
    {
        public static void StringHasAWithTwoOrThreeB()
        {
            string pattern = "^a[b]{2,3}$";
            string[] input = { "abb", "abbb", "ab", "a", "bcc", "acbb" };
            foreach (string inputItem in input)
            {
                if(Regex.IsMatch(inputItem, pattern))
                    Console.WriteLine("{0} is Valid", inputItem);

                else
                    Console.WriteLine("{0} is Invalid", inputItem);
            }
        }
    }
}

