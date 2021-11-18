namespace LSCode.ConexoesBD.Enums
{
    /// <summary>Contém a lista de base de dados relacionais suportados.</summary>
    public enum EBancoDadosRelacional
    {
        /// <value>Utilizada na conexão com bases de dados SQLServer.</value>
        SQLServer = 1,

        /// <value>Utilizada na conexão com bases de dados MySQL.</value>
        MySQL = 2,

        /// <value>Utilizada na conexão com bases de dados SQLite.</value>
        SQLite = 3,

        /// <value>Utilizada na conexão com bases de dados PostgreSQL.</value>
        PostgreSQL = 4,

        /// <value>Utilizada na conexão com bases de dados Oracle.</value>
        Oracle = 5,

        /// <value>Utilizada na conexão com bases de dados Firebird.</value>
        Firebird = 6
    }
}