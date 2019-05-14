using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SRP
{
    public static class StringUtility 
    {
        public static string ConcatString(this string targetString, string sourceString)
        {
            return targetString + " " + sourceString;
        }
        

        public static string RemoveVowels(this string inputString)
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            foreach (var t in vowels)
            {
                if (inputString.Contains(t))
                {
                    inputString = inputString.Replace(t, "");
                    inputString = inputString.Replace(t.ToUpper(), "");
                }
            }

            return inputString;
        }
    }
}
