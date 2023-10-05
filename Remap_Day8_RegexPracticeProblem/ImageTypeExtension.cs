using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remap_Day8_RegexPracticeProblem
{
    internal class ImageTypeExtension
    {
        public static void FileNameWithImageTypeExtension()
        {
            string pattern = "^.+\\.(jpg|jpeg|png|gif)$";
            string[] fileNames = { "&image1..jpg", "image2.png", "file1.txt", "file2.docx", ".png" };
            
            foreach (string fileName in fileNames)
            {
                if (Regex.IsMatch(fileName, pattern))

                    Console.WriteLine("{0} is Valid", fileName);

                else
                    Console.WriteLine("{0} is Invalid", fileName);
                
            }
        }
    }
}
