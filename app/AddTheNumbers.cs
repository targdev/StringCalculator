using System;

namespace StringCalculator
{
    public class AddTheNumbers
    {
        public string Add(string[] numbers)
        {
            int defaultNum = 0;

            foreach (var num in numbers)
            {
                if (num == " " || num == String.Empty) { continue; }


                defaultNum += Convert.ToInt32(num);
            }

            return defaultNum.ToString();
        }
    }
}