using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Injection
{
    [AttributeUsage(AttributeTargets.Class, 
        AllowMultiple = false, 
        Inherited = false)]
    public class ComponentAttribute : Attribute
    {
    }
}
