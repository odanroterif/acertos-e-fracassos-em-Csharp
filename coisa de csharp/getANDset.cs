using binaryseach;
using System;

namespace getANDset
{
    public class mob_sound
    {
        private string sound;

        public string mob_name
        {
            get { return sound; }
            set
            {
                switch (value)
                {
                    case "creeper":
                        sound = "tsss...";
                        break;
                    case "enderman":
                        sound = "hello";
                        break;
                    default:
                        sound = "......";
                        break;
                }
            }

        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Saida e = new Saida();
            mob_sound search = new mob_sound();

            Console.Write("nome do mob: ");
            string resward = Console.ReadLine().ToLower();
            search.mob_name = resward;
            Console.Clear();
            Console.WriteLine(search.mob_name);
            e.exit();
        }
    }
}
