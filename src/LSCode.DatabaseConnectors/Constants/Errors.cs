using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.DatabaseConnectors.Test.Unit")]
namespace LSCode.DatabaseConnectors.Constants
{
    /// <summary>Provides all error messages present in that package.</summary>
    internal static class Errors
    {
        /// <value>The configuration parameter cannot be null.</value>
        internal static string IConfigurationNull = "The configuration parameter cannot be null";

        /// <value>The key must contain values. Check if this property exists, if it contains a value or if it has the wrong name.</value>
        internal static string KeyNullEmptyOrWhiteSpace = @"The key must contain values. Check if this property exists, if it contains a value or if it has the wrong name.";
    }
}