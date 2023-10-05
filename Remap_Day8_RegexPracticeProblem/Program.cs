using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program");
            Console.WriteLine("1.String has a with two or three b\n" +
                "2.Sequence of lowercase joining with underscore\n" +
                "3.Fetch all html tags from input\n" +
                "4.PreDefinedMobileFormat\n" +
                "5.Find file name with image type extension\n" +
                "6.Validate website address format");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    StringHasAWithB.StringHasAWithTwoOrThreeB();
                    break;

                case 2:
                    SequenceWithUnderScore.SequenceOfLowercaseWithUnderScore();
                    break;
                case 3:
                    FetchHTMLTags.FetchHTMLTagFromInput();
                    break;
                case 4:
                    string pattern = "fox(es)?";
                    string input = @"foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";

                    int count = CountOfOccurence.CountOccurrences(pattern, input);

                    Console.WriteLine($"There are {count} occurrences.");
                    break;
                case 5:
                    ImageTypeExtension.FileNameWithImageTypeExtension();
                    break;
                case 6:
                    ValidateWebsiteAddress.ValidateWebsideAddressFormat();
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
