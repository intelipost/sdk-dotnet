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
        public void Initialize(string apiKey, bool logging, string logPath, string platform = null)
        {
            Business.Configure.PublicInstance.ApiKey = apiKey;
            Business.Configure.PublicInstance.Platform = platform;
            Business.Configure.PublicInstance.Logging = logging;

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