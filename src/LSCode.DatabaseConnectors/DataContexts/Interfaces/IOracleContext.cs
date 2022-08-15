using Oracle.ManagedDataAccess.Client;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing Oracle connections.</summary>
    public interface IOracleContext : IDisposable
    {
        /// <value>Represents a connection to a Oracle database.</value>
        OracleConnection Connetion { get; }
    }
}