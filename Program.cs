using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DelimitersToSplit separators = new DelimitersToSplit();

            Console.Clear();
            Console.WriteLine("Escreva os números que deseja somar: \nObs.: Separe eles por virgulas ou espaços os números.");
            var inputUser = Console.ReadLine();

            separators.Delimiter(inputUser);
        }
    }
}

