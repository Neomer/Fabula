using System;
using System.Collections.Generic;
using Neomer.Fabula.SDK.Core.Injection;
using Neomer.Fabula.SDK.Models;
using NHibernate;

namespace Neomer.Fabula.SDK.Managers
{
    public class BaseEntityManager<TEntity> : IEntityManager<TEntity>
        where TEntity : IEntity<Guid>
    {
        [Injected]
        public ISession Session { get; set; }

        public Type EntityType => typeof(TEntity);

        public IEnumerable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            return default(TEntity);
        }
    }
}
