using System;

namespace StringCalculator
{
    public class AddTheNumbers
    {
        public string Add(string[] numbersInString)
        {
            int defaultNum = 0;

            foreach (var num in numbersInString)
            {
                if (num == " " || num == String.Empty) { continue; }

                defaultNum += Convert.ToInt32(num);
            }

            return defaultNum.ToString();
        }
    }
}