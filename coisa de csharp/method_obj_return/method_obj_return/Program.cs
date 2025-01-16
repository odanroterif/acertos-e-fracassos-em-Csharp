using method_obj_return.farm;


namespace method_obj_return;

class Program
{
    static void Main(string[] args)
    {
        List<Chicken> chickens = new List<Chicken>(); 
        
        Start:
        Console.Write("Diga o nome da galinha: ");
        var name = Console.ReadLine();
        Console.Write("\nOvos encontrados na cesta: ");
        var egg = int.Parse(Console.ReadLine()!);
            
        chickens.Add(new Chicken(name, egg));
        Console.Clear();
        Console.WriteLine("Deseja adicionar outra galinha? (s/n)");
        var continuation = Console.ReadLine()?.ToLower();
        Console.Clear();
            
        if (continuation == "s")
        {
            Console.Clear();
            goto Start;
        }
        Console.Clear();
        
        foreach (var item in chickens) 
            item.CreateEgg();
    }
}