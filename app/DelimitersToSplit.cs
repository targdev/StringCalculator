using System;
using System.Collections.Generic;

namespace StringCalculator.app
{
    public class DelimitersToSplit
    {
        public List<int> Delimiter(string inputUser)
        {
            string[] delimiterChars = { " ", ",", ".", "...", ";", ":", "\\n", "[", "]", "//" };
            var userNumbers = inputUser.Split(delimiterChars, StringSplitOptions.None);
            List<int> listNumbers = new List<int>();

            foreach (var num in userNumbers)
            {
                if (String.IsNullOrEmpty(num))
                {
                    continue;
                }

                listNumbers.Add(Convert.ToInt32(num));
            }

            return listNumbers;
        }
    }
}