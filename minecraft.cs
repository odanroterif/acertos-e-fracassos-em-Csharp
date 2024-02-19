using binaryseach;
using System;

namespace herança_2
{
    public class Mob
    {
        private int life;
        private bool agressive;

        public void passive(int a, ref string mobname)
        {
            life = 8;
            agressive = false;

            if (life - a < life)
            {
                if (mobname == "golem de ferro")
                {
                    Console.WriteLine(mobname + " não fez nada");
                }
                else
                {
                    Console.WriteLine(mobname + " fugiu com o golpe");
                }
            }
            else
            {
                Console.WriteLine(mobname + " esta olhando para você");
            }

        }
        public void neutral(int a, ref string mobname)
        {
            life = 20;
            agressive = false;

            if (life - a < life)
            {
                agressive = true;
                if (agressive == true)
                {
                    Console.WriteLine(mobname + " esta furioso com você e esta te atacando");
                }

            }
            else
            {
                Console.WriteLine(mobname + " esta olhando para você");
            }
        }
        public void hostile(int a, ref string mobname)
        {
            life = 10;
            agressive = true;
            if (life - a < life)
            {
                Console.WriteLine(mobname + " te viu e esta te atacando, você se defendeu");
            }
            else
            {
                Console.WriteLine(mobname + " te viu e esta te atacando");
            }


        }
    }
    public class cow : Mob
    {
        private string creature_name = "Vaca";

        public string name()
        {
            return creature_name;
        }
        public void think(int a)
        {
            base.passive(a, ref creature_name);
        }
    }
    public class enderman : Mob
    {
        private string creature_name = "enderman";

        public string name()
        {
            return creature_name;
        }
        public void think(int a)
        {
            base.neutral(a, ref creature_name);
        }
    }
    public class zombi : Mob
    {
        private string creature_name = "zumbi";

        public string name()
        {
            return creature_name;
        }
        public void think(int a)
        {
            base.hostile(a, ref creature_name);
        }
    }

    public class iron_golem : Mob
    {
        private string creature_name = "golem de ferro";

        public string name()
        {
            return creature_name;
        }

        public void think(int a, bool b)
        {
            if (b == true)
            {
                base.passive(a, ref creature_name);
            }
            else
            {
                base.neutral(a, ref creature_name);
            }
        }
    }
    public class Werpon
    {
        public int damage()
        {
            return 4;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            cow creature1 = new cow();
            enderman creature2 = new enderman();
            zombi creature3 = new zombi();
            iron_golem creature4 = new iron_golem();
            Werpon wood_sword = new Werpon();
            bool creation;

        Start:
            Console.WriteLine("---INTERAÇÃO COM MOBS---");
            Console.WriteLine(creature1.name());
            Console.WriteLine(creature2.name());
            Console.WriteLine(creature3.name());
            Console.WriteLine(creature4.name());
            Console.Write("\n\nescolha um para realizar interação: ");
            string resward = Console.ReadLine().ToLower();
            Console.Clear();
            if (resward == "vaca")
            {
                do
                {
                    Console.WriteLine("quer bater nesse mob?\n");
                    resward = Console.ReadLine().ToLower();
                    Console.Clear();
                } while (resward != "sim" && resward != "não");
                if (resward == "sim")
                {
                    creature1.think(wood_sword.damage());
                }
                else
                {
                    creature1.think(0);
                }
            }
            else if (resward == "enderman")
            {
                do
                {
                    Console.WriteLine("quer bater nesse mob?\n");
                    resward = Console.ReadLine().ToLower();
                    Console.Clear();
                } while (resward != "sim" && resward != "não");
                if (resward == "sim")
                {
                    creature2.think(wood_sword.damage());
                }
                else
                {
                    creature2.think(0);
                }
            }
            else if (resward == "zumbi")
            {
                do
                {
                    Console.WriteLine("quer bater nesse mob?\n");
                    resward = Console.ReadLine().ToLower();
                    Console.Clear();
                } while (resward != "sim" && resward != "não");
                if (resward == "sim")
                {
                    creature3.think(wood_sword.damage());
                }
                else
                {
                    creature3.think(0);
                }
            }
            else if (resward == "golem de ferro")
            {
                do
                {
                    Console.WriteLine("Esse golem foi criado pelo jogador?\n");
                    resward = Console.ReadLine().ToLower();
                    if (resward == "sim")
                    {
                        creation = true;
                    }
                    else
                    {
                        creation = false;
                    }
                    Console.Clear();
                } while (resward != "sim" && resward != "não");
                do
                {
                    Console.WriteLine("quer bater nesse mob?\n");
                    resward = Console.ReadLine().ToLower();
                    Console.Clear();
                } while (resward != "sim" && resward != "não");
                if (resward == "sim")
                {
                    creature4.think(wood_sword.damage(), creation);
                }
                else
                {
                    creature4.think(0, creation);
                }
            }
            else
            {
                goto Start;
            }
            e.exit();
        }
    }
}