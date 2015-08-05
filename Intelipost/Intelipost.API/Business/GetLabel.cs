using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API, da cotação.
    /// </summary>
    internal class GetLabel
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        internal Response<Model.GetLabel> RequestGetLabel(string order_number, string shipment_order_volume_number)
        {
            return new Infrastructure.JsonRequest.Request<Model.GetLabel>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/get_label/"+order_number+"/"+shipment_order_volume_number, "GET", null);
        }
    }
}