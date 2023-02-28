using FirebirdSql.Data.FirebirdClient;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts.Contexts
{
    /// <summary>Provides implementation of Firebird connections.</summary>
    public class FirebirdContext : IFirebirdContext
    {
        /// <value>Represents a connection to a Firebird database.</value>
        public FbConnection Connection { get; private set; }

        /// <summary>FirebirdContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the Firebird database.</param>
        /// <returns>Create an instance of the FirebirdContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public FirebirdContext(string connectionString)
        {
            Connection = new FbConnection(connectionString);
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