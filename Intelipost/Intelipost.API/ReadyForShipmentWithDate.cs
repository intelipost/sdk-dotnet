using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a marcar diversos pedidos como pronto para envio
    /// </summary>
    public class ReadyForShipmentWithDate
    {
        /// <summary>
        /// Executa a requisição para marcar diversos pedidos como prontos para envio
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um objeto com as informações de resposta da requsição.</returns>
        public Response<Model.ReadyForShipmentWithDate[]> RequestNewReadyForShipmentWithDate(Request<Model.ReadyForShipmentWithDate[]> request)
        {
            return new Business.ReadyForShipmentWithDate().RequestReadyForShipmentWithDate(request);
        }
    }
}
