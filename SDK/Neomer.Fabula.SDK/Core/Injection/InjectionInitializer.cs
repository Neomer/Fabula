using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Neomer.Fabula.SDK.Core.Injection
{
    public static class InjectionInitializer
    {
        public static ContainerBuilder CreateBuilder(Assembly assembly, IServiceCollection serviceDescriptors)
        {
            var builder = new ContainerBuilder();

            builder.Populate(serviceDescriptors);

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(ComponentAttribute)))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(ServiceAttribute)))
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => !t.CustomAttributes.Any(a => a.AttributeType == typeof(NonInjectedAttribute)))
                .PropertiesAutowired();

            return builder;
        }

    }
}
