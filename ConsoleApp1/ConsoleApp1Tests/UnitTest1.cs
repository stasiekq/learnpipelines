using Xunit;
using ConsoleApp1;

namespace ConsoleApp1Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var calculator = new Program();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
}