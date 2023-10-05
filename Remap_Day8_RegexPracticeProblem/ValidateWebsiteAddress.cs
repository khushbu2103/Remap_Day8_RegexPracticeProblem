using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class ValidateWebsiteAddress
    {
        public static void ValidateWebsideAddressFormat()
        {
            string pattern = @"^(https?://)?(www\.)?[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\/\S*)?$";
            string[] input = { "https://www.example.com", "http://subdomain.example.co.uk/page", "invalid_website_address" };
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
