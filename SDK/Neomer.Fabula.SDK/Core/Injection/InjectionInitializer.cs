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
            var assemblyList = new Assembly[] { assembly, typeof(InjectionInitializer).Assembly };

            var builder = new ContainerBuilder();

            builder.Populate(serviceDescriptors);

            builder.RegisterInstance(serviceDescriptors).As<IServiceCollection>();

            builder.RegisterAssemblyTypes(assemblyList)
                .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(ComponentAttribute)))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblyList)
                .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(ServiceAttribute)))
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterAssemblyTypes(assemblyList)
                .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(InjectPropertiesAttribute)))
                .AsImplementedInterfaces()
                .PropertiesAutowired();

            builder.RegisterModule(new PropertyInjectionModule());


            return builder;
        }

    }
}
