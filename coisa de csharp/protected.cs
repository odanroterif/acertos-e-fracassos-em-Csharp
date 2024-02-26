sing binaryseach;
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
    public class drowned : Mob
    {

        public drowned() : base()
        {
            mob_name = "afogado";
            life = 12;
        }

        public void impress()
        {
            Console.WriteLine("\n\nMob: " + mob_name);
            Console.WriteLine("vida: " + life);
            Console.WriteLine("morto-vivo?: " + undead_condition(true));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            zombie creature1 = new zombie();
            villager creature2 = new villager();
            drowned creature3 = new drowned();

        //console.WriteLine(creature1.life) <-- isso não é possivel pois life esta protegido e só
        //pode ser usado nas classes que o herdaram
        Start:
            Console.WriteLine("1- ZUMBI");
            Console.WriteLine("2- ALDEÃO");
            Console.WriteLine("3- AFOGADO");
            Console.Write("\n\nescolha: ");
            byte task = byte.Parse(Console.ReadLine());
            Console.Clear();
            switch (task)
            {
                case 1:
                    creature1.impress();
                    break;
                case 2:
                    creature2.impress();
                    break;
                case 3:
                    creature3.impress();
                    break;
                default:
                    goto Start;
            }
            e.exit();
        }
    }
}
