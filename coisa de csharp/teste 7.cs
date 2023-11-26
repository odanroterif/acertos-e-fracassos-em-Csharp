using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------
namespace teste_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] trash = { "batata", "alicate", "capivara", "arrayfinal" };

            //foreach = para cada (é um for melhorado para trabalhar com arrays
            //para cada i no vetor trash repita
            foreach (string i in trash)
            {
                Console.WriteLine("ah pão");
            }
            Console.WriteLine("\n\n");
            //outra forma de colocar contador no for com o comando Length (L maisculo)
            //o número inteiro do trash.Length no for equivale ao tamanho do array
            //neste momento o array é 4 então o .Length vai até 4
            for (int j = 0; j < trash.Length; j++)
            {
                Console.WriteLine("ah pão");
            }
            Console.ReadLine();
        }
    }
}
