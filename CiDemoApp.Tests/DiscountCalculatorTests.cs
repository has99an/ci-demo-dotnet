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

        Assert.Equal(90, result);
    }

    [Fact]
    public void CalculateFinalPrice_WithInvalidDiscount_ThrowsArgumentException()
    {
        var calculator = new DiscountCalculator();

        Assert.Throws<ArgumentException>(() => calculator.CalculateFinalPrice(100, 120));
    }
}