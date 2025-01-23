using System.Diagnostics.CodeAnalysis;

namespace _delegates;

public class BasicMath
{
    public static int Sum(params int[] number)
    {
        var sum = 0;
        for (int c = 0; c < number.Length; c++) 
            sum += number[c];
        
        return sum;
    }
    public static float Sum(params float[] number)
    {
        var sum = 0f;
        for (int c = 0; c < number.Length; c++) 
            sum += number[c];
        
        return sum;
    }

    public static int Minus(params int[] number)
    {
        return number[0] - number[1];
    }
    
    public static float Minus(params float[] number)
    {
        return number[0] - number[1];
    }

    public static int Division(params int[] number)
    {
        return number[0] / number[1];
    }

    public static float Division(params float[] number)
    {
        return number[0] / number[1];
    }

    public static int Multiplication(params int[] number)
    {
        var multiplier = number[0];
        
        for(int c = 1; c < number.Length; c++)
            multiplier *= number[c];
        
        return multiplier;
    }

    public static float Multiplication(params float[] number)
    {
        var multiplier = number[0];
        
        for(int c = 1; c < number.Length; c++)
            multiplier *= number[c];
        
        return multiplier;
    }
}