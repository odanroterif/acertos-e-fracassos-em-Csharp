using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace teste_16
{
    class Program
    {
        string name;
        string autor;
        string categore;
        float price;
        static void Main(string[] args)
        {
            Program[] book = new Program[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("digite o nome do " + (i + 1) + "º livro: ");
                book[i].name = Console.ReadLine();
                Console.Write("\nNome do autor: ");
                book[i].autor = Console.ReadLine();
                Console.Write("\nCategoria: ");
                book[i].categore = Console.ReadLine();
                Console.Write("\nPreço: ");
                book[i].price = float.Parse(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n\n" + (i + 1) + "º LIVRO\n");
                Console.WriteLine("\nnome: " + book[i].name);
                Console.WriteLine("\nautor: " + book[i].autor);
                Console.WriteLine("\ncategoria: " + book[i].categore);
                Console.WriteLine("\npreço: " + book[i].price);

            };
            Console.ReadLine();
        }
    }
}
