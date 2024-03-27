using System;

namespace Git_gyak_teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írj be egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            Console.Write("Output: ");
            for (int i = 0; i <= szam; i++)
            {
                Console.Write(i + ",");
            }
        }
    }
}
