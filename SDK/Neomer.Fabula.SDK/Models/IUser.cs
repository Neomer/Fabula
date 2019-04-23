using System;

namespace Neomer.Fabula.SDK.Models
{
    public interface IUser : IEntity<Guid>
    {
        string Username { get; set; }
    }
}
