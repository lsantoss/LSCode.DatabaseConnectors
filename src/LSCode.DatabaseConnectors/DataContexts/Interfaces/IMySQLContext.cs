using MySql.Data.MySqlClient;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing MySQL connections.</summary>
    public interface IMySQLContext : IDisposable
    {
        /// <value>Represents a connection to a MySQL database.</value>
        MySqlConnection Connection { get; }
    }
}