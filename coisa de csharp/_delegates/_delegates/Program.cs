namespace _delegates;

delegate float GeneralF(params float[] number);
delegate int General(params int[] number);

class Program
{
    static void Main(string[] args)
    {
        GeneralF ranky = BasicMath.Sum;
        General franky = BasicMath.Sum;
        
        var mat = ranky(45,23.2f);
        var mat2 = franky(45,11);
        
        franky = BasicMath.Multiplication;
        ranky = BasicMath.Multiplication;
        
        var mat3 = franky(23,70);
        var mat4 = ranky(12.45f,36.1f);
        
        Console.WriteLine($"{mat:N2}\n{mat2}\n{mat3}\n{mat4:N2}");
    }
}