using binaryseach;
using System;

namespace construtor_na_classe_pai_parte_2
{
    public class creeper
    {
        //private int explode_damage = 20;
        private string name = "creeper";
        private bool cat_detector;
        public bool fear = false;

        public virtual void script(ref bool cat_detector)
        {
            string resward;

            this.cat_detector = cat_detector;
            if (this.cat_detector == false)
            {
                resward = "não";
            }
            else
            {
                resward = "sim";
            }
            if (this.cat_detector == true)
            {
                fear = true;
            }
            Console.WriteLine("nome do mob: " + name);
            Console.WriteLine("ele detectou um gato com o jogador?: " + resward);

        }
    }
    public class cat : creeper
    {
        public override void script(ref bool a)
        {
            base.script(ref a);
            if (a == true)
            {
                fear = true;
            }
            if (a == false)
            {
                Console.WriteLine("um gato não foi detectado, creeper explodiu");
            }
            else
            {
                Console.WriteLine("creeper esta com medo, creeper fugiu");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            string question;
            bool condition;
            cat existence = new cat();

        Start:
            Console.Write("Jogador tem um gato?: ");
            question = Console.ReadLine();
            Console.Clear();
            if (question == "sim" || question == "Sim")
            {
                condition = true;
            }
            else if (question == "não" || question == "Não")
            {
                condition = false;
            }
            else
            {
                goto Start;
            }
            existence.script(ref condition);
            e.exit();
        }
    }
}