using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Web.Core
{
    public class FbBaseWebController : Controller
    {

        private ISession _session;

        public FbBaseWebController(ISession session)
        {
            this._session = session;
        }

    }
}
