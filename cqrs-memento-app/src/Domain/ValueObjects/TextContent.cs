public class TextContent
{
    public string Content { get; private set; }

    public TextContent(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            throw new ArgumentException("Content cannot be null or empty.", nameof(content));
        }

        Content = content;
    }
}