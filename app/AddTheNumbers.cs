using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class AddTheNumbers
    {
        public string Add(string[] numbersInString)
        {
            int defaultNum = 0;

            foreach (var num in numbersInString)
            {
                if (String.IsNullOrEmpty(num)) { continue; }

                {
                    if (Convert.ToInt32(num) < 0)
                    {
                        return $"Ops! Números negativos não são permitidos: {num}";
                    }
                }

                defaultNum += Convert.ToInt32(num);
            }

            return defaultNum.ToString();
        }
    }
}