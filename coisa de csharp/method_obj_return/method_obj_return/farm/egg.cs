namespace method_obj_return.farm;

public class Egg
{
    private string chicken_name;
    private int eggber;
    public Egg(string name,int eggber)
    {
        chicken_name = name;
        this.eggber = eggber;
        
        if (this.eggber == 1) 
            Console.WriteLine($"{chicken_name.ToUpper()} colocou {eggber} ovo.");
        else if (this.eggber <= 0)
            Console.WriteLine($"{chicken_name.ToUpper()} Nào colocou nenhum ovo.");
        else
        {
            Console.WriteLine($"{chicken_name.ToUpper()} colocou {eggber} ovos.");
        }
    }
}