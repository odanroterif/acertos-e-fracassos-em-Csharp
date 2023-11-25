using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------
namespace tarefa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minstock;
            int maxstock;
            float stock;

            Console.Write("digite o estoque minimo: ");
            minstock = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("digite o estoque máximo: ");
            maxstock = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            stock = (maxstock + minstock) / 2f;
            Console.WriteLine("o estoque médio atual é de " + stock);
            Console.ReadLine();
        }
    }
}
