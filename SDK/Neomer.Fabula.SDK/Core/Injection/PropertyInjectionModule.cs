using Autofac;
using Autofac.Core;
using Neomer.Fabula.SDK.Core.Injection.Exceptions;
using System;
using System.Linq;
using System.Reflection;

namespace Neomer.Fabula.SDK.Core.Injection
{
    public class PropertyInjectionModule : Autofac.Module
    {
        protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
        {
            registration.Activating += BindPropertiesOnActivating;
        }

        private void BindPropertiesOnActivating(object sender, ActivatingEventArgs<object> e)
        {
            var instanceType = e.Instance.GetType();
            if (instanceType.CustomAttributes.Any(a => a.AttributeType == typeof(InjectPropertiesAttribute)))
            {
                var properties = instanceType
                    .GetProperties()
                    .Where(p => p.CanWrite && p.CustomAttributes.Any(a => a.AttributeType == typeof(InjectedAttribute)));

                foreach (var p in properties)
                {
                    var propertyType = p.PropertyType;
                    object inst = null;
                    if (e.Context.TryResolve(propertyType, out inst))
                    {
                        p.SetValue(e.Instance, inst);
                    }
                    else
                    {
                        throw new UnknownPropertyTypeInjectionException();
                    }
                }
            }
        }
    }
}
