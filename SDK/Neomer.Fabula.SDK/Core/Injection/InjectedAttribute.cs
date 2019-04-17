using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Injection
{
    /// <summary>
    /// Атрибут для свойств класса, реализации которых необходимо получить через инъекцию зависимостей.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = false)]
    public class InjectedAttribute : Attribute
    {
    }
}
