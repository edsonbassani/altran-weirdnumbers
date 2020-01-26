using System;

namespace WeirdNumbers.Businness
{
    public static class Validation
    {
        
        public static string EvalNumber(string param)
        {
            bool res;
            res = int.TryParse(param, out _);

            if (!res)
                return "Booooom!!!!";
            else
               return GetDivisors(int.Parse(param));
        }

        private static string GetDivisors(int number)
        {
            int contador = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    contador += i;

                    if (contador > number)
                    {
                        string output = String.Format("Weird Number: {0}", contador);
                        return output;
                    }
                }
            }

            if (contador <= number)
                return "Not an Weird Number";

            return "";
        }
    }
}
