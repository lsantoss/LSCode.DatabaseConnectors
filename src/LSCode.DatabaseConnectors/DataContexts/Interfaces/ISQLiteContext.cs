﻿using System;
using System.Data.SQLite;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing SQLite connections.</summary>
    public interface ISQLiteContext : IDisposable
    {
        /// <value>Represents a connection to a SQLite database.</value>
        SQLiteConnection Connection { get; }
    }
}