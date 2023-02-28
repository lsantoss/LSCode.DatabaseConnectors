using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Npgsql;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts.Contexts
{
    /// <summary>Provides implementation of PostgreSQL connections.</summary>
    public class PostgreSQLContext : IPostgreSQLContext
    {
        /// <value>Represents a connection to a PostgreSQL database.</value>
        public NpgsqlConnection Connection { get; private set; }

        /// <summary>PostgreSQLContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the PostgreSQL database.</param>
        /// <returns>Create an instance of the PostgreSQLContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public PostgreSQLContext(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);
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