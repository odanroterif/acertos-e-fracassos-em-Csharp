using method_obj_return.farm;


namespace method_obj_return;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Diga o nome da galinha: ");
        var name = Console.ReadLine();
        Console.Write("\nOvos encontrados na cesta: ");
        var egg = int.Parse(Console.ReadLine()!);
        Console.Clear();
        
        Chicken chick = new Chicken(name, egg);
        chick.CreateEgg();
    }
}