using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of PostgreSQLContext connections.</summary>
    public class PostgreSQLContext : IPostgreSQLContext
    {
        /// <value>Represents a connection to a PostgreSQL database.</value>
        public NpgsqlConnection Connetion { get; private set; }

        /// <summary>PostgreSQLContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the PostgreSQLContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public PostgreSQLContext(IConfiguration configuration)
        {
            Connetion = new NpgsqlConnection(configuration[KeyNames.ConnectionStringPostgreSQL]);
            Connetion.Open();
        }

        /// <summary>Closes connections used by the current class.</summary>
        /// <exception cref="Exception">Error closing used connections</exception>
        public void Dispose()
        {
            if (Connetion.State != ConnectionState.Closed)
                Connetion.Close();
        }
    }
}