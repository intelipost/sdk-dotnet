using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada realizar a requisição para marcar um pedido como "Pronto para Envio".
    /// </summary>
    public class ReadyForShipment
    {
        /// <summary>
        /// Execute a requisição para marcar um pedido como "Pronto para Envio".
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um objeto com as informações de resposta da requsição.</returns>
        public Response<Model.ReadyForShipment> RequestReadyForShipment(Request<Model.ReadyForShipment> request)
        {
            return new Business.ReadyForShipment().RequestReadyForShipment(request);
        }
    }
}