using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum MyEnum
        {
            coisa,prato,café,armario,calango,pão
        }
        static void Main(string[] args)
        {
            MyEnum a = MyEnum.armario; //chamada direta
            MyEnum b = (MyEnum)4;//chamada por número do indice
            int c = (int)MyEnum.café;//pegando a string do enum e convertendo para seu valor de indice

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
