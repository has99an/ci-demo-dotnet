namespace CiDemoApp;

public class DiscountCalculator
{
    public decimal CalculateFinalPrice(decimal originalPrice, decimal discountPercent)
    {
        if (originalPrice < 0)
            throw new ArgumentException("Original price cannot be negative.");

        if (discountPercent < 0 || discountPercent > 100)
            throw new ArgumentException("Discount percent must be between 0 and 100.");

        decimal discountAmount = originalPrice * (discountPercent / 100);
        decimal finalPrice = originalPrice - discountAmount;

        return finalPrice;
    }
}