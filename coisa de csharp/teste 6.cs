using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace teste_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] group = new string[3];
            string[,] members = new string[3, 5];
            int i, j;

            for (i = 0; i < 3; i++)
            {
                Console.Write("\n\nnome da " + (i + 1) + "º banda musical: ");
                group[i] = Console.ReadLine();
                for (j = 0; j < 5; j++)
                {
                    Console.Write("digite o nome do " + (j + 1) + "º integrante: ");
                    members[i, j] = Console.ReadLine();
                }
                Console.Clear();
            }
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("\n\nnome da " + (i + 1) + "º banda: " + group[i]);
                Console.Write("\nintegrantes: ");
                for (j = 0; j < 5; j++)
                {
                    if (members[i, j] == members[i, 4])
                    {
                        Console.Write(members[i, j] + ".");
                    }
                    else
                    {
                        Console.Write(members[i, j] + ",");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
