using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------
namespace teste_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            int[] negativeANDimps = { 0, 0 };
            int[] maxORmin = { 0, 999 };
            int[] count = { 0, 0 };
            float[] results = new float[2];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("digite o " + (i + 1) + "º número: ");
                number[i] = int.Parse(Console.ReadLine());
                count[0] += number[i];
                if (number[i] % 2 == 0)
                {
                    count[1] += number[i];
                }
                if (number[i] % 2 != 0)
                {
                    negativeANDimps[0]++;
                }
                if (number[i] < 0)
                {
                    negativeANDimps[1]++;
                }
                if (number[i] > maxORmin[0])
                {
                    maxORmin[0] = number[i];
                }
                if (number[i] < maxORmin[1])
                {
                    maxORmin[1] = number[i];
                }
                if (number[i] == maxORmin[0] && number[i] == maxORmin[1])
                {
                    maxORmin[0] = number[i];
                    maxORmin[1] = number[i];
                }
                Console.Clear();
            }
            results[0] = count[0] / 5;
            results[1] = count[1] / 5;
            Console.WriteLine("quantidade de impares: " + negativeANDimps[0]);
            Console.WriteLine("quantidade de negativos: " + negativeANDimps[1]);
            Console.WriteLine("maior número: " + maxORmin[0]);
            Console.WriteLine("menor número: " + maxORmin[1]);
            Console.WriteLine("média de pares: " + results[1]);
            Console.WriteLine("média geral: " + results[0]);
        }
    }
}
