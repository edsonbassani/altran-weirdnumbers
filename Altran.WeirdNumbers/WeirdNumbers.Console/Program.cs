using System;
using WeirdNumbers.Businness;

namespace WeirdNumbers
{
    class Program
    {
        static void Main()
        {
            CheckInput();
        }

        static void CheckInput()
        {
            Console.WriteLine("Input Number:");
            var input = Console.ReadLine();
            var output = Validation.EvalNumber(input);
            Console.WriteLine(output);
        }

    }
}
