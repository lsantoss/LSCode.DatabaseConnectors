using LSCode.DatabaseConnectors.DataContexts.Constants;
using LSCode.DatabaseConnectors.DataContexts.Contexts;
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LSCode.DatabaseConnectors.DataContexts.Extensions
{
    /// <summary>Provides the implementation to facilitate dependency injection of the features present in this package.</summary>
    public static class DependencyInjectionExtension
    {
        /// <summary>Extension for using connection contexts in databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="databaseManagementSystem">The database management system.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        /// <param name="databaseName">Name of the database used in the connection.</param>
        public static IServiceCollection AddDataContext(this IServiceCollection services, DatabaseManagementSystem databaseManagementSystem, string connectionString, string databaseName = null)
        {
            switch (databaseManagementSystem)
            {
                case DatabaseManagementSystem.Firebird:
                    services.AddFirebirdContext(connectionString);
                    break;
                case DatabaseManagementSystem.MongoDB:
                    services.AddMongoDBContext(connectionString, databaseName);
                    break;
                case DatabaseManagementSystem.MySQL:
                    services.AddMySQLContext(connectionString);
                    break;
                case DatabaseManagementSystem.Oracle:
                    services.AddOracleContext(connectionString);
                    break;
                case DatabaseManagementSystem.PostgreSQL:
                    services.AddPostgreSQLContext(connectionString);
                    break;
                case DatabaseManagementSystem.Redis:
                    services.AddRedisContext(connectionString);
                    break;
                case DatabaseManagementSystem.SQLite:
                    services.AddSQLiteContext(connectionString);
                    break;
                case DatabaseManagementSystem.SQLServer:
                    services.AddSQLServerContext(connectionString);
                    break;
                default:
                    throw new ArgumentException(Errors.InvalidDatabaseManagementSystem);
            }

            return services;
        }

        /// <summary>Extension to use of connection contexts in Firebird databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddFirebirdContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<IFirebirdContext, FirebirdContext>(setup => new FirebirdContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in MongoDB databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        /// <param name="databaseName">Name of the database used in the connection.</param>
        private static IServiceCollection AddMongoDBContext(this IServiceCollection services, string connectionString, string databaseName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException(Errors.DatabaseNameNullEmptyOrWhiteSpace);

            services.AddScoped<IMongoDBContext, MongoDBContext>(setup => new MongoDBContext(connectionString, databaseName));

            return services;
        }

        /// <summary>Extension to use of connection contexts in MySQL databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddMySQLContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<IMySQLContext, MySQLContext>(setup => new MySQLContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in Oracle databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddOracleContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<IOracleContext, OracleContext>(setup => new OracleContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in PostgreSQL databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddPostgreSQLContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<IPostgreSQLContext, PostgreSQLContext>(setup => new PostgreSQLContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in Redis databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddRedisContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<IRedisContext, RedisContext>(setup => new RedisContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in SQLite databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddSQLiteContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<ISQLiteContext, SQLiteContext>(setup => new SQLiteContext(connectionString));

            return services;
        }

        /// <summary>Extension to use of connection contexts in SQLServer databases.</summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        private static IServiceCollection AddSQLServerContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(Errors.ConnectionStingNullEmptyOrWhiteSpace);

            services.AddScoped<ISQLServerContext, SQLServerContext>(setup => new SQLServerContext(connectionString));

            return services;
        }
    }
}