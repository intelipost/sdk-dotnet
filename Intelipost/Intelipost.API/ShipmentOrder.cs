using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a criação de um pedido de envio.
    /// </summary>
    public class ShipmentOrder
    {
        /// <summary>
        /// Execute a criação de um pedido de envio
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um pedido de envio preenchido ou mensagem de erro.</returns>
        public Response<Model.ShipmentOrder> RequestNewShipmentOrder(Request<Model.ShipmentOrder> request)
        {
            return new Business.ShipmentOrder().RequestNewShipmentOrder(request);
        }
    }
}