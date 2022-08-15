using MongoDB.Driver;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Interfaces
{
    /// <summary>Provides contract for implementing MongoDB connections.</summary>
    public interface IMongoDBContext : IDisposable
    {
        /// <value>Represents a connection to a MongoDB database.</value>
        IMongoDatabase Connetion { get; }

        /// <summary>Gets a collection.</summary>
        /// <typeparam name="T">The document type.</typeparam>
        /// <returns>An implementation of a collection.</returns>
        IMongoCollection<T> GetCollection<T>();

        /// <summary>Gets a collection.</summary>
        /// <typeparam name="T">The document type.</typeparam>
        /// <returns>An implementation of a collection.</returns>
        IMongoCollection<T> GetCollection<T>(string collectionName);
    }
}