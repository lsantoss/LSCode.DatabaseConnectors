using LSCode.DatabaseConnectors.Constants;
using LSCode.DatabaseConnectors.DataContexts;
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LSCode.DatabaseConnectors.Extensions
{
    /// <summary>Provides the implementation to facilitate dependency injection of the features present in this package.</summary>
    public static class DependencyInjectionExtension
    {
        /// <summary>Extension to facilitate the use of connection contexts in Firebird databases.</summary>
        public static IServiceCollection AddFirebirdContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringFirebird]))
                throw new ArgumentException($"{KeyNames.ConnectionStringFirebird} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IFirebirdContext, FirebirdContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in MongoDB databases.</summary>
        public static IServiceCollection AddMongoDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringMongoDB]))
                throw new ArgumentException($"{KeyNames.ConnectionStringMongoDB} : {Errors.KeyNullEmptyOrWhiteSpace}");

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.DatabaseNameMongoDB]))
                throw new ArgumentException($"{KeyNames.DatabaseNameMongoDB} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IMongoDBContext, MongoDBContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in MySQL databases.</summary>
        public static IServiceCollection AddMySQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringMySQL]))
                throw new ArgumentException($"{KeyNames.ConnectionStringMySQL} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IMySQLContext, MySQLContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in Oracle databases.</summary>
        public static IServiceCollection AddOracleContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringOracle]))
                throw new ArgumentException($"{KeyNames.ConnectionStringOracle} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IOracleContext, OracleContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in PostgreSQL databases.</summary>
        public static IServiceCollection AddPostgreSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringPostgreSQL]))
                throw new ArgumentException($"{KeyNames.ConnectionStringPostgreSQL} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IPostgreSQLContext, PostgreSQLContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in Redis databases.</summary>
        public static IServiceCollection AddRedisContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringRedis]))
                throw new ArgumentException($"{KeyNames.ConnectionStringRedis} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<IRedisContext, RedisContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in SQLite databases.</summary>
        public static IServiceCollection AddSQLiteContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringSQLite]))
                throw new ArgumentException($"{KeyNames.ConnectionStringSQLite} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<ISQLiteContext, SQLiteContext>();

            return services;
        }

        /// <summary>Extension to facilitate the use of connection contexts in SQLServer databases.</summary>
        public static IServiceCollection AddSQLServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException(Errors.IConfigurationNull);

            if (string.IsNullOrWhiteSpace(configuration[KeyNames.ConnectionStringSQLServer]))
                throw new ArgumentException($"{KeyNames.ConnectionStringSQLServer} : {Errors.KeyNullEmptyOrWhiteSpace}");

            services.AddScoped<ISQLServerContext, SQLServerContext>();

            return services;
        }
    }
}