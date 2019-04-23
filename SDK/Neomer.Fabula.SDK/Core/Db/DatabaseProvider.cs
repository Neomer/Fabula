using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Db
{
    public class DatabaseProvider
    {
        ISessionFactory sessionFactory;
        ISession currentSession;

        public DatabaseProvider()
        {

        }

        public void Initialize(string configurationFile)
        {
            sessionFactory = new Configuration()
                .Configure(configurationFile)
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            if (sessionFactory == null)
            {
                throw new Exception("Session factory not initialized!");
            }
            return sessionFactory.OpenSession();
        }

        public ISession CurrentSession
        {
            get
            {
                if (currentSession == null)
                {
                    currentSession = OpenSession();
                }
                return currentSession;
            }
        }

    }
}
