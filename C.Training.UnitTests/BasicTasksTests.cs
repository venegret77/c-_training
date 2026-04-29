namespace C.Training.UnitTests;

public class BasicTasksTests
{
    [Fact]
    public void SayHello_ShouldReturnCorrectString()
    {
        var result = BasicTasks.SayHello();

        Assert.Equal("Привет, я учу C#!", result);
    }

    [Fact]
    public void FormatPerson_ShouldFormatCorrectly()
    {
        var result = BasicTasks.FormatPerson("Михаил", 25);

        Assert.Equal("Меня зовут Михаил, мне 25", result);
    }

    [Fact]
    public void Sum_ShouldReturnCorrectSum()
    {
        var result = BasicTasks.Sum(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Square_ShouldReturnCorrectSquare()
    {
        var result = BasicTasks.Square(4);

        Assert.Equal(16, result);
    }

    [Fact]
    public void IsEven_ShouldReturnTrue_ForEven()
    {
        var result = BasicTasks.IsEven(4);

        Assert.True(result);
    }

    [Fact]
    public void IsEven_ShouldReturnFalse_ForOdd()
    {
        var result = BasicTasks.IsEven(5);

        Assert.False(result);
    }

    [Fact]
    public void SumToN_ShouldWorkCorrectly()
    {
        var result = BasicTasks.SumToN(5);

        Assert.Equal(15, result); // 1+2+3+4+5
    }
}