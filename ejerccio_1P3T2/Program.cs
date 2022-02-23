using System;

namespace ejerccio_1P3T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un letra: ");
            string letra = Console.ReadLine();

            string rest = Vocales(letra);

            if (rest.Equals("vocal")) Console.WriteLine($"Es vocal");

            else if (rest.Equals("consonante")) Console.WriteLine($"Es consonante");
        }
        static string Vocales(string letrita)
        {
            string letra = letrita.ToLower();
            string rest = "";

            if (letra.Equals("a") || letra.Equals("e") || letra.Equals("i") || letra.Equals("o") || letra.Equals("u"))

                rest = "vocal";

            else rest = "consonante";

                return rest;

        }
    }
}
