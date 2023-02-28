using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts.Contexts
{
    /// <summary>Provides implementation of Oracle connections.</summary>
    public class OracleContext : IOracleContext
    {
        /// <value>Represents a connection to a Oracle database.</value>
        public OracleConnection Connection { get; private set; }

        /// <summary>OracleContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the Oracle database.</param>
        /// <returns>Create an instance of the OracleContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public OracleContext(string connectionString)
        {
            Connection = new OracleConnection(connectionString);
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