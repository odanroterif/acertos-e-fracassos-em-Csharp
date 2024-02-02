using binaryseach;
using System;

namespace @static
{
    static public class sans
    {
        static public bool rage;
        static public int life;

        static sans()
        {
            rage = false;
            life = 5;
        }
        static public void bone(bool a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static public void bone(int b)
        {
            Console.WriteLine(rage);
            Console.WriteLine(b);
        }
        static public void bone(bool a)
        {
            Console.WriteLine(a);
            Console.WriteLine(life);
        }
        static public void bone()
        {
            Console.WriteLine(rage);
            Console.WriteLine(life);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();

            sans.rage = true;
            sans.bone();
            e.exit();
        }
    }
}