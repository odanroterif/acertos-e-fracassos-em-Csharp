using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------
namespace tarefa_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameA = new string[5];
            string[] nameB = new string[8];
            int i;

            for (i = 0; i < nameA.Length; i++)
            {
                Console.Write("digite algo: ");
                nameA[i] = Console.ReadLine();
                Console.Clear();
            }
            for (i = 0; i < nameB.Length; i++)
            {
                Console.Write("digite algo denovo: ");
                nameB[i] = Console.ReadLine();
                Console.Clear();
            }
            Console.Write("elementos em comum dos 2 vetores: ");
            foreach (string elementA in nameA)
            {
                foreach (string elementB in nameB)
                {
                    if (elementA == elementB)
                    {
                        Console.Write(elementA + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
