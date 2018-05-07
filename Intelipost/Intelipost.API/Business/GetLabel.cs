using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class GetLabel
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <returns>Retorna as informações da etiqueta</returns>
        internal Response<Model.GetLabel> RequestGetLabel(string order_number, string shipment_order_volume_number)
        {
            return new Infrastructure.JsonRequest.Request<Model.GetLabel>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/get_label/"+order_number+"/"+shipment_order_volume_number, "GET", null, null, Configure.PublicInstance.Platform, Configure.PublicInstance.PlatformVersion, Configure.PublicInstance.Plugin, Configure.PublicInstance.PluginVersion);
        }
    }
}