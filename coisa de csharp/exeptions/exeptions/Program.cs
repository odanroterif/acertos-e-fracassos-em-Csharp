using static System.Console;

namespace exeptions;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = new int[2];
      
        for (var c = 0; c < number.Length; c++)
        {
            try
            {
                Write($"{c + 1}॰ número: ");
                number[c] = int.Parse(ReadLine() ?? string.Empty); 
                Clear();
            }
            catch (Exception e)
            {
                Clear();
                WriteLine($"um erro aconteceu: {e.GetType().Name}, {e.Message} \ninsira um número por favor");
                c--;
            }
        }

        WriteLine(number[0] + number[1]);
        ReadKey();
    }
}