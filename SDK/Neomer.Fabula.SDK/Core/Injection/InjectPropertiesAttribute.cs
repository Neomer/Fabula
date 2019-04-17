using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Injection
{
    /// <summary>
    /// Класс, в котором необходимо провести инъекцию зависимостей в публичные свойства, помеченные атрибутом InjectedAttribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = true)]
    public class InjectPropertiesAttribute : Attribute
    {
    }
}
