using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_17
{
    class Person
    {
        string name;
        int age;
        float[] note = new float[2];
        float results;
        static void Main(string[] args)
        {
            Person[] students = new Person[3];
            float plus = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ALUNO " + (i + 1) + "º\n");
                Console.Write("digite seu nome: ");
                students[i].name = Console.ReadLine();
                Console.Write("\nDigite sua idade: ");
                students[i].age = int.Parse(Console.ReadLine());
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        Console.Write("\nDigite sua nota: ");
                        students[i].note[j] = float.Parse(Console.ReadLine());
                        if (students[i].note[j] < 0 || students[i].note[j] > 10)
                        {
                            Console.Clear();
                            Console.WriteLine("NOTA INVALIDA\n\n");
                        }
                    } while (students[i].note[j] < 0 || students[i].note[j] > 10);
                    plus += students[i].note[j];
                }
                students[i].results = plus / 2;
                plus = 0;
                Console.Clear();
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n\n" + (i + 1) + "º ALUNO\n");
                Console.WriteLine("nome: %s" + students[i].name);
                Console.WriteLine("idade: %i" + students[i].age);
                Console.WriteLine("notas: ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(students[i].note[j] + "|");
                }
                Console.WriteLine("\nmédia: " + students[i].results);
            }
        }
    }
}
