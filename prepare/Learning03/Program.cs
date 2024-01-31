using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction1 = new Fraction(5,2);
        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetFractionString()}");
    }
}