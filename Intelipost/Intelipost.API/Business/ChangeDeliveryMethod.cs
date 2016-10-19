using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class ChangeDeliveryMethod
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a criação do pedido.</param>
        /// <returns>Retorna um  objeto com as informações do pedido</returns>
        internal Response<Model.ChangeDeliveryMethod> RequestChangeDeliveryMethod(Request<Model.ChangeDeliveryMethod> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.ChangeDeliveryMethod>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "shipment_order/change_delivery_method", "POST", request, null, Configure.PublicInstance.Platform);
        }
    }
}