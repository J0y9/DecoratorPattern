namespace DecoratorPattern;

public class RawText: IText
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}