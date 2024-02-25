using binaryseach;
using System;

namespace @protected
{
    public class Mob
    {
        protected string mob_name;
        protected int life;

        protected string undead_condition(bool verification)
        {
            string afirmation;

            if (verification == true)
            {
                afirmation = "sim";
            }
            else
            {
                afirmation = "não";
            }

            return afirmation;
        }
        public Mob()
        {

        }

    }
    public class zombie : Mob
    {

        public zombie() : base()
        {
            mob_name = "zumbi";
            life = 10;
        }

        public void impress()
        {
            Console.WriteLine("\n\nMob: " + mob_name);
            Console.WriteLine("vida: " + life);
            Console.WriteLine("morto-vivo?: " + undead_condition(true));
        }

    }
    public class villager : Mob
    {

        public villager() : base()
        {
            mob_name = "aldeão";
            life = 18;
        }

        public void impress()
        {
            Console.WriteLine("\n\nMob: " + mob_name);
            Console.WriteLine("vida: " + life);
            Console.WriteLine("morto-vivo?: " + undead_condition(false));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            zombie creature1 = new zombie();
            villager creature2 = new villager();

            //console.WriteLine(creature1.life) <-- isso não é possivel pois life esta protegido e só
            //pode ser usado nas classes que o herdaram
            creature1.impress();
            creature2.impress();
            e.exit();
        }
    }
}