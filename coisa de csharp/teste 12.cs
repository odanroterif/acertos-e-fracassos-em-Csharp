using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------
namespace teste_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            int[] age = new int[5];
            float plus = 0;
            float[,] note = new float[5, 3];
            float[] results = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite seu nome: ");
                students[i] = Console.ReadLine();
                Console.Write("\ndiga sua idade: ");
                age[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        Console.Write(j + 1 + "º nota: ");
                        note[i, j] = float.Parse(Console.ReadLine());
                        Console.Clear();
                        if (note[i, j] < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("ESSA NOTA NÃO É VALIDAO\n\n");
                        }
                    } while (note[i, j] < 0 && note[i, j] > 10);
                    plus += note[i, j];
                }
                results[i] = plus / 3;
                plus = 0;
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\nAluno " + (i + 1) + ": " + students[i]);
                Console.WriteLine("idade: " + age[i]);
                Console.WriteLine("notas: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(note[i, j] + "|");
                }
                Console.WriteLine("média: " + results[i]);
                if (results[i] >= 7)
                {
                    Console.WriteLine("ALUNO APROVADO");
                }
                if (results[i] < 7 && results[i] >= 5)
                {
                    Console.WriteLine("ALUNO EM RECUPERAÇÃO");
                }
                if (results[i] < 5)
                {
                    Console.WriteLine("ALUNO REPROVADO");
                }
            }
        }
    }
}
