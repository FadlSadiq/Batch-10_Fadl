namespace Calculator.Test;
using CalculatorLib;

public class Tests
{
    private CalculatorIsNotFun _calculator;
    private Person _person;
    [SetUp]
    public void Setup()
    {
        _calculator = new CalculatorIsNotFun();
        _person = new Person();

    }
    [Test]
    // public void Add_ReturnCorrectValue()
    // {
    //     //AAA
    //     // Arrange
    //     int a = 2;
    //     int b = 4;
    //     int expectated = 6;
    //     int expectated1 = 8;
    //     // Action
    //     int result = calculator.AddNumber(a,b);
    //     int result1 = calculator.MultiplyNumber(a,b);
    //     // Assert : memastikan hasilnya sama
    //     Assert.AreEqual(expectated, result);
    //     Assert.AreEqual(expectated1, result1);
    // }
    // public void Multiply_ReturnCorrectValue()
    // {
    //     //AAA
    //     // Arrange
    //     int a = 2;
    //     int b = 4;
    //     int expectated1 = 8;
    //     // Action
    //     int result1 = calculator.MultiplyNumber(a,b);
    //     // Assert : memastikan hasilnya sama
    //     Assert.AreEqual(expectated1, result1);
    // }

    // [TestCase(1,3,4)]
    // [TestCase(7,8,15)]
    // [TestCase(45,25,70)]
    // public void Add_ReturnCorrectValue_UsingTestCase(int a, int b, int expectated)
    // {
    //     int result = calculator.AddNumber(a,b);
    //     int result1 = calculator.MultiplyNumber(a,b);

    //     Assert.AreEqual(expectated, result);
    // }

    // [TestCase(1,3,3)]
    // [TestCase(7,8,56)]
    // public void Multiply_ReturnCorrectValue_UsingTestCase(int a, int b, int expectated)
    // {
    //     int result = calculator.MultiplyNumber(a,b);

    //     Assert.AreEqual(expectated, result);
    // }
    // public void Reverse_ReturnReverseString()
    // {
    //     //AAA
    //     // Arrange
    //     string a = "abcde";
    //     string expectated = "edcba";
    //     // Action
    //     string result = _calculator.Reverse(a);
    //     // Assert : memastikan hasilnya sama
    //     Assert.AreEqual(expectated, result);
    // }
    // [TestCase("abcde", "edcba")]
    // public void Reverse_ReturnCorrectValue_UsingTestCase(string a,string expectated)
    // {
    //     string result = _calculator.Reverse(a);
    //     Assert.AreEqual(expectated, result);
    // }
    // [TestCase(" ", "aaaa")]
    // public void Reverse1_ReturnCorrectValue_UsingTestCase(string a,string expectated)
    // {
    //     string result = _calculator.Reverse(a);
    //     Assert.AreEqual(expectated, result);
    // }
    public void GetFullName_WhenCalledWithValidPerson_ReturnFullName()
    {
        //Arrange
        var juned = new Person() { FirstName = "Junaidi", LastName = "Rico" };
        //Act
        var result = _person.GetFullName(juned);
        //Assert
        Assert.AreEqual("Junaidi Rico", result);
    }

    [Test]
    public void GetFullName_WhenCalledWithNull_ReturnNull()
    {
        //Act
        var result = _person.GetFullName(null);
        //Assert
        Assert.IsNull(result);
    }
}