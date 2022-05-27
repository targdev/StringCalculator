using System;
using System.Collections.Generic;


namespace StringCalculator
{
    public class ValidatorData
    {
        public int[] Validators(List<int> numbersToValidade)
        {
            List<string> errorMessage = new List<string>();
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
                    errorMessage.Add(numbersToValidade[i].ToString());
                }
            }

            if (errorMessage.Count > 0)
            {
                foreach (string msg in errorMessage)
                {
                    Console.WriteLine($"Números negativos não são permitidos: {msg}");
                }
            }

            return numbersToValidade.ToArray();
        }
    }
}