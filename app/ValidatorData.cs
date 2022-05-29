using System;
using System.Collections.Generic;


namespace StringCalculator
{
    public class ValidatorData
    {
        public int[] Validators(List<int> numbersToValidade)
        {
            int numberMax = 999;

            for (int i = 0; i < numbersToValidade.ToArray().Length; i++)
            {

                if (String.IsNullOrEmpty(numbersToValidade[i].ToString()))
                {
                    continue;
                }

                if (Convert.ToInt32(numbersToValidade[i]) > numberMax)
                {
                    numbersToValidade[i] = 0;
                }

                if (Convert.ToInt32(numbersToValidade[i]) < 0)
                {
                    Console.WriteLine($"Números negativos não são permitidos: {numbersToValidade[i]}");
                }
            }

            return numbersToValidade.ToArray();
        }
    }
}