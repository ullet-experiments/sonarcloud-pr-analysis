using Dummy.Library;

namespace Library.Tests;

public class PartiallyCoveredTests
{
    [Fact]
    public void FirstCharTest()
    {
        Assert.Equal('W', PartiallyCovered.FirstChar("Word"));
    }

    [Fact]
    public void ToDoubleTest()
    {
        Assert.Equal(1.0d, PartiallyCovered.ToDouble(1));
    }

    [Fact]
    public void RepeatTest()
    {
        Assert.Equal("xxx", PartiallyCovered.Repeat('x', 3));
    }

    [Fact]
    public void CountCharsTest()
    {
        Assert.Equal(7, PartiallyCovered.CountChars("1234567"));
    }

    [Fact]
    public void ComputeBadHashTest()
    {
        Assert.Equal(42, PartiallyCovered.ComputeBadHash("Anything"));
    }
}
