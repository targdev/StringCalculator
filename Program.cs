using System;
using StringCalculator.app;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTheNumbers addNumbers = new AddTheNumbers();
            DelimitersToSplit separators = new DelimitersToSplit();
            ValidatorData validator = new ValidatorData();

            Console.Clear();
            Console.WriteLine("Escreva os números que deseja somar:");
            var inputUser = Console.ReadLine();

            var resDelimiter = separators.Delimiter(inputUser);
            var validatorsResult = validator.Validators(resDelimiter);
            var resultSum = addNumbers.Add(validatorsResult.ValidNumbers);

            Console.WriteLine($"Essa é a soma dos números: {resultSum}");

            if (validatorsResult.InvalidNumbers.Count != 0)
            {
                Console.WriteLine($"Números negativos não são permitidos: {String.Join(", ", validatorsResult.InvalidNumbers)}");
            }
        }
    }
}