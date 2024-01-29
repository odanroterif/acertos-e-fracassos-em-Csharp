using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using binaryseach;

namespace sobrecargadeconstrutores
{
    internal class player
    {
        int life;
        float attack;
        bool takedamage;
        //sobrecarga de construtores: vários construtores na mesma classe
        public player(int a)
        {
            life = a;
            attack = 4.7f;
            takedamage = true;
        }
        public player(float b)
        {
            life = 100;
            attack = b;
            takedamage = true;
        }
        public player(int a, float b)
        {
            life = a;
            attack = b;
            takedamage = true;
        }
        public player(int a, float b, bool c)
        {
            life = a;
            attack = b;
            takedamage = c;
        }
        public void stats()
        {
            Console.WriteLine("health: " + life);
            Console.WriteLine("attack: " + attack);
            Console.WriteLine("dano no processo ?: " + takedamage + "\n\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();
            player player_one = new player(110, 5.2f);
            player player_two = new player(40, 9.3f, false);

            Console.WriteLine("ESTATISTICAS DE PLAYERS\n\n");
            player_one.stats();
            player_two.stats();
            e.exit();
        }
    }
}
