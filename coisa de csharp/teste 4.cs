using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------
namespace teste_4
{
    class Program
    {
        enum positiveoption //enum: possibilidades limitadas pre-definitas
        {
            sim, SIM, Sim, sIm, siM, SiM, sIM, SIm
        }
        static void Main(string[] args)
        {
            positiveoption quest;
            string input;
            do
            {
                Console.Write("dê a sua responsta: ");
                input = Console.ReadLine();
                Console.Clear();
                if (Enum.TryParse(input, false, out quest))
                //tryparse: converte a entrada do úsuario (nomeada como input) para um valor do enum
                /*false: para não converter as letras do input e considerar letra por letra o que foi
                digitado sendo maisucula ou minuscula, caso quiera converter coloque true*/
                //out: passa o valor de input para quest CASO input corresponda a algum valor de enum
                {
                    Console.WriteLine("resposta positiva");
                }
                else if (input.ToLower() == "não" || input.ToLower() == "nao")
                {
                    Console.WriteLine("resposta negativa");
                }

            } while (input != "não" && input != "nao");

            Console.ReadLine();
        }
    }
}
