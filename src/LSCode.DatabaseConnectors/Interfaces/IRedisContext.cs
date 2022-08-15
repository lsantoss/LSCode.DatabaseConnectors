using StackExchange.Redis;
using System;

namespace LSCode.DatabaseConnectors.Interfaces
{
    /// <summary>Provides contract for implementing Redis connections.</summary>
    public interface IRedisContext : IDisposable
    {
        /// <value>Representa uma conexão com um banco de dados Redis.</value>
        ConnectionMultiplexer Connetion { get; }
    }
}