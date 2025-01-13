using System.Diagnostics.CodeAnalysis;

namespace class_indexers;

class Program
{
    static void Main(string[] args)
    { 
        Random random = new Random();
        Car vehicle = new Car();
        List<float> speeds = new List<float>();


        for (int i = 0; i < vehicle.length; i++)
        {
          vehicle[i] = random.Next(0,500);
          speeds.Add(vehicle[i]);
        }
        vehicle[4] = vehicle[0] + 11;
        Console.WriteLine($"GARTEN OF BANBAN {vehicle[4]}\n\n");
        
        foreach (var item in speeds)
            if (item % 2 == 0)
                Console.WriteLine(item);
    }
}