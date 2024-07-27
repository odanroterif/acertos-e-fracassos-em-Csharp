using binaryseach;
using System;

namespace @sealed
{
    sealed class player //: piglin <--- player pode herdar piglin, mas piglin não pode herdar player
    {
        int life = 20;
        string name = "steve";
        float damage = 0.5f;
    }
    public class piglin //: player <--- nada pode inteferir em player a não ser que seja direto na classe dele
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida e = new Saida();

            Console.WriteLine("é só isso? -_-");
            e.exit();
        }
    }
}
