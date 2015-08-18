using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class AutoComplete
    {
        /// <summary>
        /// Estado
        /// </summary>
        [JsonProperty("state")]
        public string State{ get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Nome da Rua.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// UF
        /// </summary>
        [JsonProperty("state_short")]
        public string StateShort { get; set; }

        /// <summary>
        /// Código IBGE da cidade.
        /// </summary>
        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        /// <summary>
        /// Informações Adicionais.
        /// </summary>
        [JsonProperty("additional_info")]
        public string AdditionalInfo { get; set; }  
    }
}