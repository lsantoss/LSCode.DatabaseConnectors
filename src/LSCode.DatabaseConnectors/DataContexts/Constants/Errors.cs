using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.DatabaseConnectors.Test.Unit")]
namespace LSCode.DatabaseConnectors.DataContexts.Constants
{
    /// <summary>Provides all error messages present in that package.</summary>
    internal static class Errors
    {
        /// <value>The parameter connectionString must contain values. Cannot be null, empty or consists only of white-space characters.</value>
        internal static string ConnectionStingNullEmptyOrWhiteSpace = @"The parameter connectionString must contain values. Cannot be null, empty or consists only of white-space characters.";

        /// <value>The parameter databaseName must contain values. Cannot be null, empty or consists only of white-space characters.</value>
        internal static string DatabaseNameNullEmptyOrWhiteSpace = @"The parameter databaseName must contain values. Cannot be null, empty or consists only of white-space characters.";
    }
}