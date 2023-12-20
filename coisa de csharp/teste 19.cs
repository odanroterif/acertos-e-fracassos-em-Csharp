using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------
namespace teste_19
{
    internal class Program
    {
        public const int fix = 3;        

        static void Main(string[] args)
        {
            float[] note = new float[fix];

            for (int i = 0; i < note.Length; i++)
            {
                do
                {
                    Console.Write("digite a " + (i + 1) + "º nota: ");
                    note[i] = float.Parse(Console.ReadLine());
                    if (note[i] < 0 || note[i] > 10)
                    {
                        Console.Clear();
                        Console.WriteLine("NOTA INVALIDA\n");
                    }
                } while (note[i] < 0 || note[i] > 10);
            }
            Console.Clear();
            Console.WriteLine("média: " + result(note));
            Console.WriteLine(condition(note));
            Console.ReadLine();
        }
        static float result(float[] a)
        {
            float math = 0;
            float results;

            for (int i = 0; i < fix; i++)
            {
                math += a[i];
            }
            results = math / fix;

            return results;
        }
        static string condition(float[] b)
        {
            string c;

            if (result(b) >= 7)
            {
                c = "\naprovado";
            }
            else
            {
                c = "\nreprovado";
            }
            return c;
        }
    }
}
