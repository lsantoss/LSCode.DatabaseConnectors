namespace LSCode.ConexoesBD.Enums
{
    /// <summary>Contém a lista de tipos de base de dados suportados.</summary>
    public enum EBancoDados
    {
        /// <value>Utilizada na conexão com bases de dados relacionais.</value>
        Relacional = 1,

        /// <value>Utilizada na conexão com bases de dados não relacionais.</value>
        NaoRelacional = 2
    }
}