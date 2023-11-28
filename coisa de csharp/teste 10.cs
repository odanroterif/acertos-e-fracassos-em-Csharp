using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------
namespace teste_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[999];
            int[] telephone = new int[999];
            int count = 0;
            int option;


            do
            {
                Console.WriteLine("1- CADASTRAR NOVO NÚMERO");
                Console.WriteLine("2- ENCERRAR PROGRAMA E MOSTRAR CADASTRADOS");
                Console.Write("\n\nescolha: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option != 1 && option != 2)
                {
                    Console.WriteLine("OPÇÃO INVALIDA\n\n");
                }
                switch (option)
                {
                    case 1:
                        Console.Write("digite o nome da pessoa: ");
                        name[count] = Console.ReadLine();
                        do
                        {
                            Console.Write("\nDigite o telefone da pessoa: ");
                            telephone[count] = int.Parse(Console.ReadLine());
                            if (telephone[count] < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("TELEFONE INVALIDO");
                            }
                        } while (telephone[count] < 1);
                        count++;
                        Console.Clear();
                        break;
                    case 2:
                        break;
                }
            } while (option != 2);
            Console.WriteLine("NÚMEROS QUE VOCÊ CADASTROU");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(telephone[i]);
            }
            Console.ReadLine();
        }
    }
}
