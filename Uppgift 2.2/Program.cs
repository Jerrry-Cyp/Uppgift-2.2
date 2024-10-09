using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            int hoppadeElin = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            int hoppadeAlma = int.Parse(Console.ReadLine());
            if (hoppadeElin > hoppadeAlma)
            {
                Console.WriteLine("Elin har hoppat " + (hoppadeElin - hoppadeAlma) + " meter längre än Alma.");
            }
            if (hoppadeElin < hoppadeAlma)
            {
                Console.WriteLine("Alma har hoppat " + (hoppadeAlma - hoppadeElin) + " meter längre än Elin.");
            }
        }
    }
}