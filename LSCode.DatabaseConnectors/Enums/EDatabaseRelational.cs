namespace LSCode.DatabaseConnectors.Enums
{
    /// <summary>Contains list of supported relational databases.</summary>
    public enum EDatabaseRelational
    {
        /// <value>Used when connecting to SQLServer databases.</value>
        SQLServer = 1,

        /// <value>Used when connecting to MySQL databases.</value>
        MySQL = 2,

        /// <value>Used when connecting to SQLite databases.</value>
        SQLite = 3,

        /// <value>Used when connecting to PostgreSQL databases.</value>
        PostgreSQL = 4,

        /// <value>Used when connecting to Oracle databases.</value>
        Oracle = 5,

        /// <value>Used when connecting to Firebird databases.</value>
        Firebird = 6
    }
}