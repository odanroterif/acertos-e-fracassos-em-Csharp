using static System.Console;

namespace _namespace
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            WriteLine(_another_namespace.Program.Foo());
        }
    }
}

// é possivel reutilizar os mesmos nomes de classes variaveis e funções se eles estiverem em outro namespace
namespace _another_namespace
{
    class Program
    {
        // ReSharper disable once UnusedMember.Local
        public static string Foo() => "outro Program de outro namespace";
    }
}