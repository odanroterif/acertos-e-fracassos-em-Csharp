using binaryseach;
using System;

namespace herança_3
{
    public class primeiro
    {
        public int number = 1;

        public primeiro()
        {
            Console.WriteLine("\n\n" + number);
        }
    }
    public class segundo : primeiro
    {
        public segundo()
        {
            number = 2;
            Console.WriteLine(number);
        }
    }
    public class terceiro : segundo
    {
        public terceiro()
        {
            number = 3;
            Console.WriteLine(number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            terceiro sequence = new terceiro();
            Saida e = new Saida();

            e.exit();
        }
    }
}