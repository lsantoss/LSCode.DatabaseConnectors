using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.Interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of MySQLContext connections.</summary>
    public class MySQLContext : IMySQLContext
    {
        /// <value>Represents a connection to a MySQL database.</value>
        public MySqlConnection Connetion { get; private set; }

        /// <summary>MySQLContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the MySQLContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public MySQLContext(IConfiguration configuration)
        {
            Connetion = new MySqlConnection(configuration[KeyNames.ConnectionStringMySQL]);
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