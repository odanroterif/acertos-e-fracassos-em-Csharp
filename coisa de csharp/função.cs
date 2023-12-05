using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgdf
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] number = new float[2];

            thefunction();
            Console.Write("digite um número: ");
            number[0] = float.Parse(Console.ReadLine());
            Console.Write("\ndigite outro número: ");
            number[1] = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("resultado: " + plus(number));
            Console.ReadLine();
        }
        static void thefunction()
        {
            Console.WriteLine("\n======================\n");
            Console.WriteLine("\tTAREFA");
            Console.WriteLine("\n======================\n");
        }
        static float plus(float[] n)
        {
            int i;
            float results;
            float math = 0;

            for (i = 0; i < 2; i++)
            {
                math += n[i];
            }

            results = math / 2;
            return results;
        }

    }
}
