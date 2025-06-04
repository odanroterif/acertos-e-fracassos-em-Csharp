using static System.Console;

namespace string_manipulation;

class Program
{
    static void Main(string[] args)
    {
        Write("Digite o nome de uma distro linux: ");
        var linux = ReadLine();
        Clear();

        WriteLine($"Escrita original: {linux}");
        WriteLine($"sem os espaços vazios no final e no inicio: {linux.Trim()}"); //trim: remove qualquer espaço em branco que exista ao inicio e ao final de uma sequência de caracteres
        WriteLine($"tamanho com espaçamento: {linux.Length}");
        WriteLine($"tamanho sem espaçamento: {linux.Trim().Length}");

        try
        {
            WriteLine($"primeira parte do nome(se for composto): {linux.Trim().Remove(linux.Trim().IndexOf(" "))}"); //remove: remove determinado número de caracteres a direita | indexof: retorna o index da primeira ocorrência de uma string especifica
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

        WriteLine($"nome trocado: {linux.Replace("ubuntu", "cachyOS \n")}"); //replace: troca uma string especificada por outra

        string[] distros = linux.Split(" ");//split: separa caracteres a partir de um caracter chave, nesse caso uma string vazia
    
        foreach (var linus in distros)
            if (linus != string.Empty)
                WriteLine(linus);
    }
}