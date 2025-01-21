using System;

namespace Application.Queries
{
    public class GetTextQuery : IQuery
    {
        public Guid Id { get; set; }

        public string Execute(TextService textService)
        {
            return textService.GetTextById(Id);
        }
    }
}