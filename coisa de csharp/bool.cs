using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            string question;

            Console.Write("diga: ");
            question = Console.ReadLine();
            if (question == "sim")
            {
                answer = true;
            }
            if (question == "não")
            {
                answer = false;
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
