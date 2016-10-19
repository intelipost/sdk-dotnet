using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API, da cotação.
    /// </summary>
    internal class Quote
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        internal Response<Model.Quote> RequestNewQuote(Request<Model.Quote> request, string debug_hash = null)
        {
            return new Infrastructure.JsonRequest.Request<Model.Quote>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "quote", "POST", request,debug_hash, Configure.PublicInstance.Platform);
        }
    }
}