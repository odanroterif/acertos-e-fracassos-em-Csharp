using binaryseach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passagem_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Saida exit = new Saida();   

            Console.Write("digite qualquer número: ");
            number = int.Parse(Console.ReadLine()); 
            //ref = variavel referêncial, em vez de criar outro espaço na memoria altera o espaço
            //que ja existe
            valuer(ref number); 
            Console.Clear();
            Console.WriteLine("valor do número digitado dobrado para "+number);
            exit.exit();
        }
        static void valuer(ref int a)
        {
            a *= 2;
        }
    }
}
