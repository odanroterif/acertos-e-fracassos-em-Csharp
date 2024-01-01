using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            string resward;
            int count = 0;

        start:
            Console.Clear();
            Console.Write("Digite um nome: ");
            name[count] = Console.ReadLine();
            Console.WriteLine("\nDESEJA CONTINUAR?");
            resward = Console.ReadLine();
            if (resward == "sim")
            {
                count++;
                goto start;
            }
            Console.Clear();
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.ReadLine();
        }
    }
}
