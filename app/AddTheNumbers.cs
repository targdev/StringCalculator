using System;

namespace StringCalculator
{
    public class AddTheNumbers
    {
        public string Add(string[] numbersInString)
        {
            int defaultNum = 0;
            string noNegatives = "";

            foreach (var num in numbersInString)
            {
                if (String.IsNullOrEmpty(num)) { continue; }
                if (num[0] == '-')
                {
                    noNegatives += num;
                    return $"Números negativos não são permitidos: {noNegatives}";
                }

                defaultNum += Convert.ToInt32(num);
            }

            return defaultNum.ToString();
        }
    }
}