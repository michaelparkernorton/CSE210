using System;
using System.Text.Json;
using System.Text.Json.Serialization;


class Program
{
    static void Main(string[] args)
    {
    try
    {
    int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
    }
}