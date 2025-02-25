namespace input_arg;

//argumentos de entrada para o programa
class Program
{
    static void Main(string[] args)//no caso de aplicativo de console o argumento sera passado via terminal
    {
        if (args.Length > 0)
            Console.WriteLine($"{args.Length} argumentos encontrados no programa.");
        else
        {
            Console.WriteLine("Este programa não recebeu argumentos e ira operar de forma padrão");
        }
    }
}