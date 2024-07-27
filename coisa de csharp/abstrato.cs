using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using binaryseach;

namespace abtracted
{
    abstract public class the_end
    {
        protected bool dragon_alieve;

        abstract public void win(bool dragon_alive);        
    }
    public class credits : the_end
    {
        final text = new final();

        public override void win(bool dragon_alive)
        {
            this.dragon_alieve = dragon_alive;
            if (this.dragon_alieve == true)
            {
                text.Text();
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }

    }
     public class final
    {
        public void Text()
        {
            Console.WriteLine("Ele cria mundos que não têm verão e estremecem sob um sol negro," +
                "e então ele " +" leva sua triste criação para a realidade. Para curá-lo da tristeza podemos" 
                +" destruí-lo. A tr" +"isteza é parte do seu próprio desafio. Não podemos interferir.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();            
            credits credits = new credits();
            
            Start:
            Console.WriteLine("Ender Dragon morreu?\n");
            string resward = Console.ReadLine().ToLower();
            Console.Clear();
            switch (resward)
            {
                case "sim":
                    bool evidence = true; 
                    credits.win(evidence);
                    break;
                case "não":
                    evidence = false;
                    credits.win(evidence);
                    break;
                default:
                    goto Start;
            }
            e.exit();
        }
    }
}
