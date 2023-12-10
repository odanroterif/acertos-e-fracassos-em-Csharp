using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int n2 = 100;

            Console.Write("digite: ");
            n = int.Parse(Console.ReadLine());
            n = n << 2;
            n2 = n2 >> 2;
            //bitwise: << (modifica o valor para cima sempre em dobro, >>(corta pela metade)
            // o número apos os 1 reprenta o quanto vai aumetar
            //se tivesse 2 e o úsuario digitase 10 isso aconteceria 10+10= 20, 20+20=40
            Console.WriteLine(n);
            Console.WriteLine(n2);
            Console.ReadLine();
        }
    }
}
