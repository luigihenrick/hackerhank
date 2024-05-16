using System.Linq;
using Core.Exercices.NewYearChaos;
using Core.Exercices.SuperDigit;
using Xunit;

namespace UnitTest;

public class SuperDigitTests
{
    [Theory]
    [InlineData("9875", 4, 8)]
    [InlineData("123", 3, 9)]
    [InlineData("593", 10, 8)]
    [InlineData("148", 3, 3)]
    public void Validate_SuperDigitCalc(string number, int repeat, int expectedResult)
    {
        Assert.Equal(SuperDigit.Calculate(number, repeat), expectedResult);
    }
}