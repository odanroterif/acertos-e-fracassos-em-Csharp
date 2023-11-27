using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace tarefa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int i;
            int blankspace = 0;

            do
            {
                Console.WriteLine("ESCREVA UM TEXTO COM 50 CARACTERES\n");
                text = Console.ReadLine();
                if (text.Length > 50)
                {
                    Console.Clear();
                    Console.WriteLine("LIMITE DE 50 CARACTERES ULTRAPASSADO\n\n");
                }
            } while (text.Length > 50);
            Console.Clear();
            for (i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    blankspace++;
                }
            }
            text = text.Replace(" ", ""); //.Replace: substitui um elemento espeficio da string
            {

            }
            Console.WriteLine("seu texto antes tinha " + blankspace + " espaços em branco");
            Console.WriteLine("seu texto agora (sem espaços)\n\n" + text);
            Console.ReadLine();
        }
    }
}
