using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace teste_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number;

            //byte: de 0 a 255
            //short: 32mil positivo e negativo
            //ushor: de 0 a 65mil //quando inicia com u desconsidera números negativos
            //unit: 0 a 4.2B
            //ulong: 0 a 18 quintilhões
            //long: 9.2 quintilhão negativo e positivo, acima ou abaixo disso gera overflow
            Console.Write("digite um número: ");
            number = Convert.ToInt64(Console.ReadLine());//convert.TO: deixa argumento nulo passar
            Console.Clear();
            //int: 2.1 bilhão negativo e positivo, acima ou abaixo disso gera overflow
            Console.Write("digite um número: ");
            number = int.Parse(Console.ReadLine());/*.parse: mas seguro por gerar exeção em caso de
            Argumento nulo*/
            Console.ReadLine();
        }
    }
}
