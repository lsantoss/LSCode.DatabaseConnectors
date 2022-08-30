using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of MySQL connections.</summary>
    public class MySQLContext : IMySQLContext
    {
        /// <value>Represents a connection to a MySQL database.</value>
        public MySqlConnection Connection { get; private set; }

        /// <summary>MySQLContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the MySQL database.</param>
        /// <returns>Create an instance of the MySQLContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public MySQLContext(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
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