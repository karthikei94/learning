using System;
using cqrs_memento_app.Domain.Interfaces;
using cqrs_memento_app.Domain.Entities;

namespace cqrs_memento_app.Application.Commands
{
    public class SaveTextCommand : ICommand
    {
        public string Content { get; }

        public SaveTextCommand(string content)
        {
            Content = content;
        }

        public void Execute(TextService textService)
        {
            var memento = new TextMemento(Content);
            textService.Save(memento);
        }
    }
}