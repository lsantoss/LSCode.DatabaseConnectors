using MongoDB.Driver;
using System;

namespace LSCode.DatabaseConnectors.Interfaces
{
    /// <summary>Provides contract for implementing MongoDB connections.</summary>
    public interface IMongoDBContext : IDisposable
    {
        /// <value>Represents a connection to a MongoDB database.</value>
        IMongoDatabase Connetion { get; }
    }
}