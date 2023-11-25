using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------
namespace teste_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("digite um número: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (number > 10)
            {
                Console.WriteLine(number + " é maior que 10");
            }
            else if (number < 10)
            {
                Console.WriteLine(number + " é menor que 10");
            }
            else
            {
                Console.WriteLine("o número digitado é 10");
            }
            Console.ReadLine();
        }
    }
}
