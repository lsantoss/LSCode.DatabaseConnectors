using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.DatabaseConnectors.Test.Unit")]
namespace LSCode.DatabaseConnectors.Constants
{
    /// <summary>Provides all key names present in this package.</summary>
    internal static class KeyNames
    {
        /// <value>ConnectionStringFirebird</value>
        internal static string ConnectionStringFirebird = "ConnectionStringFirebird";

        /// <value>ConnectionStringMongoDB</value>
        internal static string ConnectionStringMongoDB = "ConnectionStringMongoDB";

        /// <value>DatabaseNameMongoDB</value>
        internal static string DatabaseNameMongoDB = "DatabaseNameMongoDB";

        /// <value>ConnectionStringMySQL</value>
        internal static string ConnectionStringMySQL = "ConnectionStringMySQL";

        /// <value>ConnectionStringOracle</value>
        internal static string ConnectionStringOracle = "ConnectionStringOracle";

        /// <value>ConnectionStringPostgreSQL</value>
        internal static string ConnectionStringPostgreSQL = "ConnectionStringPostgreSQL";

        /// <value>ConnectionStringRedis</value>
        internal static string ConnectionStringRedis = "ConnectionStringRedis";

        /// <value>ConnectionStringSQLite</value>
        internal static string ConnectionStringSQLite = "ConnectionStringSQLite";

        /// <value>ConnectionStringSQLServer</value>
        internal static string ConnectionStringSQLServer = "ConnectionStringSQLServer";
    }
}