using Autofac;
using Microsoft.AspNetCore.Mvc;
using Neomer.Fabula.SDK.Core.Injection;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Web.Core
{
    public class FbBaseWebController : Controller
    {
        public ISession Session { get; set; }

        public FbBaseWebController()
        {
            
        }

    }
}
