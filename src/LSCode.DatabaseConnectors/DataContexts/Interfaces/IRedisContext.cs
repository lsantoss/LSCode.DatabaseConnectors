using StackExchange.Redis;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing Redis connections.</summary>
    public interface IRedisContext : IDisposable
    {
        /// <value>Represents a connection to a Redis database.</value>
        ConnectionMultiplexer Connection { get; }
    }
}