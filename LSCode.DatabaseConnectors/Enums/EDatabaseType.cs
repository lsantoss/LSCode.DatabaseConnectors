namespace LSCode.DatabaseConnectors.Enums
{
    /// <summary>Contains the list of supported database types.</summary>
    public enum EDatabaseType
    {
        /// <value>Used when connecting to relational databases.</value>
        Relacional = 1,

        /// <value>Used when connecting to non-relational databases.</value>
        NaoRelacional = 2
    }
}