using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as requisições para CEP - Autocomplete.
    /// </summary>
    public class AutoComplete
    {
        /// <summary>
        /// Execute a requisição de AutoComplete.
        /// </summary>        
        /// <returns>Retorna as informações do CEP informado.</returns>
        public Response<Model.AutoComplete> RequestAutoComplete(string cep)
        {
            return new Business.Autocomplete().RequestAutocomplete(cep);
        }
    }
}