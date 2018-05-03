using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class GetShipmentOrder
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <returns>Retorna as informações do pedido informado.</returns>
        internal Response<Model.GetShipmentOrder> RequestGetShipmentOrder(string OrderNumber)
        {
            return new Infrastructure.JsonRequest.Request<Model.GetShipmentOrder>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/"+ OrderNumber, "GET", null, null, Configure.PublicInstance.Platform, Configure.PublicInstance.PlatformVersion, Configure.PublicInstance.Plugin, Configure.PublicInstance.PluginVersion);
        }
    }
}