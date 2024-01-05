using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace binaryseach
{
    internal class binarysearch
    {
        static void Main(string[] args)
        {
            string[] objects = { "padaria", "gaveta", "luz" };
            int position;
            Console.Write("o que estas procurando?: ");
            string search = Console.ReadLine();
            position = Array.BinarySearch(objects, search);
            Console.Clear();
            if (position < 0)
            {
                Console.WriteLine("o que vocÊ procura não esta aqui");
            }
            else
            {
                Console.WriteLine("o item " + search + " esta na posição " + position);
            }
            Console.WriteLine("\n\n\n\npressione qualquer tecla para encerrar o programa....");
            Console.ReadKey();
        }
    }
}
