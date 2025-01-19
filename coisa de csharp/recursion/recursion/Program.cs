namespace recursion;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor: ");
        var val = ulong.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.Write($"o fatorial de {val} é {Factorial(val)}");
        //Factorial("oi"); segundo exemplo de recursividade
    }
/*
    static void Factorial(string thing)
    {
        Console.Clear();
        Console.Write($"digite algo diferente de {thing}: ");
        var fac = Console.ReadLine();
        if (fac == "paralelepipedo")
        {
            Console.WriteLine("passou");
        }
        else
        {
            Factorial(fac);
        }
    }
*/
    static ulong Factorial(ulong number)
    {
        ulong fac;

        if (number < 1)
        {
            fac = 1;
        }
        else
        {
            fac = number * Factorial(number - 1);
        }

        return fac;
    }
}