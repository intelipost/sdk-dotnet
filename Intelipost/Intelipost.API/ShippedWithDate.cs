using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a marcar diversos pedidos como enviados
    /// </summary>
    public class ShippedWithDate
    {
        /// <summary>
        /// Executa a requisição para marcar diversos pedidos como enviados
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um objeto com as informações de resposta da requsição.</returns>
        public Response<Model.ShippedWithDate[]> RequestNewShippedWithDate(Request<Model.ShippedWithDate[]> request)
        {
            return new Business.ShippedWithDate().RequestShippedWithDate(request);
        }
    }
}
