using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as requisições para a cotação.
    /// </summary>
    public class GetLabel
    {
        /// <summary>
        /// Execute a requisição de Cotação.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        public Response<Model.GetLabel> RequestGetLabel(string order_number, string shipment_order_volume_number)
        {
            return new Business.GetLabel().RequestGetLabel(order_number, shipment_order_volume_number);
        }
    }
}