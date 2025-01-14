namespace _struct;

struct UndeadMob
{
    public string Name;
    public float Health;
    public float Height;
    public string Family;
}


class _struct_
{
    static void Main(string[] args)
    {
        string[] text = new string[3];
        
        Start:
        
        Console.Write("1- esqueleto\n2- zumbi\n3- miscelleneous\n\nEscolha: ");
        var selection = int.Parse(Console.ReadLine()!);

        switch (selection)
        {
            case 1:
                UndeadMob skeleton;
                skeleton.Family = "esqueletos";
                Console.Write("\nName: ");
                skeleton.Name = Console.ReadLine()!;
                Console.Write("\nHealth: ");
                skeleton.Health = float.Parse(Console.ReadLine()!);
                Console.Write("\nHeight: ");
                skeleton.Height = float.Parse(Console.ReadLine()!);
                text[0] = $"Nome: {skeleton.Name}\nHealth: {skeleton.Health}\nHeight: {skeleton.Height}\nFamily: {skeleton.Family}";
                break;
            case 2:
                UndeadMob zombie;
                zombie.Family = "zumbis";
                Console.Write("\nName: ");
                zombie.Name = Console.ReadLine()!;
                Console.Write("\nHealth: ");
                zombie.Health = float.Parse(Console.ReadLine()!);
                Console.Write("\nHeight: ");
                zombie.Height = float.Parse(Console.ReadLine()!);
                text[1] = $"Nome: {zombie.Name}\nHealth: {zombie.Health}\nHeight: {zombie.Height}\nFamily: {zombie.Family}";
                break;
            case 3:
                UndeadMob other;
                other.Family = "miscelleneos";
                Console.Write("Name: ");
                other.Name = Console.ReadLine()!;
                Console.Write("\nHealth: ");
                other.Health = float.Parse(Console.ReadLine()!);
                Console.Write("\nHeight: ");
                other.Height = float.Parse(Console.ReadLine()!);
                text[2] = $"Nome: {other.Name}\nHealth: {other.Health}\nHeight: {other.Height}\nFamily: {other.Family}";
                break;
            default:
                goto Start;
        }
        Console.Clear();
        
        if (selection == 1)
        {
            Console.WriteLine(text[0]);
        }
        else if (selection == 2)
        {
            Console.WriteLine(text[1]);
        }
        else
        {
            Console.WriteLine(text[2]);
        }
    }
}