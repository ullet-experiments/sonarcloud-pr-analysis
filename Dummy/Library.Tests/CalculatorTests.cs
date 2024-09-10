using Dummy.Library;

namespace Library.Tests;

public class CalculatorTests
{
    [Fact]
    public void OneAddOneIsTwo()
    {
        Assert.Equal(2, Calculator.Add(1, 1));
    }
}
