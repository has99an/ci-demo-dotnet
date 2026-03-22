using CiDemoApp;
using Xunit;

namespace CiDemoApp.Tests;

public class DiscountCalculatorTests
{
    [Fact]
    public void CalculateFinalPrice_With10PercentDiscount_ReturnsCorrectPrice()
    {
        var calculator = new DiscountCalculator();

        decimal result = calculator.CalculateFinalPrice(100, 10);

        Assert.Equal(990, result);
    }

    [Fact]
    public void CalculateFinalPrice_With25PercentDiscount_ReturnsCorrectPrice()
    {
        var calculator = new DiscountCalculator();

        decimal result = calculator.CalculateFinalPrice(200, 25);

        Assert.Equal(150, result);
    }

    [Fact]
    public void CalculateFinalPrice_WithInvalidDiscount_ThrowsArgumentException()
    {
        var calculator = new DiscountCalculator();

        Assert.Throws<ArgumentException>(() => calculator.CalculateFinalPrice(100, 120));
    }
}