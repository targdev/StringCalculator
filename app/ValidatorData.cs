using System;
using System.Collections.Generic;
using StringCalculator.models;

namespace StringCalculator.app
{
    public class ValidatorData
    {
        public ValidatorResult Validators(List<int> numbersToValidade)
        {
            ValidatorResult result = new ValidatorResult();
            int numberMax = 999;

            foreach (var num in numbersToValidade)
            {
                if (num > numberMax)
                {
                    continue;
                }

                if (num < 0)
                {
                    result.InvalidNumbers.Add(num);
                    continue;
                }

                result.ValidNumbers.Add(num);
            }

            return result;
        }
    }
}