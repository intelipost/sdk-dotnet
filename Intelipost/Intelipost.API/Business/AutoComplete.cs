using Intelipost.API.Model;

namespace Intelipost.API.Business
{
    /// <summary>
    /// Classe destinada a tratar todas as regras de negócios, aplicadas a API.
    /// </summary>
    internal class Autocomplete
    {
        /// <summary>
        /// Executa a requisição contra a InteliPost.
        /// </summary>
        /// <returns>Retorna as informações do CEP informado.</returns>
        internal Response<Model.AutoComplete> RequestAutocomplete(string cep)
        {
            return new Infrastructure.JsonRequest.Request<Model.AutoComplete>().Execute(Configure.PublicInstance.ApiKey, Configure.PublicInstance.ApiUrl, "/cep_location/address_complete/"+cep, "GET", null);
        }
    }
}