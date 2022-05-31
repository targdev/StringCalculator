using System;
using System.Collections.Generic;

namespace StringCalculator.app
{
    public class AddTheNumbers
    {
        public string Add(List<int> numbersInString)
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