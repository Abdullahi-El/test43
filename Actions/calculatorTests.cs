using Xunit;

public class CalculatorTests
{
    [Fact]
    public void TestAddition()
    {
        // given
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // when
        int result = calc.Add(a, b);
    

        //then
        Assert.Equal(expectedResult, result);
    }
    






}