﻿using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SQLite;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of SQLiteContext connections.</summary>
    public class SQLiteContext : ISQLiteContext
    {
        /// <value>Represents a connection to a SQLite database.</value>
        public SQLiteConnection Connetion { get; private set; }

        /// <summary>SQLiteContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the SQLiteContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public SQLiteContext(IConfiguration configuration)
        {
            Connetion = new SQLiteConnection(configuration[KeyNames.ConnectionStringSQLite]);
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