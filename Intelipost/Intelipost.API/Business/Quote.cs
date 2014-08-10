using Intelipost.API.Model;
using Request = Intelipost.API.Model.Request;

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
        /// <param name="modelRequest">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        internal Response RequestNewQuote(Request modelRequest)
        {
            return new Infrastructure.JsonRequest.Request().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "quote", "POST", modelRequest);
        }
    }
}