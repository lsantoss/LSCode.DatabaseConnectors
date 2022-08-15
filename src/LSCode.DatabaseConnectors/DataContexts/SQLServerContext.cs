using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of SQLServer connections.</summary>
    public class SQLServerContext : ISQLServerContext
    {
        /// <value>Represents a connection to a SQLServer database.</value>
        public SqlConnection Connection { get; private set; }

        /// <summary>SQLServerContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the SQLServerContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public SQLServerContext(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration[KeyNames.ConnectionStringSQLServer]);
            Connection.Open();
        }

        /// <summary>Closes connections used by the current class.</summary>
        /// <exception cref="Exception">Error closing used connections</exception>
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}