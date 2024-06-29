using binaryseach;
using System;


namespace @virtual
{
    public class life_solution
    {
        public virtual int life()
        {
            return 0;
        }
    }
    public class trader : life_solution
    {
        private int health = 14;
        private string Name = "vendedor ambulante";

        public string name()
        {
            return Name;
        }
        public override int life()
        {
            return health;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            trader trader = new trader();

            Console.WriteLine("criatura: " + trader.name());
            Console.WriteLine("vida: " + trader.life());           
            e.exit();
        }
    }
}
