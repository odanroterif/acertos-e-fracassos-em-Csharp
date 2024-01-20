using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binaryseach;

namespace @out
{
    internal class referencia
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            int[] number = new int[2];
            int increase, decrease;
            string[] operations = {"multiplicação dos números escolhidos: ",
            "subtração dos números escolhidos: ","soma dos números escolhidos: "};

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("digite o " + (i + 1) + "º número: ");
                number[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine(operations[0] + mathreturn(number, out decrease, out increase));
            Console.WriteLine(operations[1] + decrease);
            Console.WriteLine(operations[2] + increase);
            e.exit();
        }
        static int mathreturn(int[] valuer, out int minus, out int plus)
        {
            //out: faz a função retornar mas de um valor.
            int multiplication;

            multiplication = valuer[0] * valuer[1];
            minus = valuer[0] - valuer[1];
            plus = valuer[0] + valuer[1];

            return multiplication;
            //na pratica o que esta acontecendo é, return multiplication,minus,plus;
        }
    }
}