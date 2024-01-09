using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = String.Empty;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradePercentage <= 93 && gradePercentage >= 60)
        {
            if (gradePercentage % 10 >= 7)
            {
                letter = letter + "+";
            }
            else if (gradePercentage % 10 <= 3)
            {
                letter = letter + "-";
            }
        }
        Console.WriteLine("Your letter grade is: " + letter);
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("I'm sorry. You failed the class. But I'm sure you'll pass next time!");
        }
    }
}