using System;
public class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello World!");
    }

    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0;
    }
}
