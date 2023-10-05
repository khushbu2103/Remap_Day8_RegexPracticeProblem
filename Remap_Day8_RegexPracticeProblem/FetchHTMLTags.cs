using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class FetchHTMLTags
    {
        public static void FetchHTMLTagFromInput()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p><>";
            string pattern = "<[^>]*>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
