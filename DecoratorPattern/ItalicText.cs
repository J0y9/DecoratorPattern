namespace DecoratorPattern;

public class ItalicText : IText
{
    private readonly IText _text;

    public ItalicText(IText text)
    {
        _text = text;
    }

    public void Print(string text)
    {
        var italicText = Italic(text);
        _text.Print(italicText);
    }
    private string Italic(string text)
    {
        return $"(Italic) {text}";
    }
}