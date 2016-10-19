using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class ShipmentOrder
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a criação do pedido.</param>
        /// <returns>Retorna um  objeto com as informações do pedido</returns>
        internal Response<Model.ShipmentOrder> RequestNewShipmentOrder(Request<Model.ShipmentOrder> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.ShipmentOrder>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "shipment_order", "POST", request, null, Configure.PublicInstance.Platform);
        }
    }
}