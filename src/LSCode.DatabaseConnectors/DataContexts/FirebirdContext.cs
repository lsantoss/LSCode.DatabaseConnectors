using FirebirdSql.Data.FirebirdClient;
using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of FirebirdContext connections.</summary>
    public class FirebirdContext : IFirebirdContext
    {
        /// <value>Represents a connection to a Firebird database.</value>
        public FbConnection Connection { get; private set; }

        /// <summary>FirebirdContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the FirebirdContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public FirebirdContext(IConfiguration configuration)
        {
            Connection = new FbConnection(configuration[KeyNames.ConnectionStringFirebird]);
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