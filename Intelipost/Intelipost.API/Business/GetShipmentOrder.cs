using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API, da cotação.
    /// </summary>
    internal class GetShipmentOrder
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        internal Response<Model.GetShipmentOrder> RequestGetShipmentOrder(string OrderNumber)
        {
            return new Infrastructure.JsonRequest.Request<Model.GetShipmentOrder>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/"+ OrderNumber, "GET", null);
        }
    }
}