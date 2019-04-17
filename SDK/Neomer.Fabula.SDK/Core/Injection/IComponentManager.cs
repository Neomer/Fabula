using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Injection
{
    public interface IComponentManager
    {
        IEnumerable<T> GetComponents<T>();
    }
}
