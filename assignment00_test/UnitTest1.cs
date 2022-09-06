using Xunit;

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
}
