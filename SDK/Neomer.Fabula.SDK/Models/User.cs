using System;

namespace Neomer.Fabula.SDK.Models
{
    public class User : BaseEntity<Guid>, IUser
    {
        public string Username { get; set; }
    }
}
