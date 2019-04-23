using System;

namespace Neomer.Fabula.SDK.Models
{
    public class Issue : BaseEntity<Guid>, IIssue
    {
        public IUser Author { get; set; }

        public IUser Executor { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
    }
}
