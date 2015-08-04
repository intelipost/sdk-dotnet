using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as requisições para a cotação.
    /// </summary>
    public class ReadyForShipment
    {
        /// <summary>
        /// Execute a requisição de Cotação.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        public Response<Model.ReadyForShipment> RequestReadyForShipment(Request<Model.ReadyForShipment> request)
        {
            return new Business.ReadyForShipment().RequestReadyForShipment(request);
        }
    }
}