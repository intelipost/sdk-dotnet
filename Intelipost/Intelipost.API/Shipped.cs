using Intelipost.API.Model;
using System;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a executar a requisição para marcar um pedido como "Enviado".
    /// </summary>
    [Obsolete("Use ShippedWithDate instead", false)]
    public class Shipped
    {
        /// <summary>
        /// Execute a requisição para marcar um pedido como "Enviado".
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a requisição.</param>
        /// <returns>Retorna um objeto com as informações de resposta da request.</returns>
        public Response<Model.Shipped> RequestShipped(Request<Model.Shipped> request)
        {
            return new Business.Shipped().RequestShipped(request);
        }
    }
}