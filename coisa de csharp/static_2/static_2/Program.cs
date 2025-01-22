namespace static_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor: ");
        Upnumber.number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("quer o dobro ou o triplo deste número?");
        var aswer = Console.ReadLine();
        Console.Clear();
        
        if(aswer!.ToLower() == "dobro")
            Console.WriteLine($"o dobro do {Upnumber.number} é {Upnumber.Duo(Upnumber.number)}");
        else if(aswer.ToLower() == "triplo")
            Console.WriteLine($"o triplo de {Upnumber.number} é {Upnumber.Tri(Upnumber.number)}");
        else
        {
            Console.WriteLine("não temos esta operação");
        }
    }
}