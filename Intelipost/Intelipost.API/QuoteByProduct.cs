using Intelipost.API.Model;


namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as requisições para a cotação.
    /// </summary>
    public class QuoteByProduct
    {
        /// <summary>
        /// Execute a requisição de Cotação.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        public Response<Model.Quote> RequestNewQuoteByProduct(Request<Model.Quote> request, string debug_hash = null)
        {
            return new Business.QuoteByProduct().RequestNewQuoteByProduct(request,debug_hash);
        }
    }
}