public class Generic<T>
{
    public string SayHello(string name)
    {
        return $"Hello {name}!";
    }

    public string SayGoodbye(string name)
    {
        return $"Goodbye {name}";
    }
}