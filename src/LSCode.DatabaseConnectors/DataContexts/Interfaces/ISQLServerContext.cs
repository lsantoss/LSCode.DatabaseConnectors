using System;
using System.Data.SqlClient;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing SQLServer connections.</summary>
    public interface ISQLServerContext : IDisposable
    {
        /// <value>Represents a connection to a SQLServer database.</value>
        SqlConnection Connetion { get; }
    }
}