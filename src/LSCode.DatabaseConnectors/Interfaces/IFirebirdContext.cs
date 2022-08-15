using FirebirdSql.Data.FirebirdClient;
using System;

namespace LSCode.DatabaseConnectors.Interfaces
{
    /// <summary>Provides contract for implementing Firebird connections.</summary>
    public interface IFirebirdContext : IDisposable
    {
        /// <value>Represents a connection to a Firebird database.</value>
        FbConnection Connetion { get; }
    }
}