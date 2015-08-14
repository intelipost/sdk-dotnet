using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API, da cotação.
    /// </summary>
    internal class Autocomplete
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <param name="request">Entidade Request devidamente preenchida para a cotação.</param>
        /// <returns>Retorna uma cotação preenchida ou mensagem de erro.</returns>
        internal Response<Model.AutoComplete> RequestAutocomplete(string cep)
        {
            return new Infrastructure.JsonRequest.Request<Model.AutoComplete>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/cep_location/address_complete/"+cep, "GET", null);
        }
    }
}