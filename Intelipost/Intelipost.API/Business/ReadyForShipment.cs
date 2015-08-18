using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class ReadyForShipment
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para marcar o pedido como "Pronto para Envio".</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>
        internal Response<Model.ReadyForShipment> RequestReadyForShipment(Request<Model.ReadyForShipment> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.ReadyForShipment>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/ready_for_shipment", "POST", request);
        }
    }
}