using System;
namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a inicializar as configurações necessárias para as requisições.
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// Inicializa as configurações com os seus respectivos valores.
        /// </summary>
        /// <param name="apiKey">Key de acesso para a API.</param>
        /// <param name="logging">Se o Log será ativado para cada requisição feita.</param>
        /// <param name="logPath">Se o Log estiver ativo, é necessário passar o caminho completo de onde os arquivos serão gravados.</param>
        /// <param name="platform">Plataforma que está requisitando os serviços da API</param>
        /// <param name="platformVersion">Versão da plataforma requisitante</param>
        /// <param name="plugin">Plugin que está requisitando os serviços da API</param>
        /// <param name="pluginVersion">Versão do plugin requisitante</param>
        public void Initialize(string apiKey, bool logging, string logPath, string platform = null, string platformVersion = null, string plugin = null, string pluginVersion = null)
        {
            Business.Configure.PublicInstance.ApiKey = apiKey;
            Business.Configure.PublicInstance.Platform = platform;
            Business.Configure.PublicInstance.Logging = logging;
            Business.Configure.PublicInstance.PlatformVersion = platformVersion;
            Business.Configure.PublicInstance.Plugin = plugin;
            Business.Configure.PublicInstance.PluginVersion = pluginVersion;

            if (logging)
            {
                if (!string.IsNullOrEmpty(logPath))
                {
                    Business.Configure.PublicInstance.LogPath = logPath;
                }
                else
                {
                    throw new Exception("É necessário enviar o caminho físico de onde serão gravados os logs.");
                }
            }
        }
    }
}