using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------
namespace teste._15
{
    class Program
    {
        string name;
        int age;
        string location;
        static void Main(string[] args)
        {
            Program person = new Program();




            Console.Write("digite seu nome: ");
            person.name = Console.ReadLine();
            Console.Write("\ndigite sua idade: ");
            person.age = int.Parse(Console.ReadLine());
            Console.Write("\ndigite seu endereço: ");
            person.location = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("EXIBINDO DADOS\n\n ");
            Console.WriteLine("nome: " + person.name);
            Console.WriteLine("idade: " + person.age);
            Console.WriteLine("endereço: " + person.location);


        }

    }
}
