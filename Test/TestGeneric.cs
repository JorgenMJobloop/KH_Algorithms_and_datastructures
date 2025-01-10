public class TestGeneric
{
    Generic<string> generic = new Generic<string>();

    [Fact]
    public void Should_SayHello()
    {
        string name = "John Doe";
        Assert.Equal(generic.SayHello(name), $"Hello {name}!");
    }
    [Fact]
    public void Should_SayGoodbye()
    {
        string name = "Jane Doe";
        Assert.Equal(generic.SayGoodbye(name), $"Goodbye {name}");
    }
}
