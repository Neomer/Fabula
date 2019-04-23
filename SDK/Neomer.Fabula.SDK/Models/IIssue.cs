using System;

namespace Neomer.Fabula.SDK.Models
{
    public interface IIssue : IEntity<Guid>
    {
        IUser Author { get; set; }

        IUser Executor { get; set; }

        string Title { get; set; }

        string Text { get; set; }
    }
}
