using LSCode.DatabaseConnectors.DataContexts.Interfaces;
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
        /// <param name="connectionString">The connection used to open the SQLServer database.</param>
        /// <returns>Create an instance of the SQLServerContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public SQLServerContext(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
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