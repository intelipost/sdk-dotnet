using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class Identification
    {
        /// <summary>
        /// Código da sessão.
        /// </summary>
        [JsonProperty("session")]
        public string Session{ get; set; }

        /// <summary>
        /// Endereço de IP
        /// </summary>
        [JsonProperty("ip")]
        public string ip { get; set; }

        /// <summary>
        /// Nome da Pagina
        /// </summary>
        [JsonProperty("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }        
    }
}