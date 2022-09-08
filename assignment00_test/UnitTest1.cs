using Xunit;
using System;
using System.IO;
using assignment_00;
using FluentAssertions;
namespace assignment00_test;

public class UnitTest1
{
    [Fact]
    public void IsLeapYearDivisibleByFourTest()
    {
        // Arrange

        bool is2004LeapYear;
        bool is4223LeapYear; 

        // Act

        is2004LeapYear = Program.IsLeapYear(2004);
        is4223LeapYear = Program.IsLeapYear(4223);

        // Assert
        is2004LeapYear.Should()
            .BeTrue();
        
        is4223LeapYear.Should()
            .BeFalse();
    }

    [Fact]
    public void LeapYear_RaiseException_IfBelow1582()
    {
        Action act = () => Program.IsLeapYear(1581);

        act.Should()
            .Throw<ArgumentOutOfRangeException>();
    }

	[Fact]
	public void UserInput_OutputIsCorrect() 
	{
        string input = "2004";

        using (var sw = new StringWriter())
        {
            using (var sr = new StringReader(input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.UserInput();

                var result = sw.ToString().TrimStart();
                
                result.Should()
                    .Be("yay");
            }
        }
	}
}
