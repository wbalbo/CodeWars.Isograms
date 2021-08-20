using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp

            //An isogram is a word that has no repeating letters, consecutive or non-consecutive.
            //Implement a function that determines whether a string that contains only letters is an isogram.
            //Assume the empty string is an isogram. Ignore letter case.

            //change the values as you wish.
            string parameter = "isogram";

            bool isIsogram = IsIsogram(parameter);
            Console.WriteLine("The word " + parameter + (isIsogram ? " is a isogram." : " isn't a isogram."));
            Console.ReadKey();
        }

        public static bool IsIsogram(string word)
        {
            if (string.IsNullOrEmpty(word))
                return true;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word.Substring(i, 1).Equals(word.Substring(j, 1), StringComparison.OrdinalIgnoreCase))
                        return false;
                }
            }

            return true;
        }
    }
}
