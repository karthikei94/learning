namespace cqrs_memento_app.Domain.Interfaces
{
    public interface ITextRepository
    {
        void Save(string content);
        string Retrieve();
        void SaveHistory(string content);
        IEnumerable<string> RetrieveHistory();
    }
}