namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
    public void Factorial_BaseValues()
    {
        Assert.Equal(1, FactorialService.GetFactorialValueOf(0));
    }

    [Fact]
    public void Factorial_NoNegativeInput()
    {
        Assert.Throws<Exception>(() =>
        {
            FactorialService.GetFactorialValueOf(-2);
        });
    }

    [Fact]
    public void Factorial_Multiplication()
    {
        Assert.Equal(5 * 4 * 3 * 2 * 1, FactorialService.GetFactorialValueOf(5));
    }
}