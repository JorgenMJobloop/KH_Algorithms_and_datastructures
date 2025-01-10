public class TestCalculator
{
    Random rand = new Random();
    Calculator calculator = new Calculator();
    [Fact]
    public void Should_AddNumbersTogether()
    {
        double a = rand.Next(1, 10);
        double b = rand.Next(1, 10);
        double sum = a + b;
        Assert.Equal(calculator.Add(a, b), sum);
    }

    [Fact]
    public void Should_SubtractNumbers()
    {
        double a = rand.Next(1, 10);
        double b = rand.Next(1, 10);
        double sum = a - b;
        Assert.Equal(calculator.Subtract(a, b), sum);
    }
    [Fact]
    public void Should_MultiplyNumbersTogether()
    {
        double a = rand.Next(1, 4);
        double b = rand.Next(1, 4);
        double sum = a * b;
        Assert.Equal(calculator.Multiply(a, b), sum);
    }
    [Fact]
    public void Should_DivideNumbers()
    {
        double a = rand.Next(1, 10);
        double b = rand.Next(1, 10);
        double sum = a / b;
        Assert.Equal(calculator.Divide(a, b), sum);
    }
}