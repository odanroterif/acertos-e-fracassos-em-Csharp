using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------
namespace teste_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            //try catch: se tiver um erro em vez de fechar o programa você é avisado do ocorrido
            try
            {
                Console.Write("coloque algum número: ");
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("um erro ocorreu");
            }
            Console.ReadLine();
        }
    }
}
