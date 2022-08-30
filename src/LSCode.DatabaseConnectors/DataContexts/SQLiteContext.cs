using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using System;
using System.Data;
using System.Data.SQLite;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of SQLite connections.</summary>
    public class SQLiteContext : ISQLiteContext
    {
        /// <value>Represents a connection to a SQLite database.</value>
        public SQLiteConnection Connection { get; private set; }

        /// <summary>SQLiteContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the SQLite database.</param>
        /// <returns>Create an instance of the SQLiteContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public SQLiteContext(string connectionString)
        {
            Connection = new SQLiteConnection(connectionString);
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