using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Neomer.Fabula.SDK.Core.Injection
{
    [Service]
    [InjectProperties]
    public class ComponentManager : IComponentManager
    {
        [Injected]
        public IServiceCollection container { get; set; }


        public IEnumerable<T> GetComponents<T>()
        {
            return null;
        }

    }
}
