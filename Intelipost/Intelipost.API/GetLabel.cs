using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as informações da etiqueta.
    /// </summary>
    public class GetLabel
    {
        /// <summary>
        /// Método para realizar a requisição das informações da etiqueta.
        /// </summary>
        /// <param name="order_number">Numero do pedido.</param>
        /// <param name="order_number">Numero do volume.</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>
        public Response<Model.GetLabel> RequestGetLabel(string order_number, string shipment_order_volume_number)
        {
            return new Business.GetLabel().RequestGetLabel(order_number, shipment_order_volume_number);
        }
    }
}