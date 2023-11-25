using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------
namespace teste_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = new string[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome do hospede: ");
                persons[i] = Console.ReadLine();
                Console.Clear();
            }
            Array.Sort(persons);
            //array sort: pega cada array e reordena numerica/alfabeticamente
            Console.WriteLine("LISTA DE HOSPEDES EM ORDEM ALFABEITA\n\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(persons[i]);
            }
            Console.ReadLine();
        }
    }
}
