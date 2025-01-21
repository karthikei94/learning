using System;
using System.Collections.Generic;
using search_algo.DesignPatterns.Behavioral;

namespace cqrs_memento_app.Infrastructure.Persistence
{
    public class TextRepository : ITextRepository
    {
        private readonly List<string> _history = new List<string>();
        private string _content;

        public void Save(string content)
        {
            _content = content;
        }

        public string Retrieve()
        {
            return _content;
        }

        public void SaveHistory(string content)
        {
            _history.Add(content);
        }

        public IEnumerable<string> RetrieveHistory()
        {
            return _history;
        }
    }
}