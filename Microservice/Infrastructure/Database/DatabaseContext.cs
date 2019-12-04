using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Database
{
    public class DatabaseContext : IDisposable
    {
        private IConfiguration configuration;
        public DatabaseContext(IConfiguration iconfig)
        {
            configuration = iconfig;
        }

        private IDbConnection _connection;
        public IDbConnection Connection { get { return _connection ?? (_connection = CreateConnection()); } }

        private IDbConnection CreateConnection()
        {
            string ConnectionString = configuration.GetSection("MyConfiguration").GetSection("DbConnectionString").Value;
            return new SqlConnection(ConnectionString);
        }
        #region IDisposable Implementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
            }
        }

        public static explicit operator SqlConnection(DatabaseContext v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
