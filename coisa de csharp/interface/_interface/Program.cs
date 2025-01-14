
namespace _interface;

class Program
{
    static void Main(string[] args)
    {
        var kat = new cat();
        var turtli = new turtle();
        
        Console.Write("Enter audio file: ");
        var aniudio = Console.ReadLine();

        if (aniudio == "gato")
            Console.WriteLine(kat.audio());
        else
            Console.WriteLine(turtli.audio());
    }
}