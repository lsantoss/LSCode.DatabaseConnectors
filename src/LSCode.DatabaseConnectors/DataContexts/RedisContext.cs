using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of RedisContext connections.</summary>
    public class RedisContext : IRedisContext
    {
        /// <value>Represents a connection to a Redis database.</value>
        public ConnectionMultiplexer Connection { get; private set; }

        /// <summary>RedisContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the RedisContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public RedisContext(IConfiguration configuration)
        {
            Connection = new Lazy<ConnectionMultiplexer>(() => { 
                return ConnectionMultiplexer.Connect(configuration[KeyNames.ConnectionStringRedis]); 
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