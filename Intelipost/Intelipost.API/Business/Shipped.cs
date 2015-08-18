using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class Shipped
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>
        internal Response<Model.Shipped> RequestShipped(Request<Model.Shipped> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.Shipped>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/shipped", "POST", request);
        }
    }
}