using Xunit;
using System;
using System.IO;
namespace assignment00_test;

public class UnitTest1
{
    [Fact]
    public void IsLeapYearDivisibleByFourTest()
    {
        // Arrange

        bool Is_2004_LeapYear;
        bool Is_4223_LeapYear; 

        // Act

        Is_2004_LeapYear = Program.IsLeapYear(2004);
        Is_4223_LeapYear = Program.IsLeapYear(4223);

        // Assert
        
        Assert.Equal(true, Is_2004_LeapYear);
        Assert.Equal(false, Is_4223_LeapYear);
    }

    [Fact]
    public void LeapYear_RaiseException_IfBelow1582()
    {
        Assert.Throws<IOException>(() => Program.IsLeapYear(1581));
    }

	[Fact]
	public void UserInput_OutputIsCorrect() 
	{
        string Input = "2004";

        using (var sw = new StringWriter())
        {
            using (var sr = new StringReader(Input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Console.WriteLine();

                Program.UserInput();

                var result = sw.ToString().TrimStart();
                Assert.Equal("yay", result);
            }
        }
	}
}
