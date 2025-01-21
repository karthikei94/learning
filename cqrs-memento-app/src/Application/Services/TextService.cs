public class TextService
{
    private readonly ITextRepository _textRepository;

    public TextService(ITextRepository textRepository)
    {
        _textRepository = textRepository;
    }

    public void SaveText(string content)
    {
        var memento = new TextMemento(content);
        _textRepository.Save(memento);
    }

    public string GetText(Guid id)
    {
        var memento = _textRepository.GetById(id);
        return memento?.Content;
    }
}