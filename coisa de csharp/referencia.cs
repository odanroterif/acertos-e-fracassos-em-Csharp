using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binaryseach;

namespace passagem_de_referencia
{
    internal class referencia
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            int[] number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("digite um " + (i + 1) + "º número: ");
                number[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //ref = usa o mesmo endereço de variavel em outras funções, impedindo criação de
            //varias variaveis de checagem em casos desnecessários, ajudando a economizar memoria
            mathreturn(ref number); 
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            e.exit();

        }
        static void mathreturn(ref int[] product)
        {
            for (int i = 0; i < product.Length; i++)
            {
                product[i] = product[i] *= 2;
            }
        }
    }
}
