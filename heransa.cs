using System;
using binaryseach;

namespace herança
{
    public class status
    {
        private bool carstatus;

        public bool on()
        {
            carstatus = true;

            return carstatus;
        }
        public bool off()
        {
            carstatus = false;

            return carstatus;
        }
    }
    public class car : status
    {
        public void text(bool a)
        {
            if (a == false)
            {
                Console.WriteLine("carro desligado");
            }
            else
            {
                Console.WriteLine("carro ligado");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car CAR = new car();
            Saida e = new Saida();
            string direction;
            bool q;

        Start:
            Console.Write("direção: ");
            direction = Console.ReadLine();
            if (direction == "esquerda" || direction == "Esquerda")
            {
                q = CAR.off();
                CAR.text(q);
            }
            else if (direction == "direita" || direction == "Direita")
            {
                q = CAR.on();
                CAR.text(q);
            }
            else
            {
                goto Start;
            }
            e.exit();
        }
    }
}
