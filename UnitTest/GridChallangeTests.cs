using System.Linq;
using Core.Exercices.GridChallenge;
using Xunit;

namespace UnitTest;

public class GridChallangeTests
{
    [Theory]
    [InlineData(new []{"eabcd", "fghij","olkmn","trpqs","xywuv"}, "YES")]
    [InlineData(new []{"abc","lmp","qrt"}, "YES")]
    [InlineData(new []{"mpxz","abcd","wlmf"}, "NO")]
    [InlineData(new []{"abc","hjk","mpq","rtv"}, "YES")]
    public void Validate_GridChallengeCalc(string[] input, string expectedResult)
    {
        Assert.Equal(GridChallenge.Calculate(input.ToList()), expectedResult);
    }
}