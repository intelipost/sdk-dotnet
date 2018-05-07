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
        /// Nome ou descrição da plataforma requisitante.
        /// </summary>
        internal string Platform { get; set; }
        /// <summary>
        /// Número da versão da plataforma requisitante
        /// </summary>
        internal string PlatformVersion { get; set; }
        /// <summary>
        /// Descrição do plugin requisitante
        /// </summary>
        internal string Plugin { get; set; }
        /// <summary>
        /// Número da versão do plugin requisitante
        /// </summary>
        internal string PluginVersion { get; set; }
        /// <summary>
        /// Se o Log será ativado para cada requisição feita.
        /// </summary>
        internal bool Logging { get; set; }
        /// <summary>
        /// Se o Log estiver ativo, é necessário passar o caminho completo de onde os arquivos serão gravados.
        /// </summary>
        internal string LogPath { get; set; }

        /// <summary>
        /// Classe destinada a configuração de acesso a API.
        /// </summary>
        Configure()
        {
        }
    }
}