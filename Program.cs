using System;

public class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello World!");
		//UserInput();
    }
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0;
    }

	public static void UserInput()
	{
		int year = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
	}
}
