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
        /// <param name="apiUrl">URL da API da Intelipost.</param>
        /// <param name="apiKey">Key de acesso para a API.</param>
        /// <param name="logging">Se o Log será ativado para cada requisição feita.</param>
        public void Initialize(string apiKey, bool logging)
        {
            Business.Configure.PublicInstance.ApiKey = apiKey;
            Business.Configure.PublicInstance.Logging = logging;
        }
    }
}