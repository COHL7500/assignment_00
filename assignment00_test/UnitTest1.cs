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
	public void IsUserInputOutputCorrectTest() 
	{
		// Arrange
		string Input = "2004";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(Input);
        Console.SetIn(stringReader);

		// Act
        Program.UserInput();

		// Assert
        var output = stringWriter.ToString().TrimEnd();
		Assert.Equal("yay", output);
	}
}
