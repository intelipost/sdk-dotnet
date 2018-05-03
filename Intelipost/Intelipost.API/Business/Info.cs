using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class Info
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <returns>Retorna os métodos de envio ativos para o cliente.</returns>
        internal Response<Model.Info> RequestInfo()
        {
            return new Infrastructure.JsonRequest.Request<Model.Info>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/info/", "GET", null, null, Configure.PublicInstance.Platform, Configure.PublicInstance.PlatformVersion, Configure.PublicInstance.Plugin, Configure.PublicInstance.PluginVersion);
        }
    }
}