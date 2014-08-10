using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por qualquer requisição feita.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// O CEP de origem da encomenda (CEP de postagem).
        /// </summary>
        [JsonProperty("origin_zip_code")]
        public string OriginZipCode { get; set; }
        /// <summary>
        /// O CEP de destino da encomenda.
        /// </summary>
        [JsonProperty("destination_zip_code")]
        public string DestinationZipCode { get; set; }
        /// <summary>
        /// Conjunto de volumes desta encomenda.
        /// </summary>
        [JsonProperty("volumes")]
        public List<Volume> Volumes { get; set; }

        public Request()
        {
            Volumes = new List<Volume>();
        }
    }
}