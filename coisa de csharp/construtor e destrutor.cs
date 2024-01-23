using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using binaryseach;

namespace construtor_e_destrutor
{
    public class hydrapple
    {
        public int life;
        public int attack;
        public int defense;
        public int sp_attack;
        public int sp_defense;
        public int speed;
        public int total;
        public hydrapple()
        {
            life = 106;
            attack = 80;
            defense = 110;
            sp_attack = 120;
            sp_defense = 80;
            speed = 44;
            total = life + attack + defense + sp_attack + sp_defense + speed;
        }
        ~hydrapple() //destrutor: antecedido de ~ destroi a classe quando não precisar mas dela
        {

        }
    }
    public class hydreigon
    {
        public int life;
        public int attack;
        public int defense;
        public int sp_attack;
        public int sp_defense;
        public int speed;
        public int total;
        public hydreigon()
        {
            life = 92;
            attack = 105;
            defense = 90;
            sp_attack = 125;
            sp_defense = 90;
            speed = 98;
            total = life + attack + defense + sp_attack + sp_defense + speed;
        }
        ~hydreigon()
        {

        }
    }
    public class Program
    {


        static void Main(string[] args)
        {
            Saida e = new Saida();
            string pokename;
            hydreigon hidreigon = new hydreigon();
            hydrapple hidrapple = new hydrapple();

        Start:
            Console.Write("escolha um pokémon dragão: ");
            pokename = Console.ReadLine();
            Console.Clear();
            if (pokename == "hydreigon" || pokename == "Hydreigon")
            {
                Console.WriteLine("ATRIBUTOS DO POKÉMON\n\n");
                Console.WriteLine("hp " + hidreigon.life);
                Console.WriteLine("ataque " + hidreigon.attack);
                Console.WriteLine("defesa " + hidreigon.defense);
                Console.WriteLine("ataque especial " + hidreigon.sp_attack);
                Console.WriteLine("defesa especial " + hidreigon.sp_defense);
                Console.WriteLine("velocidade " + hidreigon.speed);
            }
            else if (pokename == "hydrapple" || pokename == "Hydrapple")
            {
                Console.WriteLine("ATRIBUTOS DO POKÉMON\n\n");
                Console.WriteLine("hp " + hidrapple.life);
                Console.WriteLine("ataque " + hidrapple.attack);
                Console.WriteLine("defesa " + hidrapple.defense);
                Console.WriteLine("ataque especial " + hidrapple.sp_attack);
                Console.WriteLine("defesa especial " + hidrapple.sp_defense);
                Console.WriteLine("velocidade " + hidrapple.speed);
            }
            else if (pokename == "atsuya")
            {
                Console.WriteLine("acho que você confundiu com outro anime -_-");
            }
            else
            {
                Console.WriteLine("não temos " + pokename + " nessa dex no momento\n\n");
                goto Start;

            }
            e.exit();
        }
    }
}