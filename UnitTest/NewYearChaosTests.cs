using System.Linq;
using Core.Exercices.NewYearChaos;
using Xunit;

namespace UnitTest;

public class NewYearChaosTests
{
    [Theory]
    [InlineData(new []{2, 1, 5, 3, 4}, "3")]
    [InlineData(new []{2, 5, 1, 3, 4}, "Too chaotic")]
    [InlineData(new []{5, 1, 2, 3, 7, 8, 6, 4}, "Too chaotic")]
    [InlineData(new []{1, 2, 5, 3, 7, 8, 6, 4}, "7")]
    public void Validate_NewYearChaos(int[] input, string expectedResult)
    {
        Assert.Equal(NewYearChaos.MinimumBribes(input.ToList()), expectedResult);
    }
    
    
}