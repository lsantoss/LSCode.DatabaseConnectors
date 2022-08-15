using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.Interfaces;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of OracleContext connections.</summary>
    public class OracleContext : IOracleContext
    {
        /// <value>Represents a connection to a Oracle database.</value>
        public OracleConnection Connetion { get; private set; }

        /// <summary>OracleContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the OracleContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public OracleContext(IConfiguration configuration)
        {
            Connetion = new OracleConnection(configuration[KeyNames.ConnectionStringOracle]);
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