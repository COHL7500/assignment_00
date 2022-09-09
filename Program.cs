namespace assignment_00;

public static class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello World!");
    }
    public static bool IsLeapYear(int year)
    {
        if(year < 1582) 
        {
            throw new ArgumentOutOfRangeException(nameof(year), "Value must be equal or above 1582!");
        }
        
        return year % 4 == 0;
    }

    public static void UserInput()
    {
        string? yearInput = Console.ReadLine();
        
        if(string.IsNullOrEmpty(yearInput))
        {
            return;
        }

        if (int.TryParse(yearInput, out int year))
        {
            Console.Write(IsLeapYear(year) ? "yay" : "nay");
            return;
        }

        Console.WriteLine("Cannot convert input to int.\nPlease provide a number");
    }
}
