using System;

namespace StringCalculator
{
    public class DelimitersToSplit
    {
        public void Delimiter(string inputUser)
        {
            AddTheNumbers addNumbers = new AddTheNumbers();

            string[] delimiterChars = { " ", ",", "\\n" };
            var userNumbers = inputUser.Split(delimiterChars, StringSplitOptions.None);

            Console.WriteLine("Essa é a soma dos números: " + addNumbers.Add(userNumbers));
        }
    }
}