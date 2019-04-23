using Neomer.Fabula.SDK.Models;
using System;
using System.Collections.Generic;

namespace Neomer.Fabula.SDK.Managers
{
    public interface IEntityManager<TEntity> 
        where TEntity : IEntity<Guid>
    {
        Type EntityType { get; }

        TEntity GetById(Guid id);

        IEnumerable<TEntity> FindAll();
    }
}
