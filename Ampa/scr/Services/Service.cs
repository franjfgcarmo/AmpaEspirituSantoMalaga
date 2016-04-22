using System;
using Ampa.ConnectionProvider;

namespace Ampa.Services
{
    public class Service : IDisposable
    {
        protected Connection Connection = new Connection();

        public Service()
        {
            Connection.DbOpen();
        }

        public void Dispose()
        {
            if (Connection != null)
            {
                Connection.DbClose();
            }
        }
    }
}