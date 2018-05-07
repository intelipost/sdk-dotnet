using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class ShippedWithDate
    {
        /// <summary>
        /// Executa a requisição na InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para marcar diversos pedidos como "Enviados".</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>
        internal Response<Model.ShippedWithDate[]> RequestShippedWithDate(Request<Model.ShippedWithDate[]> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.ShippedWithDate[]>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/multi/shipped/with_date", "POST", request, null, Configure.PublicInstance.Platform, Configure.PublicInstance.PlatformVersion, Configure.PublicInstance.Plugin, Configure.PublicInstance.PluginVersion);
        }
    }
}
