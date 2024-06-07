namespace CalculatorX.Test;
using CalculatorLib;

public class CalculatorTest
{
    private CalculatorIsNotFun _calculator;
    public CalculatorTest()
    {
        _calculator = new();
    }
    [Fact]
    public void Add_ReturnCorrectValue()
    {
        //Arrange
        int a = 3, b = 2;
        int expected = 5;

        //Act
        int result = _calculator.AddNumber(a, b);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(3,3,6)]
    public void Add_ReturnCorrectValue_UsingTheory(int a, int b, int expected)
    {
        // Act
        int result = _calculator.AddNumber(a, b);
        //Assert
        Assert.Equal(expected, result);
    }
}