using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------
namespace teste_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            int[] age = new int[5];
            float[] wight = new float[5];
            float[] hight = new float[5];
            int[] minORmaxage = { 999, 0 };
            float[] minORmax = { 999, 0, 0, 999 };

            for (int i = 0; i < 5; i++)
            {
                Console.Write("pessoa" + (i + 1) + "diga seu nome: ");
                name[i] = Console.ReadLine();
                Console.Write("\ndiga sua idade: ");
                age[i] = int.Parse(Console.ReadLine());
                if (age[i] > minORmaxage[1])
                {
                    minORmaxage[1] = age[i];
                }
                if (age[i] < minORmaxage[0])
                {
                    minORmaxage[0] = age[i];
                }
                if (age[i] == minORmax[0] && age[i] == minORmax[1])
                {
                    minORmaxage[0] = age[i];
                    minORmaxage[1] = age[i];
                }
                Console.Write("\ndiga sua altura: ");
                hight[i] = float.Parse(Console.ReadLine());
                if (hight[i] > minORmax[1])
                {
                    minORmax[1] = hight[i];
                }
                if (hight[i] < minORmax[0])
                {
                    minORmax[0] = hight[i];
                }
                if (hight[i] == minORmax[0] && hight[i] == minORmax[1])
                {
                    minORmax[0] = hight[i];
                    minORmax[1] = hight[i];
                }
                Console.Write("\ndiga seu peso: ");
                wight[i] = float.Parse(Console.ReadLine());
                if (wight[i] > minORmax[2])
                {
                    minORmax[2] = wight[i];
                }
                if (wight[i] < minORmax[3])
                {
                    minORmax[3] = wight[i];
                }
                if (hight[i] == minORmax[0] && hight[i] == minORmax[1])
                {
                    minORmax[0] = wight[i];
                    minORmax[1] = wight[i];
                }
                Console.Clear();
            }
            Console.WriteLine("menor idade do grupo: " + minORmaxage[0]);
            Console.WriteLine("maior idade do grupo: " + minORmaxage[1]);
            Console.WriteLine("menor altura do grupo: " + minORmax[0]);
            Console.WriteLine("maior altura do grupo: " + minORmax[1]);
            Console.WriteLine("menor peso do grupo: " + minORmax[3]);
            Console.WriteLine("maior peso do grupo: " + minORmax[2]);
            Console.ReadLine();
        }
    }
}
