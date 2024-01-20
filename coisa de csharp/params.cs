using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binaryseach;

namespace @params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            int[] number = new int[2];
            int increase, decrease;

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("digite o " + (i + 1) + "º número: ");
                number[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            decrease = number[0] - number[1];
            increase = number[0] + number[1];
            view(decrease, increase);
            e.exit();
        }
        //params: várias passagens sem necessitar especificar
        static void view(params int[] much)
        {
            string[] operation = { "subtração: ", "soma: " };

            for (int i = 0; i < much.Length; i++)
            {
                Console.WriteLine(operation[i] + much[i]);
            }            
        }
    }
}