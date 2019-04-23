namespace Neomer.Fabula.SDK.Models
{
    public class BaseEntity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
