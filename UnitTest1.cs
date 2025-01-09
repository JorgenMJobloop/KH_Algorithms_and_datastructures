namespace CS_Algoritmer;

public class UnitTest1
{

    public string HelloWorld(string message)
    {
        return message;
    }

    [Fact]
    public void Test1()
    {
        string expected = "Hello World!";
        string isEmpty = "";
        string isWhiteSpace = "   ";
        Assert.Equal("Hello World!", HelloWorld(expected));
        Assert.Empty(HelloWorld(isEmpty));
        Assert.Equal("   ", HelloWorld(isWhiteSpace));
    }
}