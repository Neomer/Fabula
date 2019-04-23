using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Injection.Exceptions
{
    /// <summary>
    /// Незарегистрированный тип, помеченный как свойство для инъекции зависимости.
    /// </summary>
    public class UnknownPropertyTypeInjectionException : Exception
    {
        public UnknownPropertyTypeInjectionException(PropertyInfo propertyInfo) : 
            base(string.Format("Незарегистрированный тип {0}, помеченный как свойство для инъекции зависимости.", propertyInfo.PropertyType.ToString()))
        {

        }
    }
}
