using static System.Console;

namespace exceptions;

internal class Program
{
    static void Main(string[] args)
    {
        var password = new[] {"adamatium123", " "};

        for (Int16 c = 0; c <= 3; c++)
        {
            try
            {
                Write($"Digite a senha correta: ");
                password[1] = ReadLine() ?? string.Empty; 
                Clear();
                
                if (password[1] != password[0])
                    throw new Exception($"senha incorreta, tentativa {c + 1}");
                else
                {
                    break;
                }
            }
            catch (Exception e)
            {
                Clear();
                WriteLine(e.Message);
            }
            finally
            {
                if (c == 3 && password[1] != password[0])
                {
                    Clear();
                    WriteLine("acesso negado");
                }
            }
        }
        
        if(password[1] == password[0])
            WriteLine("acesso permitido");
        
        
        ReadKey();
    }
}