using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using MongoDB.Driver;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Contexts
{
    /// <summary>Provides implementation of MongoDB connections.</summary>
    public class MongoDBContext : IMongoDBContext
    {
        /// <value>Represents a connection to a MongoDB database.</value>
        public IMongoDatabase Connection { get; private set; }

        /// <summary>MongoDBContext class constructor.</summary>
        /// <param name="connectionString">The connection used to open the MongoDB database.</param>
        /// <param name="databaseName">Name of the database used in the connection.</param>
        /// <returns>Create an instance of the MongoDBContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            Connection = client.GetDatabase(databaseName);
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