using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hello";
        int x = s.Length;
        int y = s.IndexOf("l");
        Console.Write(x%y);
    }
}