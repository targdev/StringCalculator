using System;

namespace StringCalculator
{
    public class AddTheNumbers
    {
        public string Add(int[] numbersInString)
        {
            int defaultNum = 0;

            foreach (int num in numbersInString)
            {
                defaultNum += num;
            }

            return defaultNum.ToString();
        }
    }
}