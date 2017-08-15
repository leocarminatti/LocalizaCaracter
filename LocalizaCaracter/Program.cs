using System;
using System.Collections.Generic;

namespace LocalizaCaracter
{
    class Program
    {
        static void Main(string[] args)
        {

            var stream = new Stream("aAbBABacfe");
            Console.WriteLine(FirstChar(stream));
            Console.ReadLine();
        }

        public static char FirstChar(Stream input)
        {
            string vogais = "aeiouAEIOU";
            var arrayChar = new List<char>();
            var arrayFinal = new List<char>();
            char caracter;

            while (input.HasNext())
            {
                caracter = input.GetNext();

                if (arrayChar.Contains(caracter))
                    arrayChar.Remove(caracter);
                else
                    arrayChar.Add(caracter);
            }

            foreach (var item in arrayChar)
            {
                if (Contains(vogais.ToCharArray(), item))
                    arrayFinal.Add(item);
            }

            return arrayFinal[0];
        }

        private static bool Contains(char[] array, char caracter)
        {
            var retorno = false;

            foreach (var item in array)
            {
                if (item == caracter)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
    }
}
