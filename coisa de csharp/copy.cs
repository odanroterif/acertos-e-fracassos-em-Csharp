using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy
{
    internal class Copy
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[3];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("digite um número: ");
                a[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //a.CopyTo(b,1); <-- caso o vetor b fosse maior
            Array.Copy(a, b, a.Length);
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
