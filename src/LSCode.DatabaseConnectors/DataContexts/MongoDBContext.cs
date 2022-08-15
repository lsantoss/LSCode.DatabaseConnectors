using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Provides implementation of MongoDBContext connections.</summary>
    public class MongoDBContext : IMongoDBContext
    {
        /// <value>Represents a connection to a MongoDB database.</value>
        public IMongoDatabase Connection { get; private set; }

        /// <summary>MongoDBContext class constructor.</summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        /// <returns>Create an instance of the MongoDBContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public MongoDBContext(IConfiguration configuration)
        {
            Connection = new MongoClient(configuration[KeyNames.ConnectionStringMongoDB]).GetDatabase(configuration[KeyNames.DatabaseNameMongoDB]);
        }

        /// <summary>Closes connections used by the current class.</summary>
        /// <exception cref="Exception">Error closing used connections</exception>
        public void Dispose()
        {
            if (Connection != null)
                Connection = null;
        }

        /// <summary>Gets a collection.</summary>
        /// <typeparam name="T">The document type.</typeparam>
        /// <returns>An implementation of a collection.</returns>
        public IMongoCollection<T> GetCollection<T>() => Connection.GetCollection<T>(typeof(T).Name);

        /// <summary>Gets a collection.</summary>
        /// <typeparam name="T">The document type.</typeparam>
        /// <returns>An implementation of a collection.</returns>
        public IMongoCollection<T> GetCollection<T>(string collectionName) => Connection.GetCollection<T>(collectionName);
    }
}