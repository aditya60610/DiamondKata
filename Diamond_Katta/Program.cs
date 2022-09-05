using Diamond_Kata;
using System;

namespace Diamond_Katta
{
    class Program
    {
        static void Main(string[] args)
        {
            DiamondKata _diamondKata = new DiamondKata();
            var result = _diamondKata.CreateDiamond('c');
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
