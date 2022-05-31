using System;
using System.Collections.Generic;


namespace StringCalculator
{
    public class ValidatorData
    {
        public int[] Validators(List<int> numbersToValidade)
        {
            int numberMax = 999;
            List<int> validadeNumbers = new List<int>(numbersToValidade);
            List<int> numbersNegatives = new List<int>();

            for (int i = 0; i < validadeNumbers.ToArray().Length; i++)
            {
                if (Convert.ToInt32(validadeNumbers[i]) > numberMax)
                {
                    validadeNumbers[i] = 0;
                }


                if (Convert.ToInt32(validadeNumbers[i]) < 0)
                {
                    numbersNegatives.Add(validadeNumbers[i]);
                }
            }

            if (numbersNegatives.Count != 0)
            {
                Console.WriteLine($"Números negativos não são permitidos: {String.Join(", ", numbersNegatives)}");
            }

            return validadeNumbers.ToArray();
        }
    }
}