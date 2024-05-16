using System;
using Core;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest;

public class DateTimeParserUnitTest
{
    private readonly ITestOutputHelper testOutputHelper;
    public DateTimeParserUnitTest(ITestOutputHelper testOutputHelper)
    { 
        this.testOutputHelper = testOutputHelper;
    }

    [Theory]
    [InlineData(20211030, 1, 20211130)]
    public void ShouldAddMonthsToDate(int date, int months, int expected)
    {   
        var result = AddMonthsToDate(date, months);
        
        Assert.Equal(result, expected);
    }

    private static int AddMonthsToDate(int date, int months) 
    {
        var day = date % 100;
        var month = date / 100 % 100;
        var year = date / 10000;

        month += months;

        return (year * 10000) + (month * 100) + day;
    }
}