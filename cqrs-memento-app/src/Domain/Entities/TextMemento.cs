public class TextMemento
{
    public string Content { get; private set; }

    public TextMemento(string content)
    {
        Content = content;
    }
}