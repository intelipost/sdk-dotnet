using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class ReadyForShipmentWithDate
    {
        /// <summary>
        /// Executa a requisição na InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para marcar diversos pedidos como "Prontos para Envio".</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>
        internal Response<Model.ReadyForShipmentWithDate[]> RequestReadyForShipmentWithDate(Request<Model.ReadyForShipmentWithDate[]> request)
        {
            return new Infrastructure.JsonRequest.Request<Model.ReadyForShipmentWithDate[]>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/shipment_order/multi/ready_for_shipment/with_date", "POST", request, null, Configure.PublicInstance.Platform, Configure.PublicInstance.PlatformVersion, Configure.PublicInstance.Plugin, Configure.PublicInstance.PluginVersion);
        }
    }
}
