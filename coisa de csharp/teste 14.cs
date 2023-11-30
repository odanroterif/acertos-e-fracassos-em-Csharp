using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------
namespace teste_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] productprice = { 5.12f, 800.50f, 490.57f };
            string[] productname = { "miojo", "rx5600xt 6GB", "rx580 8GB" };
            int[] size = { 500, 500, 500 };
            int[] option = new int[2];
            int buys = 0;
            //--------------------------------
            do
            {
                Console.WriteLine("1- ADICONAR AO CARRINHO UM PRODUTO");
                Console.WriteLine("2- ENCERRAR COMPRA");
                Console.Write("\n\nescolha: ");
                option[0] = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option[0] != 1 && option[0] != 2)
                {
                    Console.WriteLine("OPÇÃO INVALIDA\n\n");
                }
                switch (option[0])
                {
                    case 1:
                        Console.WriteLine("1- " + productname[1] + " por " + productprice[1] + ": " + size[0] + " sobrando");
                        Console.WriteLine("1- " + productname[0] + " por " + productprice[0] + ": " + size[1] + " sobrando");
                        Console.WriteLine("1- " + productname[2] + " por " + productprice[2] + ": " + size[2] + " sobrando");
                        Console.Write("\n\nescolha o produto: ");
                        option[1] = int.Parse(Console.ReadLine());
                        if (option[1] == 1 || option[1] == 2 || option[1] == 3)
                        {
                            if (option[1] == 1)
                            {
                                size[0]--;
                                buys++;
                            }
                            if (option[1] == 2)
                            {
                                size[1]--;
                                buys++;
                            }
                            if (option[1] == 3)
                            {
                                size[2]--;
                                buys++;
                            }
                        }

                        Console.Clear();
                        break;
                    case 2:
                        break;
                }
            } while (option[0] != 2);
            Console.WriteLine("vendas feitas: " + buys);
            Console.ReadLine();
        }
    }
}
