using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class DelimitersToSplit
    {
        public List<string> Delimiter(string inputUser)
        {
            string[] delimiterChars = { " ", ",", ".", "...", ";", ":", "\\n", "[", "]", "//" };
            var userNumbers = inputUser.Split(delimiterChars, StringSplitOptions.None);
            List<string> listNumbers = new List<string>();

            foreach (var num in userNumbers)
            {
                listNumbers.Add(num);
            }

            return listNumbers;
        }
    }
}