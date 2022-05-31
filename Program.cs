using System;

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
            var resValidators = validator.Validators(resDelimiter);
            var resAddNumbers = addNumbers.Add(resValidators);

            Console.WriteLine($"Essa é a soma dos números: {resAddNumbers}");
            Console.ReadKey();
        }
    }
}