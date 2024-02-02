using binaryseach;
using System;

namespace @this
{
    public class basic
    {
        public int a;
        public int b;

        public basic(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int math()
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            basic calculator = new basic(5, 9);

            Console.WriteLine("\n\n" + calculator.math());
            e.exit();
        }
    }
}