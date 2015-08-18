using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as informações do pedido.
    /// </summary>
    public class GetShipmentOrder
    {
        /// <summary>
        /// Requisição para obter as informações de um pedido.
        /// </summary>
        /// <returns>Retorna as informações do pedido informado.</returns>
        public Response<Model.GetShipmentOrder> RequestGetShipmentOrder(string OrderNumber)
        {
            return new Business.GetShipmentOrder().RequestGetShipmentOrder(OrderNumber);
        }
    }
}