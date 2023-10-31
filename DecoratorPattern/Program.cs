using DecoratorPattern;
/*
 Imagine you are working on a text processing application,
  and you want to add the ability to format text with different 
  decorations(e.g., adding bold or italic styles) 
  to the text without modifying the text content itself.
   The Decorator pattern is well-suited for this scenario.
    It allows you to attach additional responsibilities to objects dynamically
 */


RawText rawText = new ();
IText text = rawText;
text.Print("hello");

BoldText bold = new (rawText);
text = bold;
text.Print("HELLO");

ItalicText italic = new(rawText);
text = italic;
text.Print("HeLLo");

var italicAndBold = new BoldText(italic);
text = italicAndBold;
text.Print("hello");