namespace DecoratorPattern;

public class BoldText : IText
{
    private readonly IText _text;

    public BoldText(IText text)
    {
        _text = text;
    }

    public void Print(string text)
    {
        var boldText = Bold(text);
        _text.Print(boldText);
    }

    private string Bold(string text)
    {
        return $"(Bold) {text}";
    }
}