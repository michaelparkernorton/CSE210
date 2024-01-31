using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3,4);
        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");
        
    }
}