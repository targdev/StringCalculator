using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Escreva os números que deseja somar: \nObs.: Separe eles por virgulas ou espaços os números.");

            char[] delimiterChars = { ' ', ',' };
            var inputUser = Console.ReadLine();
            var userNumbers = inputUser.Split(delimiterChars);

            AddTheNumbers addNumbers = new AddTheNumbers();

            Console.WriteLine("Essa é a soma dos números: " + addNumbers.Add(userNumbers));
        }
    }
}

