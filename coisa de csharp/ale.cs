using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Random b = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = b.Next(100);
            }
            Console.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[1]);
            }
            Console.ReadLine();
        }
    }
}
