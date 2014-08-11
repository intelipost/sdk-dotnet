namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a manter as configurações necessárias para as requisições.
    /// </summary>
    internal sealed class Configure
    {
        static readonly Configure Instance = new Configure();

        /// <summary>
        /// Instância única da classe Configure.
        /// </summary>
        internal static Configure PublicInstance { get { return Instance; } }

        /// <summary>
        /// URL da API da Intelipost.
        /// </summary>
        internal string ApiUrl { get { return "https://api.intelipost.com.br/api/v1"; } }
        /// <summary>
        /// Key de acesso para a API.
        /// </summary>
        internal string ApiKey { get; set; }
        /// <summary>
        /// Se o Log será ativado para cada requisição feita.
        /// </summary>
        internal bool Logging { get; set; }

        /// <summary>
        /// Classe destinada a configuração de acesso a API.
        /// </summary>
        Configure()
        {
        }
    }
}