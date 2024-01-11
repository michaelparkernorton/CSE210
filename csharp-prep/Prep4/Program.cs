using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int addNumber;
        List<int> numbers = new List<int>();
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            addNumber = int.Parse(Console.ReadLine());
            numbers.Add(addNumber);
        } while (addNumber != 0);
        numbers.RemoveAt(numbers.Count - 1);

        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;

        List<int> posNumbers = new List<int>();
        foreach (int number in numbers) 
        {
            if (number > 0) {
                posNumbers.Add(number);
            }
        }

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {posNumbers.Min()}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }




    }
}