using Xunit;
using System;
using System.IO;
using assignment_00;
using FluentAssertions;
namespace assignment00_test;

public class UnitTest1
{
    [Fact]
    public void IsLeapYear_given_2004_true_and_4223_false()
    {
        // Act
        bool is2004LeapYear = Program.IsLeapYear(2004);
        bool is4223LeapYear = Program.IsLeapYear(4223);

        // Assert
        is2004LeapYear.Should()
            .BeTrue();
        
        is4223LeapYear.Should()
            .BeFalse();
    }

    [Fact]
    public void IsLeapYear_Raises_Exception_If_Below_1582()
    {
        Action act = () => Program.IsLeapYear(1581);

        act.Should()
            .Throw<ArgumentOutOfRangeException>();
    }

	[Fact]
	public void UserInput_given_2004_outputs_yay()
    {
        // Arrange
        const string input = "2004";

        using var sw = new StringWriter();
        using var sr = new StringReader(input);

        Console.SetOut(sw);
        Console.SetIn(sr);

        // Act
        Program.UserInput();

        string result = sw.ToString().TrimStart();
                
        // Assert
        result.Should()
            .Be("yay");
    }
}
