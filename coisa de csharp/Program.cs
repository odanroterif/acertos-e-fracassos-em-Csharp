using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_2
{
    class Teste__2
    {
        static void Main(string[] args)
        {
            string color;
         //---------------------------------
            Console.Write("digite sua cor favorita: ");
            color = Console.ReadLine();
            Console.Clear(); //limpate/system("cls || clear) do C#
            Console.WriteLine("\n\na cor que você digitou foi " + color);
            Console.Read();
        }
    }
}
