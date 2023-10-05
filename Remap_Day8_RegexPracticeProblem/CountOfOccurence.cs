using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class CountOfOccurence
    {
        public static int CountOccurrences(string pattern, string input)
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            return matches.Count;

        }
    }
}
