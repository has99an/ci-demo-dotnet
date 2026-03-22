using CiDemoApp;

var calculator = new DiscountCalculator();

decimal originalPrice = 100;
decimal discountPercent = 10;
decimal finalPrice = calculator.CalculateFinalPrice(originalPrice, discountPercent);

Console.WriteLine($"Original price: {originalPrice}");
Console.WriteLine($"Discount: {discountPercent}%");
Console.WriteLine($"Final price: {finalPrice}");