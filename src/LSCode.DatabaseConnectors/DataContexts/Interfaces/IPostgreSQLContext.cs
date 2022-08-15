using Npgsql;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing PostgreSQL connections.</summary>
    public interface IPostgreSQLContext : IDisposable
    {
        /// <value>Represents a connection to a PostgreSQL database.</value>
        NpgsqlConnection Connetion { get; }
    }
}