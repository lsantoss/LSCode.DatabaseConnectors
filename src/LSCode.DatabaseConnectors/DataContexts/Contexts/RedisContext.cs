using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using StackExchange.Redis;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Contexts
{
    /// <summary>Provides implementation of Redis connections.</summary>
    public class RedisContext : IRedisContext
    {
        /// <value>Represents a connection to a Redis database.</value>
        public ConnectionMultiplexer Connection { get; private set; }

        /// <summary>RedisContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the Redis database.</param>
        /// <returns>Create an instance of the RedisContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public RedisContext(string connectionString)
        {
            Connection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(connectionString);
            }).Value;
        }

        /// <summary>Closes connections used by the current class.</summary>
        /// <exception cref="Exception">Error closing used connections</exception>
        public void Dispose()
        {
            if (Connection.IsConnected)
                Connection.Close();
        }
    }
}