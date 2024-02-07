using binaryseach;
using System;

namespace eu_ver_o_que_ser_isso_depois
{
    public class status
    {
        private bool condition;

        public virtual void alivestatus(bool condition)
        {
            condition = true;

            this.condition = condition;

            Console.WriteLine(condition);

        }
    }
    public class car : status
    {

        public override void alivestatus(bool a)
        {
            Console.WriteLine(a);
        }
    }

    public class ares_atsuya : status
    {
        public override void alivestatus(bool a)
        {
            Console.WriteLine(a);
        }
    }

    public class classic_atsuya : status
    {
        public override void alivestatus(bool a)
        {
            Console.WriteLine(a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            status CAR = new car();
            status playeralive = new ares_atsuya();
            status playerdead = new classic_atsuya();
            Saida e = new Saida();

            CAR.alivestatus(false);
            playeralive.alivestatus(true);
            playerdead.alivestatus(false);
            e.exit();
        }
    }
}