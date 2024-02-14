using binaryseach;
using System;

namespace construtor_na_classe_pai
{
    public class banban
    {
        private float garp;

        public banban()
        {
        }
        public banban(float garp)
        {
            this.garp = garp * garp;
            if (this.garp > 8000.0f)
            {
                this.garp = 8000f;
            }
        }
        public void final()
        {
            Console.WriteLine(garp);
        }
    }
    public class garten : banban
    {
        public garten(int a)
        {
            Console.WriteLine(a);
        }
        public garten(float s) : base(s)
        {
            final();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            float noidea;

        Start:
            Console.Write("Digite: ");
            noidea = float.Parse(Console.ReadLine());
            Console.Clear();
            if (noidea > 100.0f)
            {
                goto Start;
            }

            garten of = new garten((int)noidea);
            garten five = new garten(noidea);


            e.exit();
        }
    }
}