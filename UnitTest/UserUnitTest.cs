using System;
using Core;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest;

public class UserUnitTest
{
    private readonly ITestOutputHelper testOutputHelper;
    public UserUnitTest(ITestOutputHelper testOutputHelper)
    { 
        this.testOutputHelper = testOutputHelper;
    }

    [Theory]
    [MemberData(nameof(UsersUnderAge))]
    public void ShouldValidateUserUnderAge(string name, DateTime birthday)
    {
        var user = new User (name, birthday);
        
        Assert.False(user.IsAdult());
    }

    [Theory]
    [MemberData(nameof(UsersAboveAge))]
    public void ShouldValidateUserAboveAge(string name, DateTime birthday)
    {
        testOutputHelper.WriteLine($"Params received: {name} {birthday}");
        
        var user = new User (name, birthday);

        Assert.True(user.IsAdult());
    }

    public static readonly object[][] UsersAboveAge =
    {
        new object[] { "Luigi", new DateTime(1996,06, 08) },
        new object[] { "Claudia", new DateTime(1996,05, 16) },
        new object[] { "Victor", new DateTime(1999,03, 11) }
    };

    public static readonly object[][] UsersUnderAge =
    {
        new object[] { "Sofia", new DateTime(2015,06, 08) },
        new object[] { "Rafael", new DateTime(2010,05, 16) },
        new object[] { "Luiz", new DateTime(2016,03, 11) }
    };
}