using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as requisições para a cotação.
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// Execute a requisição de Cotação.
        /// </summary>
        /// <param name="modelRequest">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        public Response Request(Request modelRequest)
        {
            return new Business.Quote().RequestNewQuote(modelRequest);
        }
    }
}